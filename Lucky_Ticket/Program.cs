using System;
using System.Text.RegularExpressions;

namespace Lucky_Ticket
{
    class Program
    {
        static void LuckChecker(string ticket) {
            char[] ticketChar = ticket.ToCharArray();
            int firstHalf=0;
            int secondHalf=0;
            for (int i = 0; i < ticket.Length / 2; i++)
            {
                firstHalf = firstHalf + Convert.ToInt32(new string(ticketChar[i], 1));
                
            };
            for (int i = ticket.Length / 2; i < ticket.Length ; i++)
            {
                secondHalf = secondHalf+  Convert.ToInt32(new string(ticketChar[i], 1));
                
            };
            if(firstHalf == secondHalf)
            {
                Console.WriteLine("Winner");
            }
            else
            {
                Console.WriteLine("Loser");
            };
            
        }

        static void LuckMain(Regex regex)
        {


            Console.WriteLine("Type number of your ticket");
            string ticket = Console.ReadLine();
            MatchCollection matches = regex.Matches(ticket);
            if (matches.Count > 0)
            {
                    Console.WriteLine("Type rigth  , only numbers");
            }
            else
            {



                if (ticket.Length >= 4 && ticket.Length <= 8)
                {


                    if (ticket.Length % 2 == 0)
                    {
                        LuckChecker(ticket);
                    }
                    else
                    {
                        LuckChecker(ticket + "0");
                    }
                }
                else
                {
                    Console.WriteLine("Type rigth , length of the number must be in range from 4 to 8 ");
                };
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();

               
            }
            LuckMain(regex);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Regex regex = new Regex("[A-z]");
            LuckMain(regex);

        }
    }
}
