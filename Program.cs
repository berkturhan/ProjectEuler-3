using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        
        static void Main(string[] args)
        {


            ulong num = 600851475143;
            ulong divider = 2;
            ulong number = 0;

            while (true)
            {
                if (num % divider == 0)
                {
                    if (isPrime(num / divider))
                    { number = num / divider; break; }
                }
               
                    divider++;
            }


            Console.WriteLine(number);

            Console.ReadLine();

        }



        public static bool isPrime(ulong num)
        {
            if (num == 1) return false;
            if (num == 2) return true;
        
            ulong newnum = Convert.ToUInt64(Math.Sqrt(num));
            
            for (ulong i = 2; i <= newnum; i++)
                if (num % i == 0) return false;

            return true;
        }

      
    }
}
