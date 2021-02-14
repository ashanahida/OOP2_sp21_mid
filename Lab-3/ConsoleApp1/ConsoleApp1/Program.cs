using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Console.Write("Name      : ");
            student.Name = Console.ReadLine();
             Console.Write("ID        : ");
            student.Id = Console.ReadLine();
            Console.Write("Department: ");
            student.Department = Console.ReadLine();
            Console.Write("CGPA      : ");
            student.Cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            student.ShowIngo();

            triangle triangle = new triangle();
            Console.Write(" X: ");
            triangle.X = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Y: ");
            triangle.Y = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Z: ");
            triangle.Z = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            triangle.ShowInfo();

            Account account = new Account();
            Console.Write("Account Name: ");
            account.AccName = Console.ReadLine();
            Console.Write("Account ID: ");
            account.Acid = Console.ReadLine();
            Console.Write("deposit amount: ");
            account.deposit(Convert.ToInt16(Console.ReadLine()));
            Console.Write("withdraw Amount: ");
            account.withdraw(Convert.ToInt16(Console.ReadLine()));

            Course course = new Course();
            Console.Write("Course Name: ");
            course.CourseName = Console.ReadLine();
            Console.Write("Course Code: ");
            course.CourseCode = Console.ReadLine();
            Console.Write("Course Credit: ");
            course.CourseCredit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            course.ShowCourseInfo();

            Console.ReadLine();
        }
    }
}
