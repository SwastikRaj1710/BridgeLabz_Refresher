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
            StackUtility stack = new StackUtility(expression.Length);
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                    stack.push(expression[i]);

                if (expression[i] == ')')
                {
                    if (stack.size() == 0)
                    {
                        return false;
                    }

                    stack.pop();
                }
            }
            if (stack.size() == 0)
                return true;
            else
            {
                return false;
            }
        }
    }
}