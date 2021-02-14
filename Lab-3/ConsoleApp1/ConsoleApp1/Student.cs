using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string name, id,department;
        private float cgpa;

        public Student()
        {
            Console.WriteLine("empty Student Obj Create.");
        }

        public void ShowIngo()
        {
            Console.WriteLine("Student Name      : " + name);
            Console.WriteLine("Student ID        : " + id);
            Console.WriteLine("Student Department: " + department);
            Console.WriteLine("Student Cgpa      : " + cgpa);
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }
        public float Cgpa
        {
            set
            {
                cgpa = value;
            }
            get
            {
                return cgpa;
            }
        }

    }
}


