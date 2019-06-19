using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            var a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            var b = Int32.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            var c = Int32.Parse(Console.ReadLine());

            double val1       = (b * b) - (4 * a * c);
            double val        = Math.Sqrt(val1);
            double valPlus    = -b + val;
            double valMins    = -b - val;
            double answerPlus = valPlus / (2 * a);
            double answerMins = valMins / (2 * a);
            double testPlus   = a * (answerPlus * answerPlus) + b * answerPlus + c;
            double testMins   = a * (answerMins * answerMins) + b * answerMins + c;

            if (testPlus == 0 && testMins == 0 || answerPlus == 0 || answerMins == 0)
            {
                if (val1 < 0)
                {
                    Console.WriteLine("Invalid entry: Cannot find the square root of a negative number. ");

                }
                if (answerMins == 0 || answerPlus == 0)
                {
                    Console.WriteLine("The answer is 0");
                }
                else
                {
                    Console.WriteLine($"The answer is {answerPlus}");
                    Console.WriteLine($"The answer is {answerMins}");
                }
            }
            else
            {
                Console.WriteLine("This solution is not solvable!");
            }
            Console.ReadLine();
        }
    }
}
