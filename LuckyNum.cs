using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdomNum
{
    class LuckyNum
    {

        public static int GetLucky(string Dob)
        {
            String[] s = Dob.Split('-');  //12-March-1994
            int date = int.Parse(s[0]);
            int month = CovertMonToNum(s[1]);
            int year = int.Parse(s[2]);
            int sum = date + month + year;  //2009

            while(sum>9)
             {
                sum = GetSumOfDigits(sum);
                
            }

            return sum;
        }

        public static int CovertMonToNum(String month)
        {
            String[] months = {"jan","feb","mar","april","may","june","july","aug","sep","oct","nov","dec"};
            for (int i = 0; i < months.Length; i++)
            {
                if (month.Contains(months[i]))
                {
                    return i + 1;
                }
            }
            return 0;
            
        }


        public static int GetSumOfDigits(int num)    //2009
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num /= 10;
            }
            return sum;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetLucky("19-june-1996"));
        }
    }
}
