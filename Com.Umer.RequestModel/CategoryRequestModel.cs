using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.RequestModel
{
    public class CategoryRequestModel : BaseRequestModel<Category>
    {
        public override Expression<Func<Category, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObj = x => x.Name.Contains(Keyword);
            }

            return this.ExpressionObj;

        }
    }
}
