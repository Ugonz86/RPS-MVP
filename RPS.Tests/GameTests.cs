using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class ChoicesTest
  {
    [TestMethod]
    public void cpuChoice_RandomNumberToString_ResultString()//methodName_summary_expectedResult
    {
      Random rnd = new Random();
      string result = Choices.cpuChoice();
      Assert.AreEqual(result, result.ToString()); //testing to see if result is a string
    }
    // [TestMethod]
    // public void compareChoices_TestChoiceComparison_PlayerWins()
    // {
    //   string cpuMove = "1"; //setting number for the sake of testing
    //   string userInput = "2"; //setting number for the sake of testing
    //   int result = Choices.compareChoices(userInput,cpuMove);
    //   Assert.AreEqual(result, 1); //1 is temporary "player win" value
    // }
  }
}
