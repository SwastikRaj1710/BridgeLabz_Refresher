using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{

    internal class BalancedParenthesis
    {
        public bool IsBalanced(char[] expression)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                    stack.Push(expression[i]);

                if (expression[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }
            if (stack.Count == 0)
                return true;
            else
            {
                return false;
            }
        }
    }
}