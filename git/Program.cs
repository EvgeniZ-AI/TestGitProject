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

            Console.WriteLine("Введите второе число");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} * {a} = {logic.Power(a,p)}");

        }
    }
}
