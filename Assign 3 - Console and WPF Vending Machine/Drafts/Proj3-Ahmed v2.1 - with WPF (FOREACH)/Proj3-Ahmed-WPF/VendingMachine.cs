using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//USING FOREACH TO LOOP THROUGH OBJECTS

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
            _numQuarters = 0;

            //setting the initial number for the (three) different candy bars.
            _numCandyBars = new int[3];

            _numCandyBars[0] = 3;
            _numCandyBars[1] = 6;
            _numCandyBars[2] = 9;
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
            int count = 0;

            foreach(int i in _numCandyBars)
            {
                if (count == CandyID)
                    temp = i; //_numCandyBars[count];
                count++;
            }

           /* for (int i = 0; i < _numCandyBars.Length; i++)
            {
                if (i == CandyID)
                    temp = _numCandyBars[i];
            }*/
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
            string output = "";
            int count = 0; 
            foreach(int i in _numCandyBars)
            {
                if (_numQuarters >= 3 && _numCandyBars[CandyID] > 0)
                {
                    _numQuarters -= 3;
                    _numCandyBars[CandyID]--;
                    return "Candy Bar Dispensed";
                }
                else if (_numCandyBars[CandyID] > 0)
                {
                    output = "Not enough quarters to buy Candy Bar.";
                }
                else
                {
                    output = "No Candy Bars in Machine.";
                }
             count++;
            }
            return output;
            
        }

        //Override ToString() Method: returns string of Array with values
        public override string ToString()
        {
            string output = "";
            int count = 0;

            foreach(int i in _numCandyBars)
            { 
                output += "Candybar: " + count + " Total Quarters: " + _numQuarters + " Total Bars: " + i; 
                // NumCandyBars(count) + "\n";
                count++;
            }
            /*
            for (int i = 0; i < _numCandyBars.Length; i++)
            {
                output += String.Format("Candybar {0}-- Total Quarters: {1} Total Bars: {2}. \n",
                                        i, _numQuarters, NumCandyBars(i));
            }*/
            return output;
        }
    }
}
