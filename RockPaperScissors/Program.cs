using RPS.Models;
using System.Collections.Generic;
using System;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      string p1Input = Player1Input();
      CheckInput(p1Input);
      
      
    }
    public static string Player1Input()
    {
      Console.WriteLine("Player 1: Please draw Rock [R], Paper [P], Scissors [S].");
      string p1input = Console.ReadLine();
      return p1input;
    }

    public static string Player2Input()
    {
      Console.WriteLine("Player 2: Please draw Rock [R], Paper [P], Scissors [S].");
      string p2input = Console.ReadLine();
      return p2input;
    }

    public static void WinnerWinner(string result)
    {
      if (result == "0")
      {
        Console.WriteLine("Draw! Play again.");
      }
      else if (result == "1")
      {
        Console.WriteLine("Player 1 wins!");
      }
      else if (result == "2")
      {
        Console.WriteLine("Player 2 wins!");
      }
    }

    public static void CheckInput(string player1Input)
    {
      if ( player1Input != "R" && player1Input != "P" && player1Input != "S")
      {
        Console.WriteLine("Please enter only R, P, or S.");
      }
      else
      {
        string player2Input = Player2Input();
        RockPaperScissors newPlay = new RockPaperScissors();
        string result = newPlay.WinCheck(player1Input, player2Input);
        WinnerWinner(result);
      }
    }






    // public bool CheckInput(string player1Answer, string player2Answer)
    // {
    //   if ((player1Answer == "R" || player1Answer == "S" || player1Answer == "P") && (player2Answer == "R" || player2Answer == "S" || player2Answer == "P"))
    //   {
    //     WinnerWinner()
    //   } 
    //   else 
    //   {
    //     Console.WriteLine("Please enter only Rock, Paper, or Scissor.")
    //     return false; 
    //   }
    // }
  }
}