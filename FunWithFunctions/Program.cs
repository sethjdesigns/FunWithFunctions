using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = false;
            test = true;

            bool? test2 = default(bool?);

            BoolTest(test2);
            test2 = false;
            BoolTest(test2);
            test2 = false;
            BoolTest(test2);
            test2 = null;

            var elapsedDays = ComputeDays(DateTime.Now, new DateTime(2015, 3, 23));
            Console.WriteLine("I've been writing software for {0} days", elapsedDays);

            elapsedDays = ComputeDays(new DateTime(2015, 5, 15), new DateTime(2015, 3, 23));
            Console.WriteLine("When I finish, I will have written software for {0} days", elapsedDays);

            elapsedDays = ComputeDays(DateTime.Now, new DateTime(1999, 12, 31));
            Console.WriteLine("We have not been able to party like it's 1999, for {0} days", elapsedDays);

            int factorial = Factorial(10);
            Console.WriteLine(factorial);

            factorial = RecursiveFactorial(10);
            Console.WriteLine(factorial);

            Console.ReadLine(); 
        }

        private static void BoolTest(bool? test2)
        {
            if (test2 == true)
                Console.WriteLine("Tru");
            else if (test2 == false)
                Console.WriteLine("False");
            else if (test2 == null)
                Console.WriteLine("has no value");
            else
                Console.WriteLine("NOPE");
        }

        private static int RecursiveFactorial(int p)
        {
            return (p == 1) ? 1 : p * RecursiveFactorial(p - 1);
        }

        public static int Factorial(int n) 
        {
            var answer = 1;
            for (int i = 1; i <= n; i++)
                answer *= i;

            return answer;
        }

        public static int ComputeDays(DateTime endPoint, DateTime startPoint)
        {
            var days = endPoint - startPoint;
            var elapsedDays = Math.Floor(days.TotalDays);
            return (int)elapsedDays;
        }
    }
}
