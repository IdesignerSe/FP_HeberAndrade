using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InNutrition.Controllers
{
    public class ReturnTypeController : Controller
    {
        // GET: ReturnTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReturnTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReturnTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReturnTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReturnTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReturnTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReturnTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReturnTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
