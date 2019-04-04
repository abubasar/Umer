using Com.Umer.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Com.Umer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext context;
        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public bool Add(T entity)
        {

            DbSet<T> dbSet = this.context.Set<T>();//dbset konta chinai dilo ex
            dbSet.Add(entity);
            int i = context.SaveChanges();//how many rows will be effected

            return i > 0;
        }


        public IQueryable<T> Get()
        {
            //return this.context.Set<T>().AsQueryable();
            DbSet<T> dbSet = this.context.Set<T>();
            return dbSet.AsQueryable();
        }

        public T GetDetail(string id)
        {
            return this.context.Set<T>().Find(id);

        }



        public bool Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            int i = context.SaveChanges();//how many rows will be effected
            return i > 0;
        }

        public bool Delete(string id)
        {
            var entity = GetDetail(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                int i = context.SaveChanges();//how many rows will be effected
                return i > 0;
            }
            return true;
        }
    }
}
