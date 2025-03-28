

namespace ExpressionTree
{
    public static class CreateExpressionTree
    {
        public static BinaryExpression CreateExpressionBinaryTreeExample()
        {
            var one = Expression.Constant(1, typeof(int));
            var two = Expression.Constant(2, typeof(int));
            return Expression.Add(one, two);
        }
    }
}
