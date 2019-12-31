using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoilMuseum.Models;

namespace SoilMuseum.Controllers
{
    public class SoilDiscriptionController : Controller
    {
        Models.SoilMuseumEntities1 db = new SoilMuseumEntities1();
        // GET: SoilDiscription
        public ActionResult Index()
        {
            return View();
        }

        // Soil Discription ***
        public ActionResult SoilDiscription()
        {
            ViewBag.Upozila_ID = new SelectList(db.Upozilas, "Upozila_ID", "Upozila_Name");
            ViewBag.Employee_ID = new SelectList(db.Employees, "Employee_ID", "Employee_Name");
            return View();

        }
        [HttpPost]
        public ActionResult SoilDiscription([Bind(Include = "Soil_Discription_ID,Makedate,Employee_ID,Image_Id,Discription,Upozila_ID")] Soil_Discription soil_Discription, HttpPostedFileBase postedFile)
        {
            try
            {
                //Extract Image File Name.
                string fileName = System.IO.Path.GetFileName(postedFile.FileName);

                var date = DateTime.Now.Date.ToString("MM/dd/yyyy");
                //Set the Image File Path.
                string filePath = "~/Image/" +date+"_"+fileName;

                //Save the Image File in Folder.
                postedFile.SaveAs(Server.MapPath(filePath));

                //Insert the Image File details in Table.
                Image_Table imgtbl = new Image_Table();

                imgtbl.Image_Path = filePath;
                imgtbl.Make_date = DateTime.Now;
                db.Image_Table.Add(imgtbl);
                //db.SaveChanges();
                int id = imgtbl.Image_ID;
                soil_Discription.Makedate = DateTime.Now;
                soil_Discription.Image_Id = id;
                db.Soil_Discription.Add(soil_Discription);
                db.SaveChanges();
                //Redirect to SoilDiscriptionList Action.
                return RedirectToAction("SoilDiscriptionList");
            }
            catch (Exception ex)
            {
                ViewBag.Upozila_ID = new SelectList(db.Upozilas, "Upozila_ID", "Upozila_Name");
                ViewBag.Employee_ID = new SelectList(db.Employees, "Employee_ID", "Employee_Name");
                ViewBag.error = "Please Insert a Image";
                return View(soil_Discription);
            }
            //ViewBag.Upozila_ID = new SelectList(db.Upozilas, "Upozila_ID", "Upozila_Name");
            //ViewBag.Employee_ID = new SelectList(db.Employees, "Employee_ID", "Employee_Name");
            //return View(soil_Discription);
        }

        // SoilDiscriptionList ***
        public ActionResult SoilDiscriptionList()
        {
            return View(db.Soil_Discription.ToList());
        }
    }
}