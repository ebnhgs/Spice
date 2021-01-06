using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utility;
using Stripe;

namespace Spice.Areas.Customer.Controllers
{
    public class OrderController : Controller
    {

        [Area("Customer")]
        public class CartController : Controller
        {
            private readonly ApplicationDbContext _db;

            [BindProperty]
            public OrderDetailsCart detailCart { get; set; }

            public CartController(ApplicationDbContext db)
            {
                _db = db;
            }



            //[Authorize]
            public async Task<IActionResult> Confirm(int id)
            {
                //Retried user id of logged in user
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

                OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel()
                {
                    OrderHeader = await _db.OrderHeader.Include(o => o.ApplicationUser).FirstOrDefaultAsync(o => o.Id == id && o.userId == claim.Value),
                    OrderDetails = await _db.OrderDetails.Where(o => o.OrderId == id).ToListAsync()
                };

                return View(orderDetailsViewModel);
            }

            [Authorize]
            public async Task<IActionResult> OrderHistory()
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


                List<OrderDetailsViewModel> orderList = new List<OrderDetailsViewModel>();
                List<OrderHeader> OrderHeaderList = await _db.OrderHeader.Include(o => o.ApplicationUser).Where(u => u.userId == claim.Value).ToListAsync();

                foreach (OrderHeader item in OrderHeaderList)
                {
                    OrderDetailsViewModel individual = new OrderDetailsViewModel
                    {
                        OrderHeader = item,
                        OrderDetails = await _db.OrderDetails.Where(o => o.OrderId == item.Id).ToListAsync()
                    };
                    orderList.Add(individual);
                }

                return View(orderList);

            }

            public IActionResult Index()
            {
                return View();
            }
        }
    }
}
