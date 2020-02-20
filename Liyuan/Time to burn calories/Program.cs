//liyuan wang

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            double calgoal;
            double realCal;
            double burnedCal = 3.9;

            Console.WriteLine("How many calories you wish to burn?");
            calgoal = Convert.ToDouble(Console.ReadLine());

            do
            {
                realCal = (min * burnedCal);
               
                Console.WriteLine("You have burned " + realCal + " calories!");
                min++;

                if (realCal >= calgoal)
                {
                    Console.WriteLine("You reached your goal!");
                    break;
                }
            } while (true);

            Console.ReadLine();
        }
    }
}