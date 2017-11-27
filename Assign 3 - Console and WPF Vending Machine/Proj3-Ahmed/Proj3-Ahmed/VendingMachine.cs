using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Name: Faizan Ahmed
IT330 - Project 3 (Console Application)
Vending Machine Class File
Date: 4/20/2016
*/

namespace Proj3_Ahmed
{
    public class VendingMachine
    { 
        //Private instance variables
        private int _numQuarters;
        private int[] _numCandyBars;

        //Public noarg constructor
        public VendingMachine()
        {
            //setting the value for candy bar cost in quarters.  
            _numQuarters = 3;

            //setting the initial number for the (three) different candy bars.
            _numCandyBars = new int[3];

            _numCandyBars[0] = 7;
            _numCandyBars[1] = 8;
            _numCandyBars[2] = 6;
        }

        //Public read only properties:
        public int NumQuarters
        {
            get { return _numQuarters; }
        }

        //Public Methods:

        //Int Method: Returns the number of Candies in array.
        public int NumCandyBars(int CandyID)
        {
            int temp = 0;

            for (int i = 0; i < _numCandyBars.Length; i++)
            {
                if (i == CandyID)
                    temp = _numCandyBars[i];
            }
            return temp;
        }

        //String Method: Returns string message when deposit Quarters.
        public string DepositQuarter()
        {
            _numQuarters++;
            return "Quarter deposited.";
        }

        //String Method: selects Candy from array using the ID
        public string SelectCandy(int CandyID)
        {
            if (_numQuarters >= 3 && NumCandyBars(CandyID) > 0)
            {
                _numQuarters -= 3;
                _numCandyBars[CandyID]--;
                return "Candy Bar Dispensed";
            }
            else if (NumCandyBars(CandyID) > 0)
                return "Not enough quarters to buy Candy Bar.";
            else
                return  "No Candy Bars in Machine.";
        }

        //Override ToString() Method: returns string of Array with values
        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < _numCandyBars.Length; i++)
            {
                output += String.Format("Candybar {0}-- Total Quarters: {1} Total Bars: {2}. \n",
                                        i, _numQuarters, NumCandyBars(i));
            }
            return output;
        }
    }
}
