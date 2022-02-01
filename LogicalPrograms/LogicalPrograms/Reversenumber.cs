using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Reversenumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                Reverse = (Reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is : {0}", Reverse);
            Console.ReadLine();
        }
    }
}
