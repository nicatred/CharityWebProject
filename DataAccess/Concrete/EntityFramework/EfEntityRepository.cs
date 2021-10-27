using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepository<TEntity,TContext>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
       public void Add(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using(TContext context= new TContext())
            {
               var deletedEntity= context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity,bool>> filter)
        {
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> filter=null)
        {
            using(TContext context = new TContext())
            {
                return await (filter == null
                    ? context.Set<TEntity>().ToListAsync()
                    : context.Set<TEntity>().Where(filter).ToListAsync());
                    
            }
        }

    }
}
