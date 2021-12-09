using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 11. Структура
              Разработать структуру для решения линейного уравнения 0=kx+b.
              Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. Для решения уравнения предусмотреть метод Root.
              Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.*/
            Console.WriteLine("Решить линейное уравнение: kx + b =0");
            Console.WriteLine("\nВведите значение коэффициента k:");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение коэффициента b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Equation eq = new Equation(k, b);
            eq.Root();
            Console.ReadKey();
        }
    }
    struct Equation
    {
        public double k;
        public double b;
        
        public Equation(double k = 0, double b = 0)
        {
            this.k = k;
            this.b = b;
        }
        public void Root()
        {
            double x = (- b) / k;
            if (b >= 0)
            {
                Console.WriteLine($"\nВ уравнении: {k}x + {b} = 0, x = {x}");
            }
            if (b < 0)
            {
                Console.WriteLine($"\nВ уравнении: {k}x - {-b} = 0, x = {x}");
            }
        }
    }
}