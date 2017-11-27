using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PRACTICE NEW EXAMPLE

namespace Proj3_Ahmed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the VendingMachine Class Object.
            VendingMachine vm = new VendingMachine();
            Console.WriteLine(vm.ToString()); //Testing ToString() method.

            Console.WriteLine("Candybar 1");
            DepositAndBuyLoop(0, 3, 3);

            Console.WriteLine("Candybar 2");
            DepositAndBuyLoop(1, 4, 3);

            Console.WriteLine("Candybar 3");
            DepositAndBuyLoop(2, 5, 3);

            //Keep the Console Window Open.
            Console.ReadLine();
        }

        public static void DepositAndBuyLoop(int CandyIndex, int CandyAmount, int Quarters)
        {
            VendingMachine vm = new VendingMachine();
            for (int i = 1; i <= CandyAmount; i++)
            {
                for (int j = 1; j <= Quarters; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(CandyIndex));
                Console.WriteLine(vm.ToString());
            }
        }//end of the method
    }
}


//UNUSED TRASHED CODES


/*
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(vm.DepositQuarter());
    }
    Console.WriteLine(vm.SelectCandy(0)); //_numCandyBars[0]
    Console.WriteLine(vm.ToString());
}

                //Testing to buy only 5 of the 2nd Candybars. 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(1)); //_numCandyBars[1]
                Console.WriteLine(vm.ToString());
            }

                for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(2)); //_numCandyBars[2]
                Console.WriteLine(vm.ToString());
            }

*/
