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
    { // private instance variables
        private int _numQuarters;
        private int[] _numCandyBars;

        // Public noarg constructor
        public VendingMachine()
        {
            // Set the candy bar cost in quarters.  
            _numQuarters = 3;

            // Set initial number of candy bars.
            _numCandyBars = new int[3];

            _numCandyBars[0] = 7;
            _numCandyBars[1] = 8;
            _numCandyBars[2] = 6;
        }

        // Public read only properties:
        public int NumQuarters
        {
            get { return _numQuarters; }
        }

        // Public Methods:

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

        public string DepositQuarter()
        {
            _numQuarters++;
            return "Quarter deposited.";
        }

        //String Method: Selecting Candy from array
        public string SelectCandy(int CandyID)
        {
            string retValue = "";

            for (int i = 0; i < _numCandyBars.Length; i++)
            {
                if (_numQuarters >= 3 && _numCandyBars[CandyID] > 0)
                {
                    _numQuarters -= 3;
                    _numCandyBars[CandyID]--;
                    return "Candy Bar Dispensed";
                }
                else if (_numCandyBars[CandyID] > 0)
                    retValue = "Not enough quarters to buy Candy Bar.";
                else
                    retValue = "No Candy Bars in Machine.";
            }
            return retValue;
        }

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
