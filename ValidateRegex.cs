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
        public static void Match()      //Q1
        {
            string pattern = "^[a]{1}[b]{2,3}$";
            string[] inputs = { "ab","abb","abbb","abbbb"};
            ValidatePattern(inputs, pattern);
        }
        public static void FindSequencewithUnderscore()     //Q2
        {
            string pattern = "^[a-z]+_[a-z]+$";
            string[] inputs = { "ashw_ini", "ashwin_i", "AS_wHini", "A_shwini" };
            ValidatePattern(inputs, pattern);
        }
            public static void ValidatePattern(string[] inputs, string pattern)
        {
            foreach(string input in inputs)
            {
                if( Regex.IsMatch(input, pattern) )
                {
                    Console.WriteLine("{0} is valid.",input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid.", input);
                }
            }
        }

        public static void ValidateHTMLTags(string inputString)     //Q3
        {
            Regex regex = new Regex(@"<[^>]+>");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void CountOccurence(string inputString)       //Q4
        {
            Regex regex = new Regex(@"fox(es)?");

            MatchCollection matches = regex.Matches(inputString);
            Console.WriteLine("The Count of given Pattern in given String " + matches.Count);

        }

        public static void FileExtension()      //Q5
        {
            Regex regex = new Regex(@"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)");

            Console.WriteLine("Enter filename with image file extension : ");
            string filename = Console.ReadLine();
            if (regex.IsMatch(filename))
            {
                Console.WriteLine("Valid file name");
            }
            else
            {
                Console.WriteLine("Invalid file name");
            }
        }

        public static void WebsiteAddress()     //Q6
        {
            Regex regex = new Regex(@"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?");
            Console.WriteLine("Enter a url ");
            string Website = Console.ReadLine();
            if (regex.IsMatch(Website))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }

        }
    }
}
