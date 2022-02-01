using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacciseries
    {

        public int a = 0;
        public int b = 1;
        public int c;
        public void Fibonacci()
        {
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series : ");
            Console.WriteLine(a+ "\n" +b);
            for (int i = 2; i < number; i++)
            {   
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
