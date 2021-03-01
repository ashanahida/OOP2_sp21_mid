using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE");
            Department d2 = new Department("EEE");

            Student s1 = new Student("NAHIDA", "19-41190-2", 3.90);
            Student s2 = new Student("ASHA", "19-41191-2", 3.60);
            Student s3 = new Student("NOYON", "19-41192-2", 3.30);
            Student s4 = new Student("EMON", "19-41193-2", 2.70);

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.ReadLine();
        }
    }
}
    

