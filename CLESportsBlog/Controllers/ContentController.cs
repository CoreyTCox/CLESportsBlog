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

        public ViewResult CreateByTeamId(int id)
        {
            ViewBag.TeamId = id;
            return View();
        }

        [HttpPost]

        public ActionResult Create(Content content)
        {
            if (ModelState.IsValid)
            {
                contentRepo.Create(content);
                return RedirectToAction("Details", "Team", new {id = content.TeamId});
            }

            return View(content);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            //ViewBag.TeamId = id;
            Content content = contentRepo.GetById(id);
            return View(content);
        }

        [HttpPost]
        public ActionResult Update(Content content)
        {
            if (ModelState.IsValid)
            {
                contentRepo.Update(content);
                return RedirectToAction("Details", "Team", new { id = content.TeamId });
            }
            return View(content);
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            Content content = contentRepo.GetById(id);
            return View(content);
        }

        [HttpPost]
        public ActionResult Delete(Content content)
        {

            if (ModelState.IsValid)
            {
                int teamId = content.TeamId;

                contentRepo.Delete(content);

                return RedirectToAction("Details", "Team", new { id = teamId });
            }

            return View(content);
        }
    }
}
