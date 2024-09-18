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
    
    // Rules for Rock,Paper, and scissors game
    Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.\n The winner scores a point. If each player picks the same no points are awarded.\n The first player to five points wins.\n")
    // User inputs their name
    Console.WriteLine("Your player name is")
    Console.ReadLine();
    
    // CPU chioce is chosen at random 
    Random rnd = new Random(); 
    int cpuChoice = rnd.Next(4);

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