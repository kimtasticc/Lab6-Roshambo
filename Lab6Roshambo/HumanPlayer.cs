using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Roshambo
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo HumanRoshambo = 0;

            do
            {
                Console.WriteLine("\nSelect your hand choice by selecting: 'ROCK', 'PAPER', or 'SCISSORS'");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "ROCK")
                {
                    HumanRoshambo = Roshambo.Rock;
                }
                else if (choice == "PAPER")
                {
                    HumanRoshambo = Roshambo.Paper;
                }
                else if (choice == "SCISSORS")
                {
                    HumanRoshambo = Roshambo.Scissors;
                }
                else
                {
                    Console.WriteLine("That's an invalid selection. Try again.");
                }
            } while (HumanRoshambo == 0);

            this.RoshamboMove = HumanRoshambo;
            return HumanRoshambo;
        }
    }
}
