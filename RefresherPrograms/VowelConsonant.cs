using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class VowelConsonant
    {
        public void IsVowelConsonant(char ch)
        {
            if (char.IsLetter(ch))
            {
                char ch1 = char.ToUpper(ch);
                if (ch1 == 'A' || ch1 == 'E' || ch1 == 'I' || ch1 == 'O' || ch1 == 'U')
                    Console.WriteLine("The entered alphabet " + ch + " is a Vowel");
                else
                    Console.WriteLine("The entered alphabet " + ch + " is a Consonant");
            }
            else
                Console.WriteLine("The entered character " + ch + " is not an Alphabet");
        }
    }
}
