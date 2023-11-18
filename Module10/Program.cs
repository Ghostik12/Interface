using System;

namespace Module10
{
    class Program
    {
        static ISum Sum { get; set; }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите два числа");
                    Console.Write("A: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("S: ");

                    Sum = new Summa();
                    var worker1 = new Worker(Sum);
                    worker1.Work(a, b);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Число введенон не корректно");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }

    public interface ISum
    {
        void Sum(int a, int b);
    }

    class Summa : ISum
    {
        void ISum.Sum(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int c = a + b;
            Console.WriteLine($"S: {c}");
        }
    }

    public interface IWorker
    {
        void Work(int a, int b);
    }
}