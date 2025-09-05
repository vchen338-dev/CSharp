using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-20): ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NumberToWord(num));
        }

        static string NumberToWord(int number)
        {
            string[] words =
            {
            "ZERO", "ONE", "TWO", "THREE", "FOUR",
            "FIVE", "SIX", "SEVEN", "EIGHT", "NINE",
            "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN",
            "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN",
            "TWENTY"
        };

            if (number >= 0 && number <= 20)
                return words[number];

            return "!";
        }
    }
}
