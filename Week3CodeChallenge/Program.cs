using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling FindPrimes
            FindPrimes(10001);
            Console.WriteLine();
            //calling EvenFibonacciSequencer
            EvenFibonacciSequencer(1000000);
            Console.WriteLine();
            //calling LongestCollatzSequence
            LongestCollatzSequence(837799);
            Console.WriteLine();

            Console.ReadKey(); //keep console open
        }
        //creating FindPrimes
        static void FindPrimes(int maxPrime)
        {
            //making an int list
            List<int> primeList = new List<int>() {2};
            //setting a test value
            int test = 3;
            //while the list count is less than our needed prime, run loop
            while (primeList.Count < maxPrime)
            {
                //setting bool
                bool prime = true;
                //running through each number
                for (int i = 2; i < test; i++)
                {
                    //if not prime
                    if (test % i == 0)
                    {
                        //false and break
                        prime = false;
                        break;
                    }
                }
                //if i = prime number
                if (prime)
                {
                    //add to our list
                    primeList.Add(test);
                }  
                //increment test by 1
                test++;
            }
            //writing our prime number to the console
            Console.WriteLine("The 10,001st prime number is: " + primeList.Last());
        }

        static void EvenFibonacciSequencer(long maxValue)
        {
            //total = 0
            long total = 0;
            //creating a list to hold our numbers
            List<long> fibList = new List<long>(){1,2};
            int i = 0;
            //while maxValue is greater than 1 loop will run
            while (maxValue > 1)
	        {
                //first is the index of the list
                long first = fibList[i];
                //last is the next index needed
                long last = fibList[i + 1];
                //final number is first plus last
                long final = first + last;
                //add final to the list
                fibList.Add(final);
                //if final is divisible by 2
                if (final % 2 == 0)
                {
                    //add to total
                    total += final;
                    //increment by 1
                    i++;
                }
                
	        }   
            Console.WriteLine(total);
        }

        static void LongestCollatzSequence(long input)
        {
            //n = input
            long n = input;
            //creating a loop count
            long loopCount = 0;
            //while n is greater than 1 the loop will run
            while (n>1)
            {
                //if n is even divide by 2
                if (n % 2 == 0)
                {
                    //increase loop count
                    n = n / 2;
                    loopCount++;
                }
                else
                {
                    //multiply n by 3 then add 1
                    n = (n * 3) + 1;
                    //increment loopcount
                    loopCount++;
                }
            }
            Console.WriteLine("Input: " + input);
            Console.WriteLine();
            Console.WriteLine("Loop sequence: " + loopCount + 1);
        }
    }
}
