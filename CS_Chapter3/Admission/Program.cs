using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter GPA: ");
            string gpaS = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaS);

            Console.WriteLine("Enter test score: ");
            string scoreS = Console.ReadLine();
            double score = Convert.ToDouble(scoreS);
            
            if (gpa >= 3.00 && score >= 60.00)
                Console.WriteLine("Congratulations you have met the requirements to enter the academy of no capitalism!");
            if (gpa < 3.00 && score >= 80.00)
                Console.WriteLine("Congratulations you have met the requirements to enter the academy of no capitalism!");
            else
                Console.WriteLine("Rejected. Get a job loser.");

        }
    }
}
