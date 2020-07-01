using CLESportsBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace CLESportsBlog.Repositories
{
    public class ContentRepository : IRepository<Content>
    {
        private TeamContext db;
        public ContentRepository(TeamContext db)
        {
            this.db = db;
        }

        public IEnumerable<Content> GetAll()
        {
            return db.Contents;
        }

        public Content GetById(int id)
        {
            return db.Contents.Single(c => c.Id == id);
        }

        public void Create(Content content)
        {
            db.Contents.Add(content);
            db.SaveChanges();
        }

        public void Delete(Content content)
        {
            db.Contents.Remove(content);
            db.SaveChanges();
        }

        public void Update(Content content)
        {
            db.Contents.Update(content);
            db.SaveChanges();
        }


    }
}
