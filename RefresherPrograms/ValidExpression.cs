using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class ValidExpression
    {
        public int check(string exp)
        {
            String pattern = "[0-9]{1,}[+,-,/,*]{1}[0-9]{1,}";
            Regex regex= new Regex(pattern);
            if (regex.IsMatch(exp))
            {
                DataTable data = new DataTable();
                return Convert.ToInt32(data.Compute(exp, ""));
            }
            else
            {
                return -999;
            }
        }
    }
}
