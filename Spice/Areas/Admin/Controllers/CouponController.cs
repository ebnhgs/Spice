using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CouponController : Controller
    {
        private readonly ApplicationDbContext _db;
       
        [BindProperty]
        public Coupon Coupon { get; set; }

        public CouponController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var coupons = await _db.Coupon.ToListAsync();
            return View(coupons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)

            {
                return View(Coupon);
            }

            var files = HttpContext.Request.Form.Files;

            if (files.Count > 0)
            {
                //files were uploaded
                byte[] p1 = null;
                using (var fileStream1 = files[0].OpenReadStream())
                {
                    //for memory stream
                    using (var memoryStream1 = new MemoryStream())
                    {
                        //converts image into a stream of bytes
                        //and stores it into p1
                        fileStream1.CopyTo(memoryStream1);
                        p1 = memoryStream1.ToArray();
                    }
                }
                Coupon.Picture = p1;
            }

            _db.Coupon.Add(Coupon);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



    }
}
