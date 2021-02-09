using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class ListArmstrong
    {

        public static string ListOfArmNumbers(int start,int end)
        {
            string s = "";
            for (int i = start; i <= end; i++)
            {
                if (IsArmstrong.IsArm(i))
                {
                    s = s + i + ",";
                }
              
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ListOfArmNumbers(1,1000));

        }
    }
}
