using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro
{
    class SplitNum
    {
        static void Main(string[] args)
        {
           
            int num = 13456;
            while(num>0)
            {
                int digit = num % 10 ; 
                num /= 10;
                Console.WriteLine(digit);
            }
           

        }
    }
}
