using CLESportsBlog.Controllers;
using System;
using Xunit;

namespace CLESportsBlog.Tests
{
    public class TeamControllerTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new TeamController();

            var result = underTest.Index();

            Assert.Equal("Hello World!", result);
        }
    }
}
