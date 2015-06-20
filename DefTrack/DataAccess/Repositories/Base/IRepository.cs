using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Base
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        T FindById(int entityId);

        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        int SaveChanges();
    }
}
