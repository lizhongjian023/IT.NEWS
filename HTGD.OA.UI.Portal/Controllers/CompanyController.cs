using HTGD.OA.BLL;
using HTGD.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTGD.OA.UI.Portal.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company

        CompanyService companyService = new CompanyService();

        public ActionResult Index()
        {
            ViewData.Model = companyService.GetEntities(u=>true);
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                 companyService.Add(company);
            }
            return View("Index");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Delete(company);
            }
               
            return View("Index");
        }


        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Update(company);
            }

            return View("Index");
        }

  

    }
}