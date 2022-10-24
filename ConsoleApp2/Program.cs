// Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            distanceIn3D();
        }


        // метод для нахождения расстояния
        static void distanceIn3D()
        {
            double result, Length;
            String input;
            int x1, y1, z1,
                x2, y2, z2;  // Переменная для записи значений координат



            Console.WriteLine("Введите 3 координаты для точки 'А'");

            input = Console.ReadLine();
            x1 = int.Parse(input);

            input = Console.ReadLine();
            y1 = int.Parse(input);

            input = Console.ReadLine();
            z1 = int.Parse(input);



            Console.WriteLine("Введите 3 координаты для точки 'B'");
            input = Console.ReadLine();
            x2 = int.Parse(input);

            input = Console.ReadLine();
            y2 = int.Parse(input);

            input = Console.ReadLine();
            z2 = int.Parse(input);



            Length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
            result = Math.Round(Length, 2);
            Console.Write("Расстояние между точками в пространстве равно: " + result);
            Console.ReadKey();
        }
    }
}
