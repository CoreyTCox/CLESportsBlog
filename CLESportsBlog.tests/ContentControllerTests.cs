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

        [Fact]
        public void CreateByTeamId_Returns_a_ViewResult()
        {
            
            var result = underTest.CreateByTeamId(1);

            Assert.IsType<ViewResult>(result);
        }

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
            var newContent = new Content();

            underTest.Create(newContent);

            contentRepo.Received().Create(newContent);

        }

        [Fact]
        public void Update_Edits_Content()
        {
            var content = new Content() { Title = "New Post" };
            underTest.Create(content);

            underTest.Update(content);

            contentRepo.Received().Update(content);
        }

        [Fact]
        public void Delete_Removes_Content()
        {
            var content = new Content() { Title = "New Post" };
            underTest.Create(content);

            underTest.Delete(content);

            contentRepo.Received().Delete(content);
        }

    }
}