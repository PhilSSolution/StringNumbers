using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumbers
{
    public class Calculator
    {
        public static int Add(string input)
        {
            
            var sum = 0;
            string[] delimiters;

            if (input == "") return 0;

            delimiters = Delimiters(ref input);

            var listofnumbers = input.Split(delimiters, StringSplitOptions.None);
            foreach (var number in listofnumbers)
            {
                try
                {
                   
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                sum += Convert.ToInt32(number);
            }
            return sum;
        }

        private static string[] Delimiters(ref string input)
        {
            string[] delimiters;
            if (input.StartsWith("//"))
            {
                delimiters = new string[] {input.Substring(2, 1)};
                input = input.Substring(3);
            }
            else
            {
                delimiters = new string[] {",", "\n"};
            }
            return delimiters;
        }
    }
}
