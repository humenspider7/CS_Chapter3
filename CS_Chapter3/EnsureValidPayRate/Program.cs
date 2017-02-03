using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            Console.WriteLine("Enter payrate:");
            string paystring = Console.ReadLine();
            double pay = Convert.ToDouble(paystring);

            if (pay > 5.65 && pay < 49.99)
                Console.WriteLine("Hourly: " + pay + "$ Weekly: " + pay * 40.00 + "$");
            if(pay < 5.65 || pay > 49.99)
            {
                Console.WriteLine("Error.  Re-enter.  You dumb ****");
                string reenterS = Console.ReadLine();
                double reenterD = Convert.ToDouble(reenterS);
                Console.WriteLine("Hourly: " + reenterD + "$ Weekly: " + reenterD * 40 + "$");
            }
        }
    }
}
