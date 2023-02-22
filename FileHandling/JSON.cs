using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FileHandling
{
    internal class JSON
    {
        public void ReadWriteOps()
        {
            Console.WriteLine("Enter the Employee details");
            Console.WriteLine("Enter the First name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the Last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            string add = Console.ReadLine();
            Console.WriteLine("Enter the Phone number");
            string ph = Console.ReadLine();
            Console.WriteLine("Enter the Email id");
            string email = Console.ReadLine();

            Employee emp = new Employee()
            {
                firstName = fname,
                lastName = lname,
                address = add,
                phone = ph,
                emailid = email
            };

            string ResultJson = JsonConvert.SerializeObject(emp);
            Console.WriteLine("\nWriting the details to the file...");
            string jsonPath = "D:\\BridgeLabz\\BridgeLabz_Refresher\\File1.json";
            File.WriteAllText(jsonPath, ResultJson);

            string ResultString = File.ReadAllText(jsonPath);
            Employee Result = JsonConvert.DeserializeObject<Employee>(ResultString);
            Console.WriteLine(Result.ToString());
        }
    }
}
