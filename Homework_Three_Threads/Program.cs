using System;
using System.Threading;

namespace Homework_Three_Threads
{
    class Program
    {
        //public static ParameterizedThreadStart Factorial { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for 1 thread (factorial): ");
            int factorial = int.Parse(Console.ReadLine());
            Thread threadFactorial = new Thread(Factorial); //створюємо потік
            threadFactorial.Start(factorial); //запускаємо потік
            threadFactorial.IsBackground = true; //робимо потік фоновим
            Thread.Sleep(500);
            Console.WriteLine();

            Console.WriteLine("Enter number for 2 thread (syma): ");
            int syma = int.Parse(Console.ReadLine());
            Thread threadSyma = new Thread(Syma);//створюємо потік
            threadSyma.Start(syma); //запускаємо потік
            threadSyma.IsBackground = true; //робимо потік фоновим
            Thread.Sleep(500);
            Console.WriteLine();

            Console.WriteLine("Enter number for 3 thread (fibonachi): ");
            int fibonachi = int.Parse(Console.ReadLine());
            Thread threadFibonachi = new Thread(Fibonachi);//створюємо потік
            threadFibonachi.Start(fibonachi);//запускаємо потік
            threadFibonachi.IsBackground = true;//робимо потік фоновим
            Thread.Sleep(500);
            //Console.ReadLine();
        }

        private static void Factorial(object obj) //метод для визначення факторіалу
        {
            int result = 1;
            for (int i = 1; i < (int)obj + 1; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Result factorial number {(int)obj}: {result}");
        }

        private static void Syma(object obj) //метод для визначення суми
        {
            int result = 0;
            for (int i = 1; i < (int)obj + 1; i++)
            {
                result += i;
            }
            Console.WriteLine($"Result syma number {(int)obj}: {result}");
        }

        private static void Fibonachi(object obj) //метод для визначення суми
        {
            int result = 1; int next = 1;
            for (int i = 0; i < (int)obj + 1; i++)
            {
                int temp = next;
                next = result + next;
                result = temp;
            }
            Console.WriteLine($"Result fibonachi number {(int)obj}: {result}");
        }


    }
}
