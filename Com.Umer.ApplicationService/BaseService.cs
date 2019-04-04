using Com.Umer.DataModel;
using Com.Umer.Repository;
using Com.Umer.RequestModel;
using Com.Umer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Com.Umer.ApplicationService
{
    public class BaseService<T, Tr, Tv> : IBaseService<T, Tr, Tv> where T : BaseEntity where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>
    {

        private readonly IBaseRepository<T> repository;
        public BaseService(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }


        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            IQueryable<T> queryable = repository.Get();
            queryable = request.IncludeParents(queryable);
            var expression = request.GetExpression();
            queryable = queryable.Where(expression);
            queryable = request.OrderByFunc()(queryable);
            queryable = request.SkipAndTake(queryable);
            queryable = request.IncludeParents(queryable);

            return queryable;
        }





        public bool Add(T model)
        {

            return repository.Add(model);
        }

        public bool Edit(T model)
        {

            return repository.Edit(model);
        }

        public T GetById(string id)
        {

            return repository.GetDetail(id);
        }





        public bool Delete(string id)
        {

            return repository.Delete(id);
        }

        public Tv Detail(string id)
        {
            T x = repository.GetDetail(id);

            if (x == null)
            //id vul disos can
            {
                throw new Exception();
            }

            var vm = CreateVmInstance(x);

            return vm;
        }

        public List<Tv> Search(Tr request)
        {

            var queryable = SearchQueryable(request);

            var list = queryable.ToList().ConvertAll(CreateVmInstance);    //hit to database  and execute the query

            return list;
        }

        private static Tv CreateVmInstance(T x)
        {
            return (Tv)Activator.CreateInstance(typeof(Tv), x);
        }

        public string GetReferanceId()
        {
            var referenceNo = "";
            var queryable = repository.Get();
            var list = queryable.ToList();
            int count = list.Count();
            while (true)
            {
                count++;
                referenceNo = "SL:" + count.ToString().PadLeft(6, '0');
                return referenceNo;
            }

        }


    }
}