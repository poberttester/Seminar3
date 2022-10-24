// Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            cubeOfNumbers();
        }


        static void cubeOfNumbers()
        {
            int result;

            Console.Write("Введите число от 1 до N: ");
            String input = Console.ReadLine();
            int.TryParse(input, out int N);

            for (int i = 1; i <= N; i++)
            {
                result = Convert.ToInt32(Math.Pow(i, 3));
                Console.Write(result + " ");
            }

            Console.ReadKey();
        }

    }
}
