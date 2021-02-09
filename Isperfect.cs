using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class Isperfect
    {
        public static int Perfect(int num)
        {
            int sum = 0;
            int temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static bool IsPerfectNum(int num)
        {
            int temp = num;
            return Perfect(num) == temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectNum(6));

        }
    }
}
