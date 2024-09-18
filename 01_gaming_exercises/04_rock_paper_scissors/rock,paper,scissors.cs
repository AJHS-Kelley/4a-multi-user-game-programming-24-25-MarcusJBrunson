using System;
class Template {
  static void Main() {

    string playerName = "TestPlayer";
    int playerScore;
    int cpuScore;
    int playerChoice;
    int cpuChoice;
    int rock = 0;
    int paper = 1;
    int scissors = 2;
    // Rules for the Rock,Paper, and scissors games
    Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.\n The winner scores a point. If each player picks the same no points are awarded.\n The first player to five points wins.\n")
    Console.WriteLine("Your player name is")
    Console.ReadLine();

    Random rnd = new Random(); 
    int cpuChoice = rnd.Next(4);

  while (playerScore || cpuScore != 5)
    {
      Console.WriteLine("Please select rock, paper, or scissors);

       if(playerChoice = rock && cpuChoice = scissors)
       {
          Console.WriteLine("Rock beat Scissors.");
          playerScore++; 
      }
       else if (playerChoice = paper && cpuChoice = rock) 
       {
         Console.WriteLine("Paper beat Rock.");
         playerScore++;
       }
       else if (playerChoice = scissors && cpuChoice = paper)
       {
         Console.WriteLine("Scissors beat Paper.");
         playerScore++;
       }

       }

     }



  }