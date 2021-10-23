using System;
using System.Collections.Generic;
using System.Linq;

namespace panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));
        }
        public static bool IsPangram(string str)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            string input = str.ToLower();
            foreach (char c in alpha)
            {
               foreach (char b in input)
                {
                    if (c == b)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == 26)
            {
                return true;
            }
            else return false;
        }
    }
}
