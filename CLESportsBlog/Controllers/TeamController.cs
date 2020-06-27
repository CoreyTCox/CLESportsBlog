using Microsoft.AspNetCore.Mvc;
using CLESportsBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLESportsBlog.Repositories;

namespace CLESportsBlog.Controllers
{
    public class TeamController : Controller
    {
        IRepository<Team> teamRepo;

        public TeamController(IRepository<Team> teamRepo)
        {
            this.teamRepo = teamRepo;
        }
        public ViewResult Index()
        {
            var model = teamRepo.GetAll();            
            return View(model);
        }
    }
}
