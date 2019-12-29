using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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

        // Division update ***
        [HttpGet]
        public ActionResult DivisionUpdate(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Division de = db.Divisions.Find(id);
            if (de == null)
            {
                return HttpNotFound();
            }
            return View(de);
        }

        [HttpPost]
        public ActionResult DivisionUpdate([Bind(Include = "Division_ID,Division_Name")] Division division)
        {
            if (ModelState.IsValid)
            {
                db.Entry(division).State = EntityState.Modified; 
                db.SaveChanges();
                return RedirectToAction("DivisionList");
            }
            return View(division);
        }

        // Zila insert action ***
        public ActionResult Zila()
        {
            ViewBag.Division_ID = new SelectList(db.Divisions,"Division_ID", "Division_Name");
            return View();
        }
        [HttpPost]
        public ActionResult Zila([Bind(Include = "Zila_ID,Zila_Name,Division_ID")] Zila zila)
        {
            if (ModelState.IsValid)
            {
                db.Zilas.Add(zila);
                db.SaveChanges();
                return RedirectToAction("Zilalist");
            }
            ViewBag.Division_ID = new SelectList(db.Divisions, "Division_ID", "Division_Name");
            return View(zila);
        }

        // Zila List ***
        public ActionResult Zilalist()
        {
            return View(db.Zilas.ToList());
        }

        // Zila Update ***
        [HttpGet]
        public ActionResult ZilaUpdate(int?id)
        {
            ViewBag.Division_ID = new SelectList(db.Divisions, "Division_ID", "Division_Name");
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zila zila = db.Zilas.Find(id);
            if (zila == null)
            {
                return HttpNotFound();
            }
            
            return View(zila);
        }
        [HttpPost]
        public ActionResult ZilaUpdate([Bind(Include = "Zila_ID,Zila_Name,Division_ID")] Zila zila, int Division_ID)
        {
            zila.Division_ID = Division_ID;
            if (ModelState.IsValid)
            {
                db.Entry(zila).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Zilalist");
            }
            ViewBag.Division_ID = new SelectList(db.Divisions, "Division_ID", "Division_Name");
            return View(zila);

        }

        //Upozila Insert Action ***
        [HttpGet]
        public ActionResult Upozila()
        {
            ViewBag.Zila_Id = new SelectList(db.Zilas, "Zila_Id", "Zila_Name");
            return View();
        }
        [HttpPost]
        public ActionResult Upozila([Bind(Include = "Upozila_ID,Upozila_Name,Zila_Id")] Upozila upozila)
        {
            if (ModelState.IsValid)
            {
                db.Upozilas.Add(upozila);
                db.SaveChanges();
                return RedirectToAction("UpozilaList");
            }
            ViewBag.Zila_Id = new SelectList(db.Zilas, "Zila_Id", "Zila_Name");
            return View(upozila);
        }

        // UpozilaList Action ***
        public ActionResult UpozilaList()
        {
            return View(db.Upozilas.ToList());
        }

        // UpozilaUpdate Action ***
        [HttpGet]
        public ActionResult UpozilaUpdate(int? id)
        {
            ViewBag.Zila_Id = new SelectList(db.Zilas, "Zila_Id","Zila_Name");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Upozila upozila = db.Upozilas.Find(id);
            if (upozila == null)
            {
                return HttpNotFound();
            }
            return View(upozila);
        }

        [HttpPost]
        public ActionResult UpozilaUpdate([Bind(Include = "Upozila_ID,Upozila_Name,Zila_Id")] Upozila upozila, int Zila_Id)
        {
            if (ModelState.IsValid)
            {
                db.Entry(upozila).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UpozilaList");
            }
            return View(upozila);

        }


    }
}