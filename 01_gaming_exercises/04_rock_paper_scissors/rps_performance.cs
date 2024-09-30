using System;
class Template {
  static void Main() {
    // PLAYER VARIABLES
    int playerScore = 0;
    string playerChoice = "";
    int numDraws = 0;

     // CPU VARIABLES
    int cpuScore = 0;
    string cpuChoice = "";

    // Testing game loop 
    int loopCount = 0;
    int loopReqs = 0; // Req / Reqs is universal abbrv for REQUEST / REQUESTS
    Console.WriteLine("How many loops do you need\nType an INTEGER and press enter.\n");
    loopReqs = Convert.ToInt32(Console.ReadLine());



  while (loopCount < loopReqs)
  {

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
      // Console.WriteLine("CPU choice" + cpuChoice);

      int playerRand = rnd.Next(0,2);

      if (playerRand == 0)
      {
        playerChoice = "rock";
      }
      else if (playerRand == 1)
      {
        playerChoice = "paper";
      }
      else if (playerRand == 2)
      {
        playerChoice = "scissors";
      }
      else
      {
        Console.WriteLine("Unable to determine CPU choice.\n");
      }
      // Console.WriteLine("player choice" + playerChoice);


      // Compare the two choices and determine a winner.
      if(playerChoice == "rock" && cpuChoice == "paper")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "scissors")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("You win.\n");
        playerScore++;
      }
      else if  (playerChoice == "rock" && cpuChoice == "rock")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("It's a draw.\n");
        numDraws++;
      }

      if(playerChoice == "paper" && cpuChoice == "scissors")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("You win.\n");
        playerScore++;
      }
      else if  (playerChoice == "paper" && cpuChoice == "paper")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("It's a draw.\n");
        numDraws++;
      }

      if(playerChoice == "scissors" && cpuChoice == "rock")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "paper")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("You win.\n");
        playerScore++;
      }
      else if  (playerChoice == "scissors" && cpuChoice == "scissors")
      {
        // Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        // Console.WriteLine("It's a draw.\n");
        numDraws++;
      }
      loopCount++;

      if (playerScore > cpuScore)
      {
        Console.WriteLine("Congratulations you are the winner!\n.");
      }
      else
      {
        Console.WriteLine("The CPU has defeated you.\n");
      }
  }

      Console.WriteLine($"Player Score: {playerScore}\n");
      Console.WriteLine($"CPU Score: {cpuScore}\n");
      Console.WriteLine($"Draws: {numDraws}\n");

       }
     }
