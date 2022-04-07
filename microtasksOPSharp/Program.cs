using System;

namespace microtasksOPSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первая

            Console.WriteLine("Задача 1");
            int a1, b1;

            Console.WriteLine("Первое число: ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            b1 = int.Parse(Console.ReadLine());
            if(a1 == b1)
            {
                Console.WriteLine("Равны");
            }
            else if(a1 > b1)
            {
                Console.WriteLine("Первое больше");
            }
            else
            {
                Console.WriteLine("Второе больше");
            }

            //Вторая
            Console.WriteLine("Задача 2");
            int a2;
            a2 = int.Parse(Console.ReadLine());
            if (5 < a2 && a2 < 10)
            {
                Console.WriteLine("Число ,больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

            //Третья

            Console.WriteLine("Задача 3");
            int a3;
            a3 = int.Parse(Console.ReadLine());
            if(a3 == 5 || a3 == 10)
            {
                Console.WriteLine("Число равно 5 или 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }


            //Задача 4

            Console.WriteLine("Задача 4");

            double vklad;

            vklad = double.Parse(Console.ReadLine());

            if (vklad < 100)
            {
                vklad *= 1.07;
            }
            else if (vklad >= 100 && vklad < 200)
            {
                vklad *= 1.09;

            }
            else
            {
                vklad *= 1.12;
            }
            Console.WriteLine(vklad);


            //Задача 5
            Console.WriteLine("Задача 5");

            vklad += 15;

            Console.WriteLine(vklad);
        }
    }
}
