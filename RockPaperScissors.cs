using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Rock, Paper, or Scissors?");
        string user_choice = Console.ReadLine();
        
        if(user_choice == "Rock")
        {
            string comp_choice = getCompChoice();
            if (comp_choice == "Rock" )
            {
                ret_msg = "You both chose Rock! Tie Game!"
            }
        }
        Console.WriteLine(ret_msg);
        Console.ReadLine();
        }
    }
}
