using System;

namespace RPS.Models
{
  public class RockPaperScissors
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }

    public void Play(string player1Answer, string player2Answer)
    {
      Player1 = player1Answer;
      Player2 = player2Answer;
    }

    public string WinCheck(string player1Answer, string player2Answer)
    {

      if (player1Answer == player2Answer)
      {
        return "Draw! Play again.";
      }
      else if ((player1Answer == "R" && player2Answer == "S") || (player1Answer == "P" && player2Answer == "R") || (player1Answer == "S" && player2Answer == "P"))
      {
        return "Player 1 Wins!";
      }
      else
      {
        return "Player 2 Wins!";
      }
    }
  }
}
