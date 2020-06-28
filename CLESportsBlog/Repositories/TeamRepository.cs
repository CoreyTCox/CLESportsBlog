using CLESportsBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLESportsBlog.Repositories
{
    public class TeamRepository : IRepository<Team>
    {
        private TeamContext db;
        public TeamRepository(TeamContext db)
        {
            this.db = db;
        }

        public IEnumerable<Team> GetAll()
        {
            return db.Teams;
        }

        public Team GetById(int id)
        {
            return db.Teams.Single(c => c.Id == id);
        }

        //public int Count()
        //{
        //    return db.Contents.Count();
        //}

        public void Create(Team team)
        {
            throw new NotImplementedException();
        }

        public void Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public void Update(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
