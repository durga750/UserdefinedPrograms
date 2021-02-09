using System;

namespace UserDefinedMethods
{
    class IsArmstrong
    {
        public static int Count(int num)
        {
            int coun = 0;
            while(num>0)
            {
                int digit = num % 10;
                coun++;
                num /= 10;
            }
            return coun;
        }

        public static int Pval(int power , int bas)
        {
            int sun = 0;
            while (bas > 0)
            {
                int digit = bas % 10;
                int pval = 1;

                for (int i = 1; i <= power; i++)
                {
                    pval *= digit;

                }
               
                sun += pval;
                bas /= 10;
            }

            return sun;
        }

        public static bool IsArm(int num)
        {
            return num==Pval(Count(num), num);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsArm(153));
        }
    }
}
