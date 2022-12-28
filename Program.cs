using System;
namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter The Begning : ");

             int begning = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the End: ");

             int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The Perfect numbers within the given range : ");

            for ( int n = begning; n <= end; n++)
            {
                int i = 1;
                int sum = 0;
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