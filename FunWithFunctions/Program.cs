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
            var elapsedDays = ComputeDays(DateTime.Now, new DateTime(2015, 3, 23));
            Console.WriteLine("I've been writing software for {0} days", elapsedDays);
            Console.ReadLine();
        }

        public static int ComputeDays(DateTime endPoint, DateTime startPoint)
        {
            var days = endPoint - startPoint;
            var elapsedDays = Math.Floor(days.TotalDays);
            return (int)elapsedDays;
        }
    }
}
