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
            bool validWord = false;
            Console.WriteLine("Please give me the word!: ");
            str = Console.ReadLine();
            bool validChar = false;
            while (!validChar)
            {
                Console.WriteLine("Enter a character: ");
                string input = Console.ReadLine();
                if (input.Length==1 && Char.IsLetter(input[0])) { 
                    letter = input[0];
                    validChar = true;   
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter single letter.");
                }
            }
            int count = StrCount(str, letter);
            Console.WriteLine($"Amount of '{letter}' in '{str}' is '{count}'");
            Console.ReadKey();
        }
    }
}
