using System;
class Template {
  static void Main() {
    // PLAYER VARIABLES
    string playerName = "TestPlayer";
    int playerScore;
    int playerChoice;

     // CPU VARIABLES
    int cpuScore;
    int cpuChoice;

    // int rock = 0;
    // int paper = 1;
    // int scissors = 2;

    // User inputs their name
    Console.WriteLine("Welcome to the rock paper, scissors bot!\n");
    Console.WriteLine("Please type your player name and press ENTER.\n");
    playerName = Console.ReadLine();
    Console.WriteLine($"Hello {playerName}. is that correct?\n");
    Console.WriteLine("Please type yes or no, then press enter.\n");
    string isCorrect = Console.ReadLine().ToLower();

    if (isCorrect == "yes")
    {
      Console.WriteLine($"Great! I'll call you {playerName}.\n");
    }
    else if (isCorrect == "no")
    {
      Console.WriteLine("Please type your player name and press ENTER.\n");
      playerName = Console.ReadLine();
    }
    else
    {
      Console.WriteLine("Unable to determine your answer. Try again.\n");
    }

    // Rules for Rock, Paper, and scissors game
    You will select from rock paper or Scissors.
    The CPU will select one of those choices at random. 
    Then a winner will be determined using the following rules
    Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.\n The winner scores a point. If each player picks the same no points are awarded.\n The first player to five points wins.\n");


  while (playerScore || cpuScore != 5)
    {
      Console.WriteLine("Please select rock, paper, or scissors.\n");

       if(playerChoice = rock && cpuChoice = scissors)
       {
          Console.WriteLine("Rock beat Scissors.\n");
          Console.WriteLine("Player has won.\n");
          playerScore++;
      }
       else if (playerChoice = paper && cpuChoice = rock) 
       {
         Console.WriteLine("Paper beat Rock.\n");
         COnsole.WriteLine("Player has won.\n");
         playerScore++;
       }
       else if (playerChoice = scissors && cpuChoice = paper)
       {
         Console.WriteLine("Scissors beat Paper.\n");
         Console.WriteLine("Player has won.\n");
         playerScore++;
       }

       if(cpuChoice = rock && playerChoice = scissors)
       {
          Console.WriteLine("Rock beat Scissors.\n");
          Console.WriteLine("CPU has won.\n");
          cpuScore++; 
      }
       else if (cpuChoice = paper && playerChoice = rock) 
       {
         Console.WriteLine("Paper beat Rock.\n");
         Console.WriteLine("CPU has won.\n");
         cpuScore++;
       }
       else if (cpuChoice = scissors && playerChoice = paper)
       {
         Console.WriteLine("Scissors beat Paper.\n");
         Console.WriteLine("CPU has won.\n");
         cpuScore++;
       }

       }
     }

  }