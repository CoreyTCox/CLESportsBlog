using Microsoft.AspNetCore.Mvc;
using CLESportsBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLESportsBlog.Controllers
{
    public class TeamController : Controller
    {
        public ViewResult Index()
        {
            var model = new Team();
            //model.name = name;
            return View(model);
        }
    }
}
