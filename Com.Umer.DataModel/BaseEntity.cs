using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Umer.DataModel
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string UpdatedBy { get; set; }
        public string Updated { get; set; }
    }

}
