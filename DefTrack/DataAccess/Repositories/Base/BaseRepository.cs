using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;

namespace DataAccess.Repositories.Base
{
    public abstract class BaseRepository<T>:IRepository<T> where T : class
    {
        private readonly DbContext _ctx;

        protected BaseRepository()
        {
            _ctx = new DefTrackEntitiesContext();
        }

        /// <summary>
        /// Gets all the records for the given Domain.
        /// As it returns IQueryable, it can be filtered further
        /// if required.
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return _ctx.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Executes the given predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _ctx.Set<T>().Where(predicate).AsQueryable();
        }

        /// <summary>
        /// Uses entity framework Find method to get the 
        /// requested entity record
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public T FindById(int entityId)
        {
            return _ctx.Set<T>().Find(entityId);
        }

        /// <summary>
        /// Adds the given entity to the DB
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
        }

        /// <summary>
        /// Deletes the given entity from the DB
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            _ctx.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Update the record in the DB
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            DbEntityEntry entry = _ctx.Entry(entity);

            if(entry != null)
            {
                switch(entry.State)
                {
                    case EntityState.Detached:
                        AttachAndMarkModified(entity);
                        break;
                    case EntityState.Deleted:
                        entry.CurrentValues.SetValues(entity);
                        entry.State = EntityState.Modified;
                        break;
                    default:
                        entry.CurrentValues.SetValues(entity);
                        break;
                }
            }
            else
            {
                AttachAndMarkModified(entity);
            }
        }

        /// <summary>
        /// This instructs EF to loop through Context object and then 
        /// generate respsective Insert, Edit and Delete statements and
        /// then save the changees
        /// </summary>
        /// <returns>Number of records changed</returns>
        public int SaveChanges()
        {
            _ctx.ChangeTracker.DetectChanges();
            return _ctx.SaveChanges(); ;
        }

        /// <summary>
        /// Helper method that attaches the Entity calss to context
        /// and sets the state as "modified" so that EF will generate
        /// SQL Update statement
        /// </summary>
        /// <param name="entity"></param>
        private void AttachAndMarkModified(T entity)
        {
            _ctx.Set<T>().Attach(entity);
            _ctx.Entry(entity).State = EntityState.Modified;
        }
    }
}
