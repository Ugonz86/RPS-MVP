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
      Console.WriteLine("To start, enter 0 for Rock, 1 for Paper and 2 for Scissors");
      string userInput = Console.ReadLine();

      Console.WriteLine("You chose "+ Options[int.Parse(userInput)] +" !");

      string cpuOutput = Choices.cpuChoice();
      Console.WriteLine("Your opponent chose "+ Options[int.Parse(cpuOutput)] +" !");

      Choices.compareChoices(userInput, cpuOutput);

      Main();
    }
  }
}
