using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro
{
    class AvegOfDigits
    {
        int digit = 0;
        static void Main(string[] args)
        {
            int num = 123;
            int count=0;
            int sum = 0, avg = 0;
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                rev = rev * 10 + digit;
                count++;
                avg = sum / count;
                num /= 10;
                Console.WriteLine(digit);
            }
           
            Console.WriteLine(rev);
            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(avg);

        }
    }
}
