using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdomNum
{
    class ListOfAdomNum
    {

        public static string ListOfAdomNumer(int start,int end)
        {
            string s = "";
            for(int i = start; i <= end; i++)
            {
                if (IsAdomNum.IsAdom(i))
                {
                    s = s + i + ",";
                }
               
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ListOfAdomNumer(1,1000));
        }

    }
}
