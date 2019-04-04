using Com.Umer.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Umer.ViewModel
{
    public class BaseViewModel<T> where T : BaseEntity
    {
        public BaseViewModel(BaseEntity entity)
        {
            Id = entity.Id;
            CreatedBy = entity.CreatedBy;
            Created = entity.Created;
            Updated = entity.Updated;
            UpdatedBy = entity.UpdatedBy;

        }

        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string UpdatedBy { get; set; }
        public string Updated { get; set; }
    }
}
