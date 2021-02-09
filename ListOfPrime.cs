using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class ListOfPrime
    {



        public static string ListOfPrimeNum(int start, int end)
        {
            string str = "";
            Console.WriteLine(str + "dfg");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime.IsPrimeNum(i))
                {
                    str += i + ",";
                }
            }

            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ListOfPrimeNum(1,10));

        }
    }
}
