using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primeNumer(6));
            Console.WriteLine(primeNumer(5));
        }

        private static int primeNumer(int num) {
            //make it test if it is a prime number or not
            int i;
            for (i = 2; i < num; i++) {
                //test if it is dividable or not
                if (num % i == 0) {
                    return 0;
                }
            }
            if (i == num) {
                return 1;
            }
            return 0;
        }
    }
}
