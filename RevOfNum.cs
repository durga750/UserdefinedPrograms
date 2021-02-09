using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro
{
    class RevOfNum
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int rev = 0;
            while(num>0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
               
            }
            Console.WriteLine(rev);
        }
    }
}
