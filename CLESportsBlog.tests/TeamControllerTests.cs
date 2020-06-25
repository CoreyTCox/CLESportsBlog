using CLESportsBlog.Controllers;
using CLESportsBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace CLESportsBlog.Tests
{
    public class TeamControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new TeamController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_TeamModel_To_View()
        {
            var controller = new TeamController();

            var result = controller.Index();

            Assert.IsType<Team>(result.Model);
        }

        [Fact]
        public void Index_Sets_Name_On_Model()
        {
            var expectedName = "examplestring";
            var controller = new TeamController();

            var result = controller.Index();
            var model = (Team)result.Model;

            Assert.Equal(expectedName, model.Name);
        }
    }
}
