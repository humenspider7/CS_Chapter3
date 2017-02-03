using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            double pCost = 69.43;
            double oCost = 40.4;
            double mCost = 493.32;
            Console.WriteLine("Please choose.  P for pine, O for Oak, or M for mahogany.");
            string choice = Console.ReadLine().ToLower();
            if (choice == "p") Console.WriteLine("Cost: " + pCost + "$ for Pine");
            if (choice == "o") Console.WriteLine("Cost " + oCost + "$ for Oak");
            if (choice == "m") Console.WriteLine("Cost " + mCost + "$ for Mahogany");
            else Console.WriteLine("Cost: 0$");
            
        }
    }
}
