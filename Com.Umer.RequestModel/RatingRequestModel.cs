using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.RequestModel
{
    public class RatingRequestModel : BaseRequestModel<Rating>
    {
        public override Expression<Func<Rating, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObj = x => x.Product.Name.Contains(Keyword);
            }

            return this.ExpressionObj;
        }
    }
}
