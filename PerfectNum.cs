using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class PerfectNum
    {
        static void Main(string[] args)
        {
            int num = 6;
            int sum = 0;
            int temp = num;
            for (int i = 1; i <num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(sum);

            if(sum==temp)
            {
                Console.WriteLine($"{temp} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{temp} is not a perfect number");
            }





        }
    }
}
