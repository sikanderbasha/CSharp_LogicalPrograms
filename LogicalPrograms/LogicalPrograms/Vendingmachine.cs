using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Vendingmachine
    {
        public void Money()
        {
            Console.WriteLine("Enter the money :");
            int money = Convert.ToInt32(Console.ReadLine());
            vending(money);
        }
        public static void vending(int money)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count = new int[notes.Length];

            for (int i = 0; i < notes.Length; i++)
            {
                if (money >= notes[i])
                {
                    count[i] = money / notes[i];
                    money = money - count[i] * notes[i];
                }
            }

            Console.WriteLine("Notes :");
            int number = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                    + count[i]);
                    number += count[i];
                }
            }
            Console.WriteLine("Total notes : " + number);
        }
    }
}
