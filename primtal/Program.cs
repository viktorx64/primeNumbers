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
            int primeCount = Convert.ToInt32(Console.ReadLine());
            int[] prime_numbers = new int[primeCount];
            //loop until you get desired amount prime numbers
            int i = 0;
            Console.WriteLine(testPrime(primeCount));
            /*
            while(i < primeCount) {
                if (testPrime(i) == 1) {
                    Console.WriteLine("punk ass bitch");
                    i++;
                }
            }
            */
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
