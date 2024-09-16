using System;
class Template {
  static void Main() {

  string playerName = "TestPlayer";
  int playerScore;
  int cpuScore;
  int rock = 0;
  int paper = 1;
  int scissors = 2;
  Console.WriteLine("Your player name is " + playerName);
  Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.\n The winner scores a point. If each player picks the same no points are awarded.\n The first player to five points wins.\n")

  while (playerScore )
    {
      // Console.WriteLine("Secret Number:" + secretNumber);
      Console.WriteLine("Please guess an integer between 0 and 99.\n");
      guess = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Guess" + guess);

      numGuess++;
      if(guess < secretNumber)
      {
        Console.WriteLine("Your guess is too low.\n");
      }
      else if (guess > secretNumber) 
      {
        Console.WriteLine("Your guess is too high.\n");
      }
      else
      {
        Console.WriteLine("You guessed correctly!.\n");
        break; // Keyword to immeditaely exit a loop.
      }

      if (numGuess > maxGuess)
      {
        Console.WriteLine("You have lost the game.\n your grandparents are dissapointed in you.\n");
      }

    }



  }
}