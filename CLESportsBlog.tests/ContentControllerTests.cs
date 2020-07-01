using CLESportsBlog.Controllers;
using CLESportsBlog.Models;
using CLESportsBlog.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CLESportsBlog.Tests
{
    public class ContentControllerTests
    {
        ContentController underTest;
        IRepository<Content> contentRepo;

        public ContentControllerTests()
        {
            contentRepo = Substitute.For<IRepository<Content>>();
            underTest = new ContentController(contentRepo);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Content_To_View()
        {
            // Arrange
            var expectedContent = new List<Content>();
            contentRepo.GetAll().Returns(expectedContent);

            var result = underTest.Index();

            Assert.Equal(expectedContent, result.Model);
        }

        //[Fact]
        //public void Details_Returns_A_View()
        //{
        //    var result = underTest.Details(1);

        //    Assert.IsType<ViewResult>(result);
        //}

        //[Fact]
        //public void Details_Passes_ContentModel_To_View()
        //{
        //    var expectedContent = new Content();
        //    contentRepo.GetById(1).Returns(expectedContent);

        //    var result = underTest.Details(1);

        //    Assert.Equal(expectedContent, result.Model);
        //}

        //[Fact]
        //public void Create_Returns_a_ViewResult()
        //{
        //    var result = underTest.Create();

        //    Assert.IsType<ViewResult>(result);
        //}

        [Fact]
        public void Create_Post_Returns_ActionResult()
        {
            var result = underTest.Create(new Content());

            Assert.IsAssignableFrom<ActionResult>(result);
        }

        [Fact]
        public void Create_Will_Not_Execute_if_Invalid_ModelState()
        {
            underTest.ModelState.AddModelError("Name", "Name is required");
            var newCourse = new Content();

            underTest.Create(newCourse);

            contentRepo.DidNotReceive().Create(newCourse);
        }

        [Fact]
        public void Create_Will_Add_Course_if_Valid_ModelState()
        {
            var newCourse = new Content();

            underTest.Create(newCourse);

            contentRepo.Received().Create(newCourse);

        }
    }
}