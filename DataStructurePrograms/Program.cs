using System;

namespace DataStructurePrograms // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Read data from a file, perform insertion or deletion and write the data back to another file");
                Console.WriteLine("2. Check for Balanced Parenthesis");
                Console.WriteLine("3. Exit");
                
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        UnorderedList obj1 = new UnorderedList();
                        obj1.FileModification();
                        break;
                    case 2:
                        Console.WriteLine("Enter the expression");
                        string expression = Console.ReadLine();
                        char[] brackets = new char[expression.Length];
                        int k = 0;
                        for(int i=0;i<expression.Length;i++)
                        {
                            if (expression[i] == '(' || expression[i] == ')')
                            {
                                brackets[k++] = expression[i];
                            }
                        }
                        BalancedParenthesis obj2 = new BalancedParenthesis();
                        bool result = obj2.IsBalanced(brackets);
                        if(result)
                            Console.WriteLine("The given expression has Balanced Parenthesis");
                        else
                            Console.WriteLine("The given expression does not have Balanced Parenthesis");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice!");
                        break;
                }
            }
        }
    }
}