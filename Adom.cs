using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdomNum
{
    class Adom
    {
        static void Main(string[] args)
        {
            int num = 13;
            int tem = num;
            
            int square = num * num;
                                          //Console.WriteLine(square);
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }
                                        // Console.WriteLine(rev);
            int squareOfrev = rev * rev;
                                       // Console.WriteLine(squareOfrev);
            int num1 = squareOfrev;
            int revnm = 0;
            while(num1>0)
            {
                int digit = num1 % 10;
                revnm = revnm * 10 + digit;
                num1 /= 10;
            }

            Console.WriteLine(revnm);
                   
            if(square== revnm)
            {
                Console.WriteLine($"{tem} is a adom number");
            }
            else
            {
                Console.WriteLine($"{tem} is not a adom number");
            }
        }
    }
    
}
