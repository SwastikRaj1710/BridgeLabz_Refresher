using System;

namespace PartsOfName // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordCount = 1;
            string name = "";
            Console.WriteLine("Enter your name");
            Console.WriteLine("Enter the firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the middlename (Enter NA if middle name does not exist):");
            string middlename = Console.ReadLine();
            Console.WriteLine("Enter the lastname:");
            string lastname = Console.ReadLine();

            if(middlename=="NA" || middlename=="na" || middlename=="Na")
            {
                name = firstname + " " + lastname;
            }
            else
            {
                name = firstname + " " + middlename + " " + lastname;
            }
            
            for (int i=0;i<name.Length;i++) 
            {
                if (name[i] == ' ' || name[i] == '\n' || name[i] == '\t')
                {
                    wordCount++;
                }
            }

            Console.WriteLine("Number of parts of name: " + wordCount);
            Console.WriteLine("Name: " + name);
        }
    }
}