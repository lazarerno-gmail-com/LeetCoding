using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding.Infrastructure
{
    internal class Helpers
    {
        public static void Dump(string message, int[] collection)
        {
            Console.WriteLine();
            Console.Write(message);
            if (collection == null || collection.Length == 0)
                Console.Write("<no values>");
            else
                for (int i = 0; i < collection.Length; i++)
                {
                    if (i > 0)
                        Console.Write(", ");
                    Console.Write(collection[i]);
                }
        }

        public static void Dump(string message, bool value)
        {
            Console.WriteLine();
            Console.Write(message);
            Console.Write(value);
        }

        public static void Dump(string message, int? value)
        {
            Console.WriteLine();
            Console.Write(message);
            Console.Write(value == null ? "<NULL>" : value);
        }
    }
}
