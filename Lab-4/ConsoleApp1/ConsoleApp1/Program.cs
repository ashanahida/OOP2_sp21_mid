using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            int n;
            Console.WriteLine("program1");
            Console.Write("Array Size :");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];
            Console.WriteLine("Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("ReverseArray : ");
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            //2
            Console.WriteLine("program2");
            Console.Write("Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr2 = new int[n];
            Console.WriteLine("Array {0} Element : ", n);
            for (int i = 0; i < n; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                sum += arr2[i];
            }
            Console.WriteLine("ArraySum : " + sum);

            //3
            Console.WriteLine("program3");
            Console.Write("ArraySize: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr3 = new int[n];
            Console.WriteLine("Array {0} & Element: ", n);
            for (int i = 0; i < n; i++)
            {
                arr3[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] anotherArr = new int[n];
            for (int i = 0; i < arr3.Length; i++)
            {
                anotherArr[i] = arr3[i];
            }

            Console.Write("AnotherArray: ");
            for (int i = 0; i < anotherArr.Length; i++)
            {
                Console.Write(anotherArr[i] + " ");
            }
            Console.WriteLine();

            //4
            Console.WriteLine("program4");
            Console.Write("ArraySize: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr4 = new int[n];
            Console.WriteLine("Array {0} & Element: ", n);
            for (int i = 0; i < n; i++)
            {
                arr4[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[,] countArr1 = new int[n, 2];
            int countArrayIndex = 0;
            for (int i = 0; i < arr4.Length; i++)
            {
                int num = arr4[i];
                if (num != -1)
                {
                    countArr1[countArrayIndex, 0] = num;
                    countArr1[countArrayIndex, 1]++;
                    for (int j = i + 1; j < arr4.Length; j++)
                    {
                        if (num == arr4[j])
                        {
                            countArr1[countArrayIndex, 1]++;
                            arr4[j] = -1;
                        }
                    }
                    countArrayIndex++;
                }
            }
            Console.WriteLine("Counting Duplicate Elements: ");
            for (int i = 0; i < countArrayIndex; i++)
            {
                Console.WriteLine("\t" + countArr1[i, 0] + " contains " + countArr1[i, 1] + " times.");
            }

            //5
             Console.WriteLine("program5");
            Console.Write("ArraySize: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr5 = new int[n];
            Console.WriteLine("Array {0} & Element : ", n);
            for (int i = 0; i < n; i++)
            {
                arr5[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr5.Length; i++)
            {
                int num = arr5[i];
                if (num != -1)
                {
                    for (int j = i + 1; j < arr5.Length; j++)
                    {
                        if (num == arr5[j])
                        {
                            arr5[j] = -1;
                        }
                    }
                }

            }
            Console.Write("EuniqueElements: ");
            for (int i = 0; i < arr5.Length; i++)
            {
                if (arr5[i] != -1)
                {
                    Console.Write(arr5[i] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

