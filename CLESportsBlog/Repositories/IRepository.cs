using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLESportsBlog.Repositories
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        void Create(T obj);
        void Delete(T obj);
        void Update(T obj);
        T GetById(int id);
    }
}
