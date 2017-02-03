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
            double pCost = 69.43;
            double oCost = 40.4;
            double mCost = 493.32;
            Console.WriteLine("Pease choose.  P for pine, O for Oak, or M for mahogany.");
            string choice = Console.ReadLine();
            if (choice == P) Console.WriteLine("Cost: " + pCost + "$");
            
        }
    }
}
