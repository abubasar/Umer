using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.RequestModel
{
    public class ProductRequestModel : BaseRequestModel<Product>
    {
        public override Expression<Func<Product, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObj = x =>
                    x.Name.Contains(Keyword) || x.Brand.Name.Contains(Keyword) || x.Category.Name.Contains(Keyword) ||
                    x.Description.Contains(Keyword) || x.Price.ToString().Contains(Keyword);
            }

            return this.ExpressionObj;
        }
    }
}
