using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class AvgOfParameters
    {
        public static int Average(int num1,int num2,int num3)
        {
           int  Avg = (num1 + num2 + num3) / 3;
            return Avg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Average(3,5,4));
        }
    }
}
