using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
    //Find the sum of all numbers which are equal to the sum of the factorial of their digits.
   // Note: as 1! = 1 and 2! = 2 are not sums they are not included.
    public class Task2
    {
        
            public String run()
            {
                int sum = 0;
                for (int i = 3; i < 10000000; i++)
                {
                    if (i == factorialSigitSum(i))
                        sum += i;
                }
                return Integer.toString(sum);
            }
            private static int factorialSigitSum(int x)
            {
                int sum = 0;
                while(x != 0)
               {
                    sum += FACTORIAL[x % 10];
                    x /= 10;
                }
                return sum;
            }
            public static void Main(String[] args)
            {
                Task2 solution = new Task2();
                Console.WriteLine(solution.run());
            }
        }
    }


