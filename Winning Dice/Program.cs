using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winning_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Roll: {roll1} + {roll2} + {roll3} = {total}");
            
            if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! You get + 2 bonus to total");
                total += 2;
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! You get + 6 bonus to total");
                total += 6;
            }
            if(total >= 15)
            {
                Console.WriteLine("You win!");
            }
            if(total >= 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
            Console.ReadLine();
        }
    }
}
