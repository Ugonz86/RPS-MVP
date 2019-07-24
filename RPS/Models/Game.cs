using System;
using System.Collections.Generic;

namespace RPS
{

  class Choices
  {
    private static Random rnd = new Random();
    //array of Choices
    private static List<string> win = new List<string>(){"02", "10","21"};
    private static List<string> tie = new List<string>(){"00","11","22"};


    //computer picks an Option
    public static string cpuChoice()
    {
        int selector = rnd.Next(0,3);
        return selector.ToString();
    }
    //comparison Method
    public static void compareChoices(string userInput, string cpuMove)
    {
      string result = userInput+cpuMove;
      if (win.Contains(result))
      {
        Console.WriteLine("You win!");
      } else if (tie.Contains(result))
      {
        Console.WriteLine("It's a tie!");
      } else
      {
        Console.WriteLine("The Computer Wins!");
      }
    }
  }
}
