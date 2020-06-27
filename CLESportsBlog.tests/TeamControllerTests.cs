using CLESportsBlog.Controllers;
using CLESportsBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using NSubstitute;
using CLESportsBlog.Repositories;

namespace CLESportsBlog.Tests
{
    public class TeamControllerTests
    {
        TeamController underTest;
        IRepository<Team> mockTeamRepo;

        public TeamControllerTests()
        {
            mockTeamRepo = Substitute.For<IRepository<Team>>();
            underTest = new TeamController(mockTeamRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {            
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_TeamModel_To_View()
        {            

            var result = underTest.Index();

            Assert.IsType<Team>(result.Model);
        }
    }
}
