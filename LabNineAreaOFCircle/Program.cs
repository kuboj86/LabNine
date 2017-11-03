using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNineAreaOFCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            do
            {
                Console.Write("Please enter in a number to determine the radius of a circle?:\t");
                double radius = Convert.ToDouble(Console.ReadLine());

                Circle myCircle = new Circle(radius);

                Console.WriteLine($"The area of the circle is:\t{myCircle.GetFormattedArea()}");
                Console.WriteLine($"The circumferance of the circle is:\t{myCircle.GetFormattedCircumference()}");
                shouldContinue = Option();
            } while (shouldContinue);
            int count = 0;
            Console.WriteLine($"ok, Goodbye.");
        }
        static bool Option()
        {
            {
                string answer;
                do
                {
                    Console.Write("Would you like to make another circle?:   Y/N ");
                    answer = Console.ReadLine();
                } while (!(answer.ToLower() == "y" || answer.ToLower() == "n"));
                return (answer == "y");
            }
        }
    }
}
