using System;
class Template {
  static void Main() {
    // PLAYER VARIABLES
    string playerName = "TestPlayer";
    int playerScore = 0;
    string playerChoice = "";

     // CPU VARIABLES
    int cpuScore = 0;
    string cpuChoice = "";

    string rock;
    string paper;
    string scissors;

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
    Console.WriteLine("You will select from rock paper or Scissors.\n");
    Console.WriteLine("The CPU will select one of those choices at random.\n");
    Console.WriteLine("Then a winner will be determined using the following rules.\n");
    Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.\n");
    Console.WriteLine("The winner scores a point. If each player picks the same no points are awarded.\n");
    Console.WriteLine("The first player to five points wins.\n");


  while (playerScore < 5 && cpuScore < 5)
    {
      Console.WriteLine("Please select rock, paper, or scissors. Type your answer and press ENTER.\n");
      Console.WriteLine($"Your score: {playerScore}\nCPU score: {cpuScore}/n");
      playerChoice = Console.ReadLine().ToLower();
      if (playerChoice != "rock" && playerChoice != "paper" & playerChoice != "scissors")
      {
        Console.WriteLine("Please select rock, paper, or scissors. Type your answer and press ENTER.\n");
        playerChoice = Console.ReadLine().ToLower();
      }
      // Allow CPU to select randomly
      Random rnd = new Random();
      int cpuRand = rnd.Next(0,2);

      if (cpuRand == 0)
      {
        cpuChoice = "rock";
      }
      else if (cpuRand == 1)
      {
        cpuChoice = "paper";
      }
      else if (cpuRand == 2)
      {
        cpuChoice = "scissors";
      }
      else
      {
        Console.WriteLine("Unable to determine CPU choice.\n");
      }
      Console.WriteLine("CPU choice" + cpuChoice);

      // Compare the two choices and determine a winner.
      if(playerChoice == "rock" && cpuChoice == "paper")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "scissors")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win.\n");
        playerScore++;
      }
      else if  (playerChoice == "rock" && cpuChoice == "rock")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw.\n");
      }

      if(playerChoice == "paper" && cpuChoice == "scissors")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win.\n");
        playerScore++;
      }
      else if  (playerChoice == "paper" && cpuChoice == "paper")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw.\n");
      }

      if(playerChoice == "scissors" && cpuChoice == "rock")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "paper")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win.\n");
        playerScore++;
      }
      else if  (playerChoice == "scissors" && cpuChoice == "scissors")
      {
        Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw.\n");
      }
      


      
    // My code with me trying on my own before we went over it in class.(Was not finished)
    
      //  if(playerChoice = rock && cpuChoice = scissors)
      //  {
      //     Console.WriteLine("Rock beat Scissors.\n");
      //     Console.WriteLine("Player has won.\n");
      //     playerScore++;
      // }
      //  else if (playerChoice = paper && cpuChoice = rock) 
      //  {
      //    Console.WriteLine("Paper beat Rock.\n");
      //    COnsole.WriteLine("Player has won.\n");
      //    playerScore++;
      //  }
      //  else if (playerChoice = scissors && cpuChoice = paper)
      //  {
      //    Console.WriteLine("Scissors beat Paper.\n");
      //    Console.WriteLine("Player has won.\n");
      //    playerScore++;
      //  }

      //  if(cpuChoice = rock && playerChoice = scissors)
      //  {
      //     Console.WriteLine("Rock beat Scissors.\n");
      //     Console.WriteLine("CPU has won.\n");
      //     cpuScore++; 
      // }
      //  else if (cpuChoice = paper && playerChoice = rock) 
      //  {
      //    Console.WriteLine("Paper beat Rock.\n");
      //    Console.WriteLine("CPU has won.\n");
      //    cpuScore++;
      //  }
      //  else if (cpuChoice = scissors && playerChoice = paper)
      //  {
      //    Console.WriteLine("Scissors beat Paper.\n");
      //    Console.WriteLine("CPU has won.\n");
      //    cpuScore++;
      //  }

       }
     }

  }