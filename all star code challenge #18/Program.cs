using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_star_code_challenge__18
{
    public class Program
    {
        public static string str;
        public static char letter;
        
        public static int StrCount(string str, char letter)
        {
            int count = 0;
            foreach (var c in str)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count; //Do Some Magic
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me the word!: ");
            str = Console.ReadLine();
            Console.WriteLine("Please give me the letter!: ");
            //try
            //{
                letter = Convert.ToChar(Console.ReadLine());
            //}
            //catch {
            //    Console.WriteLine("Please ");
            //}
            int count = StrCount(str, letter);
            Console.WriteLine($"Amount of '{letter}' in '{str}' is '{count}'");
            Console.ReadKey();
        }
    }
}
