using System;
using System.Collections.Generic;

namespace RPS
{

  class Choices
  {
    private static Random rnd = new Random();
    //array of Choices
    private static List<string> win = new List<string>(){"13", "21","32"};
    private static List<string> tie = new List<string>(){"11","22","33"};


    //computer picks an Option
    public static string cpuChoice()
    {
        int selector = rnd.Next(1,4);
        return selector.ToString();
    }
    //comparison Method
    public static void compareChoices(string userInput, string cpuMove)
    {
      string result = userInput+cpuMove;
      if (win.Contains(result))
      {
        Console.WriteLine("\nPlayer 1 wins!\n");
      } else if (tie.Contains(result))
      {
        Console.WriteLine("\nIt's a tie!\n");
      } else
      {
        Console.WriteLine("\nPlayer 2 Wins!\n");
      }
    }
  }
}
