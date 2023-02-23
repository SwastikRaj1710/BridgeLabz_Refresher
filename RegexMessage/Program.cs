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

            string name = @"^[A-Za-z]+$";
            string fullname = @"^([A-Za-z]+)\s([A-Za-z]+)(\s[A-Za-z]+)*$";
            string phone = @"^91-[0-9]{10}$";
            string date = @"^([0][1-9]|[1-2][0-9]|(3)[0-1])(\/)(((0)[1-9])|((1)[0-2]))(\/)\d{4}$";
            string email = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex nameregex = new Regex(name);
            Regex fullnameregex = new Regex(fullname);
            Regex phoneregex = new Regex(phone);
            Regex dateregex = new Regex(date);
            Regex emailregex = new Regex(email);
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
            if (emailregex.IsMatch(result))
            {
                result = Regex.Replace(result, email, "swastik1710@gmail.com");
            }
            Console.WriteLine("Modified message: ");
            Console.WriteLine(result);
        }
    }
}