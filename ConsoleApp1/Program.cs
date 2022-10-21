//Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string massege;

            Console.WriteLine("Проверяем, является ли число палинтромом");
            massege = Palintrom();
            Console.WriteLine($"Ответ: {massege}");

        }


        // Метод для проверки - является ли пятизначное число палинтромом.
        // Палинтромом - натуральные числа, которые читаются одинаково справа налево и слева направо.
        static string Palintrom()
        {                       
                string input, Out;
                bool IsTrue;

                //пользователь вводит число
                input = Console.ReadLine();

                //проверка валидации введённого числа (проверяем не более 100 раз)
                IsTrue = int.TryParse(input, out int number);
                for (int i = 0; IsTrue == false || number < 10000 || number > 99999; i++)
                {
                    Console.Write("Необходимо ввести пятизначное число формата integer.\nПовторите ввод: ");

                    input = Console.ReadLine();
                    IsTrue = int.TryParse(input, out number);

                    if (i == 99)
                    {
                        Out = "Некорректный ввод чисел";
                        return Out;
                    }
                }

            // Палинтромом или не палинтром? Вот в чём вопрос.
            // Число должно быть строго больше нуля
            if (number <= 0)
            {
                Out = "нет";
                return Out;
            }

            // Разложим введённое пользователем число на переменные
            int n1, n2, n3, n4, n5;
            n1 = (number % 10);
            n2 = (number / 10) % 10;
            n3 = (number / 100) % 10;
            n4 = (number / 1000) % 10;
            n5 = (number / 10000);

            // Сравним числа и узнаём, является ли число палинтромом
            if(n1 == n5 && n2 == n4)
            {
                Out = "да";
                return Out;
            }
            else
            {
                Out = "нет";
                return Out;
            }
        }
    }
}
