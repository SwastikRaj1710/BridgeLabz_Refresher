using System;

namespace NextDate // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.Write("Input a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a month(1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a day:(1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day < 1 || day > 31)
            {
                flag = false;
            }
            if (month < 1 || month > 12)
            {
                flag = false;
            }
            else if (Check(day, month))
            {
                flag = false;
            }

            if (month == 2)
            {
                if (IsLeapYear(year) && day > 29)
                {
                    flag = false;
                }
                else if (!IsLeapYear(year) && day > 28)
                {
                    flag = false;
                }
            }

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (day < 31)
                        day++;
                    else
                    {
                        day=1;
                        month++;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 30)
                        day++;
                    else
                    {
                        day=1;
                        month++;
                    }
                    break;
                case 12:
                    if (day < 31)
                        day++;
                    else
                    {
                        day=1;
                        month=1;
                        year++;
                    }
                    break;
                case 2:
                    if (day < 28)
                        day++;
                    else if (IsLeapYear(year) && day == 28)
                        day++;
                    else if (day == 28 || day == 29)
                    {
                        day = 1;
                        month = 3;
                    }
                    break;
            }
            if (flag == true)
            {
                Console.Write($"The next date is (yyyy-mm-dd): {year}-{month}-{day}");
            }
            else
            {
                Console.WriteLine("Please enter a valid date");
            }

        }

        static bool Check(int day, int month)
        {
            if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 31)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
