using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;
using System;

namespace RPS.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void RockPaperScissors_WinCheck_Player1()
    {
      //Arrange 
      RockPaperScissors newPlay = new RockPaperScissors();
      // Act
      string result = newPlay.WinCheck("R", "S");
      // Assert
      Assert.AreEqual("Player 1 Wins!", result);
    }
    [TestMethod]
    public void RockPaperScissors_WinCheck_Draw()
    {
      // Arrange
      RockPaperScissors newPlay = new RockPaperScissors();
      // Act
      string result = newPlay.WinCheck("R", "R");
      // Assert
      Assert.AreEqual("Draw! Play again.", result);
    }
    // [TestMethod]
    // public void RockPaperScissors_CheckInput_False()
    // {
    //   // Arrange
    //   RockPaperScissors newPlay = new RockPaperScissors();
    //   // Act
    //   bool result = newPlay.CheckInput("!","k");
    //   // Assert
    //   Assert.AreEqual(false, result);

    // }
  }
}