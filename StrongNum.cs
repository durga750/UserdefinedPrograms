using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class StrongNum
    {
        static void Main(string[] args)
        {
            int num = 145;
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
                sum = sum + fact;
                num /= 10;
            }
            Console.WriteLine(sum);

            if (sum==temp)
            {
                Console.WriteLine($"{temp} is strong number ");
            }
            else
            {
                Console.WriteLine($"{temp} is not a strong number ");

            }



        }
    }
}
