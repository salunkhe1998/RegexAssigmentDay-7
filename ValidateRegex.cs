using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class ValidateRegex
    {
        public static void Match()
        {
            string pattern = "^[a]{1}[b]{2,3}$";
            string[] inputs = { "ab", "abb", "abbb", "abbbb" };
            ValidatePattern(inputs, pattern);
        }

        public static void ValidatePattern(string[] inputs, string pattern)
        {
            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid.", input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid.", input);
                }
            }
        }
    }
}