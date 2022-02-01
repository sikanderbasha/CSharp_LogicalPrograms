using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Perfectnumber
    {      
        public void Perfect()
        {
            int total = 0;
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    total += i;
            }
            if (total == number)
                Console.Write("{0} is a perfect number", number);
            else
                Console.Write("{0} is not a perfect number", number);
        }
    }
}
