using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MyArray2
    {
        public static void arrayForLoop()
        {
            int[] n = new int[10]; /* n is an array of 10 integers */

            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }
    }

    class JaggedArrays
    {
        public static void JaggedArraysExample()
        {
            /* a jagged array of 5 array of integers*/
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            };
        }
    }
    class MyArrayParseToFunctionArguments
    {
    
            public double getAverage(int[] arr, int size)
            {
                int i;
                double avg;
                int sum = 0;

                for (i = 0; i < size; ++i)
                {
                    sum += arr[i];
                }
                avg = (double)sum / size;
                return avg;
            }
    }

    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }

            Console.WriteLine("Next is foreach loop:");

            MyArray2.arrayForLoop();
            Console.WriteLine("Jagged arrays below: \n");
            JaggedArrays.JaggedArraysExample();

            //MyArrayParseToFunctionArguments
            Console.WriteLine("MyArrayParseToFunctionArguments below: \n\n");
            MyArrayParseToFunctionArguments app = new MyArrayParseToFunctionArguments();

            /* an int array with 5 elements */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            /* pass pointer to the array as an argument */
            avg = app.getAverage(balance, 5);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);

            Console.ReadKey();
        }
    }
}
