using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ex1_20190819_viewmodel.Models;

namespace ex1_20190819_viewmodel.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel orderViewModel)
        {
            return View(orderViewModel);
        }

    }
}