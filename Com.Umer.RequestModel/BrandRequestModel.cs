using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.RequestModel
{
    public class BrandRequestModel : BaseRequestModel<Brand>
    {
        public override Expression<Func<Brand, bool>> GetExpression()
        {
            if (!string.IsNullOrEmpty(Keyword))
            {
                this.ExpressionObj = x => x.Name.Contains(Keyword);
            }

            return this.ExpressionObj;
        }
    }
}
