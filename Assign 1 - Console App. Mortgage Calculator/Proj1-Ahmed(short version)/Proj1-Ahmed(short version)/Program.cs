using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_Ahmed_short_version_
{
    class Program
    {
        static void Main(string[] args)
        {

            double _principal = 0.0, _rate = 0.0;
            int _year = 0;
            string _input = "";

            while(_input != "exit")
            {
                Console.Write("enter principal: ");
                string str_prin = Console.ReadLine();

                Console.Write("enter year: ");
                string str_year = Console.ReadLine();

                Console.Write("enter rate: ");
                string str_rate = Console.ReadLine();

                if (Double.TryParse(str_prin, out _principal) && Int32.TryParse(str_year, out _year)
                    && Double.TryParse(str_rate, out _rate))
                {
                    /*
                    _principal = Double.Parse(str_prin);
                    _year = Int32.Parse(str_year);
                    _rate = Double.Parse(str_rate); */

                    double rate_div = (_rate / 1200.0);
                    double rate_pow = Math.Pow((1.0 + rate_div), -12.00 * _year);

                    double mortgage_h1 = (_principal * rate_div);
                    double mortgage_h2 = (1 - rate_pow);

                    double compute_mortgage = mortgage_h1 / mortgage_h2;
                    Console.WriteLine("Payment Amount: " + Math.Round(compute_mortgage, 2));
                }

                else
                    Console.WriteLine("Please enter valid input!");


                // Console.WriteLine("Press any key to continue. Enter exit to close program.");

                ColoredConsoleWrite(ConsoleColor.Red, "Press any key to continue. Enter exit to close program. ");
                _input = Console.ReadLine();

            }//end of while loop
        }


        //changes the console color of the string text
        public static void ColoredConsoleWrite(ConsoleColor color, string text)
        {
            ConsoleColor original_color = Console.ForegroundColor; //WHITE
            Console.ForegroundColor = color; //new COLOR

            Console.Write(text);

            Console.ForegroundColor = original_color; //WHITE again

        }
    }
}
