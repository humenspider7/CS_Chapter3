﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            Console.WriteLine("Enter pay rate:");
            string pay = Console.ReadLine();
            double payrate = Convert.ToDouble(pay);
            if (payrate < 5.65 || payrate > 49.99 )
                Console.WriteLine("What the **** are you being paid.  This isn't normal for a janitor.");
        }
    }
}
