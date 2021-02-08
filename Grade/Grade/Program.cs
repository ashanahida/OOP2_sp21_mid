using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {   double phy, chem, bio, math, com;
            Console.Write("Physics marks: ");
            phy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chemistry Marks: ");
            chem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Biology Marks: ");
            bio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mathematics Marks: ");
            math = Convert.ToDouble(Console.ReadLine());
            Console.Write("Computer Marks: ");
            com = Convert.ToDouble(Console.ReadLine());

            double avgMarks = (phy + chem + bio + math + com) / 5;
            string grade = "";

            if (avgMarks >= 90)
                grade = "A+";
            else if (avgMarks < 90 && avgMarks >= 85)
                grade = "A";
            else if (avgMarks < 85 && avgMarks >= 80)
                grade = "B+";
            else if (avgMarks < 80 && avgMarks >= 75)
                grade = "B";
            else if (avgMarks < 75 && avgMarks >= 50)
                grade = "C+";
            else
                grade = "F";

            Console.WriteLine("\nThe Grade is: " + grade);


            Console.ReadLine();
        }
    }
}
        
    


