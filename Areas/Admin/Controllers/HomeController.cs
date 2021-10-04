
using DCDGear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DCDGear.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        private DCDGearDbContext db = new DCDGearDbContext();
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}