using CLESportsBlog.Models;
using CLESportsBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CLESportsBlog.Tests
{
    public class ContentRepositoryTests
    {
        private TeamContext db;
        private ContentRepository underTest;

        public ContentRepositoryTests()
        {
            db = new TeamContext();
            db.Database.BeginTransaction();

            underTest = new ContentRepository(db);
        }

        [Fact]
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Create_Increases_Count_of_Content()
        {
            var startCount = db.Contents.Count();

            underTest.Create(new Content()
            {
                Title = "new content",
                Author = "new Content",
                Body = "new Content",
                TeamId = 1
            });
            var endCount = db.Contents.Count();

            Assert.Equal(startCount + 1, endCount);
        }
    }
}
