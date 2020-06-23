using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
    }
}
