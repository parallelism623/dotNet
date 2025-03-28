using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree
{
    public static class InterpretExpressions
    {
        public static void InterpretBinaryExpressionsExample()
        {
            Expression<Func<int, bool>> exprTree = num => num < 5;

            // Decompose the expression tree.
            ParameterExpression param = (ParameterExpression)exprTree.Parameters[0];
            BinaryExpression operation = (BinaryExpression)exprTree.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            Console.WriteLine($"Decomposed expression: {param.Name} => {left.Name} {operation.NodeType} {right.Value}");
        }
        public static void InterpretExpressionTreeByVisitor()
        {
            Expression<Func<int, int>> sum = (a) => 1 + a + 3 + 4;
            var lambdaExpressionVisitor = new LambdaVisitor(sum);
            lambdaExpressionVisitor.Visit("Test\t");
        }
    }

    /*
     * Every node in an expression tree is an object of a class is derived from Expression
     * So visiting all the nodes in the expression tree is a  relatively straightforward recursive operation 
     */
}
