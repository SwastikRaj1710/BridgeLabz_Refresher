using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace FileHandling
{
    internal class CSV
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

            string csvPath = "D:\\BridgeLabz\\BridgeLabz_Refresher\\File1.csv";
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteField("First Name");
                    csvWriter.WriteField("Last Name");
                    csvWriter.WriteField("Address");
                    csvWriter.WriteField("Phone Number");
                    csvWriter.WriteField("Email ID");
                    csvWriter.NextRecord();

                    csvWriter.WriteField(fname);
                    csvWriter.WriteField(lname);
                    csvWriter.WriteField(address);
                    csvWriter.WriteField(phone);
                    csvWriter.WriteField(email);
                    csvWriter.NextRecord();
                }
            }

            using var streamReader = File.OpenText("D:\\BridgeLabz\\BridgeLabz_Refresher\\File1.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            string record;

            while(csvReader.Read())
            {
                for(int i=0;csvReader.TryGetField<string>(i, out record);i++)
                {
                    Console.Write($"{record} ");
                }
                Console.WriteLine();
            }
        }
    }
}
