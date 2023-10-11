using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CalculatorApplication
{
    class NumberManipulatorFactorial
    {
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        class NumberManipulator
        {
            public int FindMax(int num1, int num2)
            {
                /* local variable declaration */
                int result;

                if (num1 > num2)
                    result = num1;
                else
                    result = num2;
                return result;
            }

            static void Main(string[] args)
            {
                /* local variable definition */
                int a = 100;
                int b = 200;
                int ret;
                NumberManipulator n = new NumberManipulator();

                //calling the FindMax method
                ret = n.FindMax(a, b);
                Console.WriteLine("Max value is : {0}", ret);
                

                int c = 2;
                int d = 1;
                int result;
                NumberManipulatorFactorial f = new NumberManipulatorFactorial();
                //result = f.factorial(c);
                //Console.WriteLine("Factorial of {0} is {1}",c,result);
                
                while (d <= 10) {
                    Console.WriteLine("Factorial of {0} is {1}",d, f.factorial(d));
                    d++;
                }
                Console.ReadKey();
            }
        }
    }
}
