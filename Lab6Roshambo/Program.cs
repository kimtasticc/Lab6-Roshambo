using Lab6Roshambo;


bool playAgain = false;

do
{
    playAgain = false;
    Console.WriteLine("ROCK. PAPER. SCISSORS.");
    Console.WriteLine("\nEnter your name: ");
    string name = Console.ReadLine();

    Player player = new HumanPlayer(name);
    Player player2 = null;


    do
    {
        Console.WriteLine("\nSelect your opponent: ROCK or RANDOM");
        string opponent = Console.ReadLine();

        if (opponent.ToUpper() == "ROCK")
        {
            player2 = new RockPlayer();
        }
        else if (opponent.ToUpper() == "RANDOM")
        {
            player2 = new RandomPlayer();
        }
        else
        {
            Console.WriteLine("That's an invalid selection. Try again.");
        }
    } while (player2 == null);
    
    player.GenerateRoshambo();
    player2.GenerateRoshambo();

    Console.WriteLine($"\n{player.Name} chose {player.RoshamboMove} and your opponent chose {player2.RoshamboMove}");

    if (player.RoshamboMove == player2.RoshamboMove)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (player.RoshamboMove == Roshambo.Rock)
    {
        if (player2.RoshamboMove == Roshambo.Scissors)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose :(");
        } 
    }
    else if (player.RoshamboMove == Roshambo.Paper)
    {
        if (player2.RoshamboMove == Roshambo.Rock)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose :(");
        }
    }
    else if (player.RoshamboMove == Roshambo.Scissors)
    {
        if (player2.RoshamboMove == Roshambo.Paper)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose :(");
        }
    }

    Console.WriteLine("\nDo you want to play again? (Y/N)");
    if (Console.ReadLine().ToUpper() == "Y")
    {
        playAgain = true;
    }
} while (playAgain);