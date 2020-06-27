using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLESportsBlog.Models;
using CLESportsBlog.Repositories;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CLESportsBlog.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }
        public ViewResult Index()
        {

            var model = contentRepo.GetAll();

            return View(model);

        }

        [HttpGet]

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Content content)
        {
            if (ModelState.IsValid)
            {
                contentRepo.Create(content);
                return RedirectToAction("Index");
            }

            return View(content);
        }
    }
}
