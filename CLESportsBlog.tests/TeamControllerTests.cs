using CLESportsBlog.Controllers;
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
    }
}
