using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice between 1 & 2 : ");
            Console.WriteLine("1 For: Fibonacci series. ");
            Console.WriteLine("2 For: Perfect number. ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //Fibonacci Series
                    Fibonacciseries FibSeries = new Fibonacciseries();
                    FibSeries.Fibonacci();
                    break;
                case 2:
                    //Perfect Number
                    Perfectnumber Perfect = new Perfectnumber();
                    Perfect.Perfect();
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
