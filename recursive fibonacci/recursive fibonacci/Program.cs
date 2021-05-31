using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me the number for fibonacci");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

        }
        public static int Fibonacci(int a)
        {
            if (a == 0) return 0;
            else if (a == 1) return 1;
            else return Fibonacci(a - 1) + Fibonacci(a - 2);
        }

    }
}
