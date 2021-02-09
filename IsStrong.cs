using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class IsStrong
    {
        public static int Strong(int num)
        {
            int sum = 0;
            int temp = num;
            while(num>0)
            {
                int fact = 1;
                int digit = num % 10;
                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;

                }
                sum += fact;
                num /= 10;
            }
            return sum;
        }


        public static bool IsStrongNum(int num)
        {
            int temp= num;
            return Strong(num) == temp;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsStrongNum(144));
        }
    }
}
