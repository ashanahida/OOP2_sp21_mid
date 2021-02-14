using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class triangle
    {
        private int x;
        private int y;
        private int z;

        public triangle()
        {
            Console.WriteLine("empty Triangle Obj Create.");
        }

        public void ShowInfo()
        {
            Console.WriteLine("X value is           : " + x);
            Console.WriteLine("Y value is           : " + y);
            Console.WriteLine("Z value is           : " + z);
            Console.WriteLine("The Triangle value is: " + TestTriangle());
        }

        private string TestTriangle()
        {
            if (x == y && x == z)

                return "Triangle is Equilateral";

            else if (x == y || x == z || y == z)
                return "Triangle is Isosceles";

            else
                return "Triangle is Scalene";
        }

        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public int Z
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }
    }
}


