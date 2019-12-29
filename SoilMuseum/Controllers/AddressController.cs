using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoilMuseum.Models;

namespace SoilMuseum.Controllers
{
    public class AddressController : Controller
    {
        Models.SoilMuseumEntities1 db = new SoilMuseumEntities1();
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        // Division Insert action ****
        [HttpGet]
        public ActionResult Division()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Division([Bind(Include = "Division_ID,Division_Name")] Division division)
        {
            if (ModelState.IsValid)
            {
                db.Divisions.Add(division);
                db.SaveChanges();
                return RedirectToAction("DivisionList");
            }
            return View(division);
        }

        // Division List ***
        public ActionResult DivisionList()
        {
            return View(db.Divisions.ToList());
        }
    
    }
}