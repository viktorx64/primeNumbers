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
            Console.WriteLine("how many prime numbers do you desire?");
            Console.ReadLine();

        }

        private static int testPrime(int num) { 
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
