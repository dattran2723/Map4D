﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Map4D.Models;

namespace Map4D.Areas.Admin.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Customers
        public async Task<ActionResult> Index()
        {
            return View();
        }

        // GET: Admin/Customers/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customers = await db.Customers.FindAsync(id);
            if (customers == null)
            {
                return HttpNotFound();
            }
            return View(customers);
        }

        // GET: Admin/Customers/Edit/5
        /// <summary>
        /// using automapper
        /// create var session["phone"] using check isExitPhone for view edit customer
        /// </summary>
        /// <param name="id">get id form id customer</param>
        /// <returns></returns>
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customers = await db.Customers.FindAsync(id);
            var result = AutoMapper.Mapper.Map<CustomerEditViewModels>(customers);
            Session["phone"] = result.Phone;
            if (customers == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: Admin/Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CustomerEditViewModels model)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(customers).State = EntityState.Modified;
                Customer customer = db.Customers.Find(model.ID);
                AutoMapper.Mapper.Map(model, customer);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public JsonResult Delete(string id)
        {
            Customer customers = db.Customers.Find(id);
            if (customers != null)
            {
                db.Customers.Remove(customers);
                db.SaveChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// true : no check is exist phone input
        /// fasle : check is exist for phone input
        /// check ssphone with session["phone"]
        /// if 2 value == then return true
        /// count value phone from db with phone input
        /// if value > 0 then return fasle
        /// else then return true
        /// </summary>
        /// <param name="phone">is value input when want to edit phone for customer</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult IsPhoneExist(string phone)
        {
            var ssphone = Session["phone"];
            if (ssphone.Equals(phone))
            {
                return Json(true);
            }
            var isExist = db.Customers.Count(x => x.Phone == phone);
            if (isExist > 0)
                return Json(false);
            return Json(true);
        }
    }
}