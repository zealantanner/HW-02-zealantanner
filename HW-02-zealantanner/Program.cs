using System;

namespace CS1405_Lab
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hi");

            string a = "";
            string b = null;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("\"\" {0} \"\"", a == "" ? "equals": "does not equal");
            Console.WriteLine("\"\" {0} null", a == null ? "equals": "does not equal");

            Console.WriteLine("null {0} \"\"", b == "" ? "equals": "does not equal");
            Console.WriteLine("null {0} null", b == null ? "equals": "does not equal");

            int? i = null + 1;
            Console.WriteLine($"\"{i}\"");
        }
    }
}
