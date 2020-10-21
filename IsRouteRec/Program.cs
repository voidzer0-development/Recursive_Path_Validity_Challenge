using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsRouteRec
{
    class Program
    {
        
        //signature
        public static bool isRoute(int xStart, int yStart, int xEnd, int yEnd)
        {

            return false;
        }

        static void Main(string[] args)
        {
            bool a = isRoute(2, 10, 26, 12);

            if (a == true)
            {
                Console.WriteLine("Route is valid");
            }
            else
            {
                Console.WriteLine("Route is not valid");
            }

            Console.ReadKey();
        }
    }
}
