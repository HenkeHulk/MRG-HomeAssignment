using MRG_HomeAssignment.WebUI.Helper;
using MRG_HomeAssignment.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRG_HomeAssignment.WebUI.Controllers
{
    public class HomeController : Controller
    {
        MrgreenHelper mrg = new MrgreenHelper();
        RedbetHelper red = new RedbetHelper();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register(int? red)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(MrgreenCustomerViewModel model)
        {
            int id = mrg.Register(model);
            return RedirectToAction("Edit", "Home", new { id = id });
        }

        [HttpGet]
        public ActionResult RedRegister()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult RedRegister(RedbetCustomerViewModel model)
        {
            int id = red.Register(model);
            return RedirectToAction("RedEdit","Home", new { id = id });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(mrg.FindById(id));
        }

        [HttpPost]
        public ActionResult Edit(MrgreenCustomerViewModel model)
        {
            mrg.Register(model);
            return RedirectToAction("AllMrgCustomers", "Home");
        }

        [HttpGet]
        public ActionResult RedEdit(int id)
        {
            return View(red.FindById(id));
        }

        [HttpPost]
        public ActionResult RedEdit(RedbetCustomerViewModel model)
        {
            red.Register(model);
            return RedirectToAction("AllRedBetCustomers", "Home");
        }

        public ActionResult AllMrgCustomers()
        {
            return View(mrg.mrgreenCustomers());
        }

        public ActionResult AllRedBetCustomers()
        {
            return View(red.redbetCustomers());
        }

        public ActionResult Delete(int id)
        {
            mrg.Delete(id);
            return RedirectToAction("AllMrgCustomers", "Home");
        }

        public ActionResult RedDelete(int id)
        {
            red.Delete(id);
            return RedirectToAction("AllRedBetCustomers", "Home");
        }
    }
}