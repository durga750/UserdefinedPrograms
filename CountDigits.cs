using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro
{
    class CountDigits
    {
        static void Main(string[] args)
        {
            int num = 12345;
            int count = 0;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                sum += digit;
                num /= 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
        }
    }
}
