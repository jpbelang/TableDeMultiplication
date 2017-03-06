using System;
using System.Collections.Generic;
using System.Globalization;

namespace ReadStdin
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args[0] == "--longest-first")
            {

                string longestLine = LongestLine();
                Console.WriteLine(longestLine);
                return;
            }

            if (args[0] == "--longest-all")
            {

            }

            if (args[0] == "--longest-word")
            {

            }

            if (args[0] == "--line-with-longest-word")
            {

            }

            if (args[0] == "--line-with-most-words")
            {

            }

            if (args[0] == "--ten-most-used-words")
            {

            }
        }

        private static string LongestLine()
        {
            string line;
            string longest = "";
            while ((line = Console.ReadLine()) != null)
            {
                if (line.Length > longest.Length)
                {
                    longest = line;
                }
            }
            return longest;
        }
    }
}