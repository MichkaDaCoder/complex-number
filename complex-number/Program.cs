using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "complex-number";

            Complex complex1 = new Complex(2, 3);
            Complex complex2 = new Complex(3, 4);

            Console.WriteLine("First complex : " + complex1);
            Console.WriteLine("Second complex: " + complex2);
            Console.WriteLine();
            Console.WriteLine("Sum complex: " + complex1.Sum(complex1, complex2));
            Console.WriteLine("Sub complex: " + complex1.Sub(complex1, complex2));
            Console.ReadKey(true);
        }
    }
}
