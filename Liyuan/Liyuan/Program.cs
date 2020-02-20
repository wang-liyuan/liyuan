using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liyuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = random.Next(1,50);
            int num2 = random.Next(1,50);
            int result;
            result = num1 + num2;
            Console.WriteLine(num1 + "+"+num2+"=?");
            result = Convert.ToInt32(Console.ReadLine());


            while (result!= (num1+num2))
               
            {
                Console.WriteLine("Your result is wrong, please try again.");
                int num3 = random.Next(1, 50);
                int num4 = random.Next(1, 50);
                int result2;
                result2 = num3 + num4;
                Console.WriteLine(num3 + "+" + num4 + "= ?");
                result2 = Convert.ToInt32(Console.ReadLine());
                if (result2 == (num3 + num4)) {
                    break;
                }

            }
            Console.WriteLine("Your answer is right");
            Console.ReadKey();
        }
    }
}
