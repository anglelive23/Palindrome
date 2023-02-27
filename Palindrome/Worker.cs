using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }
        public void Work()
        {
            Console.Write("Number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not Palindrome");
        }
        public bool IsPalindrome(int number)
        {
            string numberToString = number.ToString();
            string numberReversed = string.Join("", numberToString.Reverse<char>().ToArray());
            return (numberReversed.Equals(numberToString) ? true : false);
        }
    }
}
