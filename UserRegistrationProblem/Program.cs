using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public bool CheckFirstName(string fname)
        {
            string firstname = @"^[A-Z][a-z]{2,}$";
            Regex firstnameregex = new Regex(firstname);
            if (firstnameregex.IsMatch(fname))
            {
                return true;
            }
            return false;
        }

        public bool CheckLastName(string lname)
        {
            string lastname = @"^[A-Z][a-z]{2,}$";
            Regex lastnameregex = new Regex(lastname);
            if (lastnameregex.IsMatch(lname))
            {
                return true;
            }
            return false;
        }

        public bool CheckEmail(string emailid)
        {
            string email = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex emailregex = new Regex(email);
            if (emailregex.IsMatch(emailid))
            {
                return true;
            }
            return false;
        }

        public bool CheckPhoneNumber(string phoneno)
        {
            string phone = @"^[0-9]{1,3}\s[0-9]{10}$";
            Regex phoneregex = new Regex(phone);
            if (phoneregex.IsMatch(phoneno))
            {
                return true;
            }
            return false;
        }

        public bool CheckPassword(string pass)
        {
            string password = @"^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%^&*]*[!@#$%^&*][^!@#$%^&*]*$)([A-Za-z0-9!@#$%^&*]{8,20})$";
            Regex passwordregex = new Regex(password);
            if (passwordregex.IsMatch(pass))
            {
                return true;
            }
            return false;
        }
    }
}