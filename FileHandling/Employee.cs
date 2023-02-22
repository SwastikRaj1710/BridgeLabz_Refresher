namespace FileHandling
{
    class Employee
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string emailid { get; set; }

        public override string ToString()
        {
            return string.Format("Employee Details: \nFirstName: {0}\nLastName: {1}\nAddress: {2}\nPhoneNumber: {3}\nEmailID: {4}\n", firstName, lastName, address, phone, emailid);  
        }

    }
}
