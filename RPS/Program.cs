using System;
using System.Collections.Generic;

namespace RPS
{
  class Game
  {
    public static void Main()
    {
      List<string> Options = new List<string>(){"Rock" , "Paper", "Scissors"};

      Console.WriteLine("Welcome to the Rock-Paper-Scissors Game!");
      Console.WriteLine("Are you playing against a friend or the computer?");
      string gameMode = Console.ReadLine();
      Console.WriteLine("Alright! \n");
      if (gameMode == "computer")
      {
        Console.WriteLine("To start, enter 1 for Rock, 2 for Paper and 3 for Scissors");
        string userInput = Console.ReadLine();

        Console.WriteLine("You chose "+ Options[int.Parse(userInput)-1] +" !");

        string cpuOutput = Choices.cpuChoice();
        Console.WriteLine("Your opponent chose "+ Options[int.Parse(cpuOutput)-1] +" !");

        Choices.compareChoices(userInput, cpuOutput);
      } else
      {
        Console.WriteLine("\nPlayer 1: Choose 1 for Rock, 2 for Paper and 3 for Scissors");
        //this next block hides the user input whilst they type
        string playerOne = null; //hides string input
        while (true)
        {
            var key = System.Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) //once enter is pressed, stores value of string input
                break;
            playerOne += key.KeyChar;
        }

        Console.WriteLine("\nPlayer 2: Choose 1 for Rock, 2 for Paper and 3 for Scissors");
        string playerTwo = null;
        while (true)
        {
            var key = System.Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                break;
            playerTwo += key.KeyChar;
        }
        Console.ForegroundColor = ConsoleColor.DarkRed; // changes console text color to chosen value 'DarkRed'
        Console.WriteLine("\nPlayer 1 chose: " + Options[int.Parse(playerOne)-1]);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nPlayer 2 chose: " + Options[int.Parse(playerTwo)-1]);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Choices.compareChoices(playerOne, playerTwo);
        Console.ResetColor(); //Resets Console Color to default [black]
      }
      Main();
    }
  }
}
