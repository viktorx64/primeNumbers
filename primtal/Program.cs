﻿using System;
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
            //loop until you get desired amount prime numbers
            int i = 0;
            int j = 2;
            Console.WriteLine("---"); // make it easier to see whre the prime numbers start
            while(i < primeCount) {
                if (testPrime(j) == 0) {
                    //do nothing
                } else {
                    Console.WriteLine($"{ j }");
                    i++;
                }
                j++;
            }
            
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
                return num;
            }
            return 0;
        }
    }
}
