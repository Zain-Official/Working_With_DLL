using System;
using Working_With_DLL;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Demo d = new Demo();
            Console.WriteLine("Enter Two Number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n**********************\n");
            c = d.Sum(a, b);
            Console.WriteLine("Sum Of {0} + {1} = {2}", a, b, c);
            Console.WriteLine("\n**********************\n");
            c = d.Sub(a, b);
            Console.WriteLine("Sub Of {0} - {1} = {2}", a, b, c);
            Console.WriteLine("\n**********************\n");
            c = d.Multi(a, b);
            Console.WriteLine("Multi Of {0} * {1} = {2}", a, b, c);
            Console.WriteLine("\n**********************\n");
            c = d.Division(a, b);
            Console.WriteLine("Sum Of {0} / {1} = {2}", a, b, c);
        }
    }
}
