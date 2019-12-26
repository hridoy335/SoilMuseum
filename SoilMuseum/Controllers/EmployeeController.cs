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
    public class EmployeeController : Controller
    {
        Models.SoilMuseumEntities1 db = new SoilMuseumEntities1();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // Employee Registration action
        [HttpGet]
        public ActionResult EmployeeRegistration()
        {
            ViewBag.Emp_Designation = new SelectList(db.Employee_Designation, "Employee_DID", "Designation_Name");
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeRegistration([Bind(Include = "Employee_ID,Employee_Name,Employee_Email,Username,Password,User_type,User_Active")] Employee employee, int? Emp_Designation)
        {
            if (Emp_Designation ==null)
            {
                ViewBag.Emp_Designation = new SelectList(db.Employee_Designation, "Employee_DID", "Designation_Name");
                ViewBag.Emp_de_Meaasge = "Select Designation";
                return View(employee);
            }
            bool userstatus = employee.User_Active;
            if (userstatus == false)
                employee.User_Active = false;
            else
                employee.User_Active = true;
           // int i = Emp_Designation;
            if (ModelState.IsValid)
            {
                employee.User_type = Convert.ToInt32( Emp_Designation);
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("EmployeeList");
            }
            ViewBag.Emp_Designation = new SelectList(db.Employee_Designation, "Employee_DID", "Designation_Name");
            return View(employee);
        }

        // Employee list action
        public ActionResult EmployeeList()
        {
            return View(db.Employees.ToList());
        }

        //Employee information update
        public ActionResult EployeeInfoUpddate(int?id)
        {
            ViewBag.Designation = new SelectList(db.Employee_Designation, "Employee_DID", "Designation_Name");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee de = db.Employees.Find(id);
            if (de == null)
            {
                return HttpNotFound();
            }
            return View(de);
            
        }

        //Designation action
        [HttpGet]
        public ActionResult DesignationAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DesignationAdd([Bind(Include = "Employee_DID,Designation_Name")] Employee_Designation employee_Designation)
        {

            var name = db.Employee_Designation.Where(x => x.Designation_Name == employee_Designation.Designation_Name);
            if(name== null)
            {
                if (ModelState.IsValid)
                {
                    db.Employee_Designation.Add(employee_Designation);
                    db.SaveChanges();
                    return RedirectToAction("Designation_List");

                }
                return View(employee_Designation);
            }
            ViewBag.demeaage = "This name already here.";
            return View(employee_Designation);
                
        }

        

        //Designation List
        public ActionResult Designation_List()
        {
            return View(db.Employee_Designation.ToList());
        }

        // Designation Update
        [HttpGet]
        public ActionResult Designation_Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Designation de = db.Employee_Designation.Find(id);
            if (de == null)
            {
                return HttpNotFound();
            }
            return View(de);
        }
            
        [HttpPost]
        public ActionResult Designation_Update([Bind(Include = "Employee_DID,Designation_Name")] Employee_Designation employee_Designation)
        {
            var name = db.Employee_Designation.Where(x => x.Designation_Name == employee_Designation.Designation_Name);
            if (name == null)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(employee_Designation).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Designation_List");
                }
                return View(employee_Designation);
            }

            ViewBag.DesignationUpdate = "This name already here.";
            return View(employee_Designation);
        }
    }
}