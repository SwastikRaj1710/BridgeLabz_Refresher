using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class NumbertoString
    {
        public string StringFactors(int n)
        {
            String ans = "";
            if(n%3==0)
            {
                ans += "Pling";
            }
            if(n%5==0)
            {
                ans += "Plang";
            }
            if(n%7==0)
            {
                ans += "Plong";
            }
            if(n%3!=0 && n%5!=0 && n%7!=0) 
            {
                int d=0,n1 = n;
                string str = "";
                while(n1!=0)
                {
                    d = n1 % 10;
                    str = Convert.ToString(d) + str;
                    n1 = n1 / 10;
                }
                ans = str;
            }
            return ans;
        }
    }
}
