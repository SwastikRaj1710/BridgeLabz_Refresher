using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    internal class StackUtility
    {
        private int maxSize;
        private char[] stackArray;
        private int top;

        public StackUtility(int s)
        {
            maxSize = s;
            stackArray = new char[maxSize];
            top = -1;
        }

        public void push(char c)
        {
            stackArray[++top] = c;
        }

        public char pop()
        {
            return stackArray[top--];
        }

        public char peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public int size()
        {
            return top+1;
        }
    }
}
