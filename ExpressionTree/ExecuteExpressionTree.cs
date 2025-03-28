using ExpressionTree.Models;

namespace ExpressionTree
{
    public static class ExecuteExpressionTree
    {
        public static void ExecuteLambdaExpression()
        {
            // Only lambda expression can convert to into executable IL instructions.
            // Call Compile to create executable delegate, and then invoke the delegate
            LambdaExpression lambda = Expression.Lambda(Expression.Add(Expression.Constant(1), Expression.Constant(2)));

            // Compile
            Delegate executableDelegateOfLambdaExpression = lambda.Compile();

            // Invoke
            // Use invoke when we should know what type of Expression, 
            // Another we should use DynamicInvoke to pass any params into invoke function.
            executableDelegateOfLambdaExpression.DynamicInvoke();
        }
        public static void ExecuteLambdaExpressionWithClosure()
        {
            // Expression Lambda create closure over any local variables that  are referenced in the expression
            // So, if local variable was disposed before the delegate that represents for the expression tree is invoked.
            // Error will be throwed.
            var func = CreateBoundResource();
            func(1); 
        }
        private static Func<int, int> CreateBoundResource()
        {
            using (var constant = new Resource()) 
            {
                Expression<Func<int, int>> expression = (b) => constant.Argument + b;
                var rVal = expression.Compile();
                return rVal;
            }
        }
    }
}
