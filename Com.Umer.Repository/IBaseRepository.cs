using Com.Umer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Umer.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        bool Add(T entity);
        IQueryable<T> Get();
        T GetDetail(string id);
        bool Edit(T entity);
        bool Delete(string id);
    }
}
