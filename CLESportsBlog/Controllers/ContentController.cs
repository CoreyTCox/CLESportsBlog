using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLESportsBlog.Models;
using CLESportsBlog.Repositories;

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

        public ViewResult Index(int teamId)
        {
            var model = contentRepo.GetById(teamId);

            return View(model);
        }
    }
}
