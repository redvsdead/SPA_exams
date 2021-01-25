using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPA_exams.Models;

namespace SPA_exams.Controllers
{
    public class HomeController : Controller
    {
        ExamRepo repository = ExamRepo.Current;
        public ViewResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Add(ExamResult item)
        {
            if (ModelState.IsValid)
            {
                repository.Add(item);
                return RedirectToAction("Index");
            }
            else return View("Index");
        }

        public ActionResult Update(ExamResult item)
        {
            if (ModelState.IsValid && repository.Update(item))
                return RedirectToAction("Index");
            else return View("Index");
        }
    }
}
