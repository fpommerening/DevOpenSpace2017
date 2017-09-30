using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class Program
    {
            private static string[] GetConsoleInput() {
            var buffer = new  List<string>();
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                buffer.Add(s);
            }
            return buffer.ToArray();
        }

        static void Main(string[] args)
        {
              var buffer = GetConsoleInput();
            Console.WriteLine(string.Join(Environment.NewLine, buffer));
        }
    }
}
