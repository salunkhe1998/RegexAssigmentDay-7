using RegexPattern;
namespace RegexPattern
{
   public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Pattern Problem!");
            Console.WriteLine("Enter your Choice from below:-");
            Console.WriteLine("1.Regex pattern for a followed by 2 or 3 b.\n2.Regex pattern to find sequences of lowercase letters joined by an underscore." +
                "\n3.Regex pattern for extracting HTML tags.\n4.Regex pattern to count number of occurence of pattern." +
                "\n5.Regex pattern to find valid file names with an image file type extension.\n6.Regular expression to validate a website address format.");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ValidateRegex.Match();
                    break;
                case 2:
                    ValidateRegex.FindSequencewithUnderscore();
                    break;
                case 3:
                    ValidateRegex.ValidateHTMLTags("<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>");
                    break;
               case 4:
                    ValidateRegex.CountOccurence("foxes are omnivorous mammals belonging to several genera of the family Canidae fox ");
                    break;
               case 5:
                    ValidateRegex.FileExtension();
                    break;
                case 6:
                    ValidateRegex.WebsiteAddress();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
    }
}
