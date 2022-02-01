using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Primenumber
    {
        public void Prime()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("{0} is a prime number", number);
            }
            else
            {
                Console.Write("{0} is not a prime number", number);
            }
            Console.ReadKey();
        }
    }
}