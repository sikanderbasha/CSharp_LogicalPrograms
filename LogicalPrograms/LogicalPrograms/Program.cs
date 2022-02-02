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
            Console.WriteLine("Enter your choice between 1 to 5 : ");
            Console.WriteLine("1 For: Fibonacci series. ");
            Console.WriteLine("2 For: Perfect number. ");
            Console.WriteLine("3 For: Prime number. ");
            Console.WriteLine("4 For: Reverse number. ");
            Console.WriteLine("5 For: Vending machine. ");
           
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //Fibonacci Series
                    Fibonacciseries FibSeries = new Fibonacciseries();
                    FibSeries.Fibonacci();
                    break;
                case 2:
                    //Perfect number
                    Perfectnumber Perfect = new Perfectnumber();
                    Perfect.Perfect();
                    break;
                case 3:
                    //Prime number
                    Primenumber Prime = new Primenumber();
                    Prime.Prime();
                    break;
                case 4:
                    //Reverse number
                    Reversenumber Reverse = new Reversenumber();
                    Reverse.Reverse();
                    break;
                case 5:
                    //Vending machine
                    Vendingmachine machine = new Vendingmachine();
                    machine.Money();
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
