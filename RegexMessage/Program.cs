using System;
using System.Text.RegularExpressions;

namespace RegexMessage // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string inputString = Console.ReadLine();

            string name = @"<<[a-z]+>>";
            string fullname = @"<<([a-z]+)\s([a-z]*)>>";
            string phone = @"91-x{10}";
            string date = @"X{2}/X{2}/X{4}";
            Regex nameregex = new Regex(name);
            Regex fullnameregex = new Regex(fullname);
            Regex phoneregex = new Regex(phone);
            Regex dateregex = new Regex(date);
            string result = "";
            if(nameregex.IsMatch(inputString))
            {
                result = Regex.Replace(inputString, name, "Swastik");
            }
            if (fullnameregex.IsMatch(result))
            {
                result = Regex.Replace(result, fullname, "Swastik Raj");
            }
            if (phoneregex.IsMatch(result))
            {
                result = Regex.Replace(result, phone, "91-7760484255");
            }
            if (dateregex.IsMatch(result))
            {
                result = Regex.Replace(result, date, String.Format("{0:dd/MM/yyyy}", DateTime.Now));
            }
            Console.WriteLine("Modified message: ");
            Console.WriteLine(result);
        }
    }
}