using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Faizan Ahmed
// IT330 - Project 1: Console Application Mortgage Calculator
// Date: 3/30/2016

namespace Proj1_Ahmed
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating local variables
            Double _principal = 0.0, _rate = 0.0, _year = 0.0;
            Boolean running = true;
            string _input = ""; 

            //if input doesn't equal exit then continue 
            while (_input.ToLower() != "exit")
            {

                //converting the principal string variable to double and validating error
                while (running)
                {
                    Console.Write("Enter the Principal Amount: ");
                    string str_principal = Console.ReadLine();

                    //_principal = Double.Parse(str_principal);
                    if (Double.TryParse(str_principal, out _principal))                  
                        break;
                    else
                        Console.WriteLine("Error. Principal should be a Double Value! ");
                }

                //converting the year string variable to integer and validating error
                while (running)
                {
                    Console.Write("Enter the Number of Years: ");
                    string str_year = Console.ReadLine();

                    if (Double.TryParse(str_year, out _year))
                        break;
                    else
                        Console.WriteLine("Error. Year should be a Double Value! ");
                }

                //converting the rate string variable to double and validating error
                while (running)
                {
                    Console.Write("Enter the Interest Rate: ");
                    string str_rate = Console.ReadLine();

                    if (Double.TryParse(str_rate, out _rate))
                        break;
                    else
                        Console.WriteLine("Error. Rate should be a Double Value! ");
                }

                //breakdown computation of the monthly mortgage payment formula
                double rate_div = (_rate / 1200.0);
                double rate_pow = Math.Pow((1.0 + rate_div), -12.00 * _year);

                double mortgage_h1 = (_principal * rate_div);
                double mortgage_h2 = (1 - rate_pow);

                //final computation and output 
                double compute_mortgage = mortgage_h1 / mortgage_h2;
                Console.WriteLine("Payment Amount: " + Math.Round(compute_mortgage, 2));

                //prompt asking user to continue or exit
                Console.WriteLine("Press any key to continue. Enter exit to close program.");
                _input = Console.ReadLine();

            } //end of while loop
        }
    }
}