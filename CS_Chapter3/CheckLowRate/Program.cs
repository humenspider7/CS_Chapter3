using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            Console.WriteLine("Enter payrate:");
            string paystring = Console.ReadLine();
            double pay = Convert.ToDouble(paystring);
            if (pay < 5.65)
                Console.WriteLine("What the hell are those capitalist swine paying you? That's below minimum wage!");
        }
    }
}
