using Examination3.Context;
using Examination3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Examination3.Controllers
{
    public class ExamController : Controller
    {
        private ExamContext db = new ExamContext();
        // GET: Exam
        public ActionResult Index()
        {
            return View(db.Exams.ToList());
        }

        // GET: Exam/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Exam exam = db.Exams.Find(id);
            if (exam == null)
                return HttpNotFound();
            return View(exam);
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(Exam exam)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    db.Exams.Add(exam);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(exam);
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
