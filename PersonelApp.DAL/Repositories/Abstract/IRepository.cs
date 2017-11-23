using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);
            
        void AddRange(IEnumerable<TEntity> entity);

        void Remove(int id);

        void RemoveRange(IEnumerable<TEntity> entity);
    }
}
