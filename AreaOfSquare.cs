using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    class AreaOfSquare
    {
        public static int Area( int side)
        {
             int Area = side * side;
              return Area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Area(6));

        }
    }
}
