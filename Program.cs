using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns
{
    class Program
    {
        public class Journal
        {
            private readonly List<string> entries = new List<string>();

            private static int count = 0;

            public int AddEntry (string text)
            {
                entries.Add($"{++count} : {text}");
                return count;           //memento pattern
            }


        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
