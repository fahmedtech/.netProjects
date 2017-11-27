using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Name: Faizan Ahmed
IT330 - Project 3 (Console Application)
Vending Machine Test File
Date: 4/20/2016
*/

namespace Proj3_Ahmed
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();

            Console.WriteLine(vm.ToString());

            Console.WriteLine("BUYING FIRST CANDYBAR!");
            //Trying to buy all of the 1st Candybars. However, it has only 7 Candybars.
            //The 7th time it will not be successful. Candybar requires 3 quarters for Dispense. 
            for (int i=0; i <= 7; i++)
            {
                for(int j=1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(0)); //_numCandyBars[0]
                Console.WriteLine(vm.ToString());
            }

            Console.WriteLine("BUYING SECOND CANDYBAR!");
            //Testing to buy some of the 2nd Candybars.
            for(int i=0; i <= 4; i++)
            {
                for(int j=1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy(1));
                Console.WriteLine(vm.ToString());
            }
            

            Console.ReadLine();
        }
    }
}
