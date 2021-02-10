using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdomNum
{
    class IsAdomNum
    {
      

        public static int Sqr(int num)
        {
            int square = num * num;
            return square;
        }

        public static int Rev(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }
            return rev;
        }


        public static bool IsAdom(int num)
        {
            return Sqr(num) == Rev(Sqr(Rev(num)));
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsAdom(12));
        }
    }
}
