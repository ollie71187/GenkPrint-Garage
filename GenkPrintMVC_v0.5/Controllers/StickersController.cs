using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GenkPrintMVC_v0._5.Models;
using Microsoft.AspNet.Identity;


namespace GenkPrintMVC_v0._5.Controllers
{
    public class StickersController : Controller
    {
        private genkPrintDbEntities db = new genkPrintDbEntities();
        private string userid = User.Identity.GetUserId();

        // GET: Stickers
        [Authorize]
        public ActionResult Index()
        {
            
            var stickers = db.Stickers.Include(s => s.CutMethod).Include(s => s.DeliveryMethod).Include(s => s.LaminationMethod).Include(s => s.Material).Include(s => s.PrintingMode).Include(s => s.Priority).Include(s => s.Shape);
            return View(stickers.Where(s => s.userId == userid).ToList());
        }

        // GET: Stickers/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sticker sticker = db.Stickers.Find(id);
            if (sticker == null)
            {
                return HttpNotFound();
            }
            return View(sticker);
        }

        // GET: Stickers/Create
        [Authorize]
        public ActionResult Create()
        {
            var userId = User.Identity.GetUserId();
            ViewBag.UserID = userId;
            ViewBag.cutmethod_Id = new SelectList(db.CutMethods, "cutmethod_Id", "cutmethod_name");
            ViewBag.delivery_Id = new SelectList(db.DeliveryMethods, "delivery_Id", "delivery_name");
            ViewBag.lamination_id = new SelectList(db.LaminationMethods, "lamination_id", "lamination_name");
            ViewBag.material_id = new SelectList(db.Materials, "material_id", "material_name");
            ViewBag.printing_id = new SelectList(db.PrintingModes, "printing_id", "printing_name");
            ViewBag.priority_Id = new SelectList(db.Priorities, "priority_Id", "priority_name");
            ViewBag.shape_id = new SelectList(db.Shapes, "shape_Id", "shape_name");
            return View();
        }

        // POST: Stickers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StikerId,material_id,shape_id,printing_id,cutmethod_Id,lamination_id,delivery_Id,priority_Id,IsActive,IsDelete,CreateBy,CreateDatetime,DeleteBy,DeleteDatetime,width,hight,Quantity")] Sticker sticker)
        {

            ModelState.Remove("StikerId");
            if (ModelState.IsValid)
            {
                sticker.userId = User.Identity.GetUserId();
                db.Stickers.Add(sticker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cutmethod_Id = new SelectList(db.CutMethods, "cutmethod_Id", "cutmethod_name", sticker.cutmethod_Id);
            ViewBag.delivery_Id = new SelectList(db.DeliveryMethods, "delivery_Id", "delivery_name", sticker.delivery_Id);
            ViewBag.lamination_id = new SelectList(db.LaminationMethods, "lamination_id", "lamination_name", sticker.lamination_id);
            ViewBag.material_id = new SelectList(db.Materials, "material_id", "meterial_name", sticker.material_id);
            ViewBag.printing_id = new SelectList(db.PrintingModes, "printing_id", "printing_name", sticker.printing_id);
            ViewBag.priority_Id = new SelectList(db.Priorities, "priority_Id", "priority_name", sticker.priority_Id);
            ViewBag.shape_id = new SelectList(db.Shapes, "shape_Id", "shape_name", sticker.shape_id);
            return View(sticker);
        }

        // GET: Stickers/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sticker sticker = db.Stickers.Find(id);
            if (sticker == null)
            {
                return HttpNotFound();
            }
            ViewBag.cutmethod_Id = new SelectList(db.CutMethods, "cutmethod_Id", "cutmethod_name", sticker.cutmethod_Id);
            ViewBag.delivery_Id = new SelectList(db.DeliveryMethods, "delivery_Id", "delivery_name", sticker.delivery_Id);
            ViewBag.lamination_id = new SelectList(db.LaminationMethods, "lamination_id", "lamination_name", sticker.lamination_id);
            ViewBag.material_id = new SelectList(db.Materials, "material_id", "meterial_name", sticker.material_id);
            ViewBag.printing_id = new SelectList(db.PrintingModes, "printing_id", "printing_name", sticker.printing_id);
            ViewBag.priority_Id = new SelectList(db.Priorities, "priority_Id", "priority_name", sticker.priority_Id);
            ViewBag.shape_id = new SelectList(db.Shapes, "shape_Id", "shape_name", sticker.shape_id);
            return View(sticker);
        }

        // POST: Stickers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StikerId,material_id,shape_id,printing_id,cutmethod_Id,lamination_id,delivery_Id,priority_Id,IsActive,IsDelete,CreateBy,CreateDatetime,DeleteBy,DeleteDatetime,width,hight,Quantity")] Sticker sticker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sticker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cutmethod_Id = new SelectList(db.CutMethods, "cutmethod_Id", "cutmethod_name", sticker.cutmethod_Id);
            ViewBag.delivery_Id = new SelectList(db.DeliveryMethods, "delivery_Id", "delivery_name", sticker.delivery_Id);
            ViewBag.lamination_id = new SelectList(db.LaminationMethods, "lamination_id", "lamination_name", sticker.lamination_id);
            ViewBag.material_id = new SelectList(db.Materials, "material_id", "meterial_name", sticker.material_id);
            ViewBag.printing_id = new SelectList(db.PrintingModes, "printing_id", "printing_name", sticker.printing_id);
            ViewBag.priority_Id = new SelectList(db.Priorities, "priority_Id", "priority_name", sticker.priority_Id);
            ViewBag.shape_id = new SelectList(db.Shapes, "shape_Id", "shape_name", sticker.shape_id);
            return View(sticker);
        }

        // GET: Stickers/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sticker sticker = db.Stickers.Find(id);
            if (sticker == null)
            {
                return HttpNotFound();
            }
            return View(sticker);
        }

        // POST: Stickers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sticker sticker = db.Stickers.Find(id);
            db.Stickers.Remove(sticker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
