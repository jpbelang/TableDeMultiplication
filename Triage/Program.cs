using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl.Runtime;

namespace Triage
{
    class LengthSort : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length - y.Length;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            List<string> words = new List<string>();
            foreach (var arg in args)
            {
                words.Add(arg);
            }

            words.Sort();
            words.ForEach(Console.WriteLine);
            Console.WriteLine("--------");
            words.Sort(( x, y) => { return x.Length - y.Length; });
            words.ForEach(Console.WriteLine);
        }
    }
}