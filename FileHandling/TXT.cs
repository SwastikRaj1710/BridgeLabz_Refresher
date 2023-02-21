using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class TXT
    {
        public void ReadWriteOps()
        {
            Console.WriteLine("Enter the Employee details");
            Console.WriteLine("Enter the First name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the Last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the Phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the Email id");
            string email = Console.ReadLine();

            Console.WriteLine("\nWriting the details to the file...");

            StreamWriter sw = new StreamWriter("D:\\BridgeLabz\\BridgeLabz_Refresher\\File1.txt");
            sw.WriteLine("First Name: " + fname);
            sw.WriteLine("Last Name: " + lname);
            sw.WriteLine("Address: " + address);
            sw.WriteLine("Phone Number: " + phone);
            sw.WriteLine("Email ID: " + email);
            sw.Close();

            Console.WriteLine("\nReading the details from the file...");

            StreamReader sr = new StreamReader("D:\\BridgeLabz\\BridgeLabz_Refresher\\File1.txt");
            string line = sr.ReadLine();
            while(line!=null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
