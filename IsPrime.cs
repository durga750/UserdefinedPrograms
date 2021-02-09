using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class IsPrime
    {
        public static int Prim(int num)
        {
                   
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if(num%i==0)
                {
                    count++;

                }
            }
            return count;
        }

        public static bool IsPrimeNum(int num)
        {
           
            return Prim(num)==2;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeNum(13));

        }
    }
}
