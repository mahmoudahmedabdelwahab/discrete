using System;

namespace ConsoleApp10
{
    class Program
    {
        public static int begning { get; private set; }
        public static int end { get; private set; }
        public static int End { get; private set; }
        public static int n { get; private set; }
        public static int i { get; private set; }
        public static int sum { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter The Begning : ");

            begning = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the End: ");

            end = int.Parse(Console.ReadLine());

            Console.WriteLine("The Perfect numbers within the given range : ");

            for (n = begning; n <= End; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            Console.WriteLine("  ");
        }
    }
}
