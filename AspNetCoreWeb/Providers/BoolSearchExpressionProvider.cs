using System;
using System.Linq.Expressions;

namespace JqueryDataTables.ServerSide.AspNetCoreWeb.Providers
{
    public class BoolSearchExpressionProvider : ComparableSearchExpressionProvider
    {
        public override ConstantExpression GetValue(string input)
        {
            if (!bool.TryParse(input, out var value))
            {
                throw new ArgumentException("Invalid search value.");
            }

            return Expression.Constant(value);
        }
    }
}
