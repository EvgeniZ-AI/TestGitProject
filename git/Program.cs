using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());

            int b = a * a;
            Console.WriteLine($"{a} * {a} = {logic.powerOf2(a)}");

        }
    }
}
