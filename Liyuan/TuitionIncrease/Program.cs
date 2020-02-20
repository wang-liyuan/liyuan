using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            int tuition1 = 12000;
            double inxrt = .05;

            for (int i = 1; i < 8; i++)
            {
                double tuition2;
                tuition2 = (tuition1 * (Math.Pow((1 + inxrt),i)));
                tuition2=Convert.ToInt32(tuition2);
                Console.WriteLine("The tuition after year "+i+" will be $"+"{0:n}" ,tuition2);
            }

            Console.ReadKey();
        }
    }

}
