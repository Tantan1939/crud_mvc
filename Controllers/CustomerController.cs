using CRUD_OperationsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsInMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (MvcCrudEntities dbModel = new MvcCrudEntities())
            {
                return View(dbModel.Table_1.ToList());
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (MvcCrudEntities dbModel = new MvcCrudEntities())
            {
                return View(dbModel.Table_1.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Table_1 customer)
        {
            try
            {
                // TODO: Add insert logic here

                using (MvcCrudEntities dbModel = new MvcCrudEntities())
                {
                    dbModel.Table_1.Add(customer);
                    dbModel.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (MvcCrudEntities dbModel = new MvcCrudEntities())
            {
                return View(dbModel.Table_1.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Table_1 customer)
        {
            try
            {
                // TODO: Add update logic here
                using(MvcCrudEntities dbModel = new MvcCrudEntities())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (MvcCrudEntities dbModel = new MvcCrudEntities())
            {
                return View(dbModel.Table_1.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                using (MvcCrudEntities dbModel = new MvcCrudEntities())
                {
                    Table_1 customer = dbModel.Table_1.Where(x => x.Id == id).FirstOrDefault();
                    dbModel.Table_1.Remove(customer);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
