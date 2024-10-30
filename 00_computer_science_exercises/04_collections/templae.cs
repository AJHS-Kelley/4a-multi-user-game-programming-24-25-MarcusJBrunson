using System;
class Collections {
  static void Main() { // DO NOT DELETE!


  // Declaring and defending an array 
  string [] breakfastfoods = {"Bacon", "Eggs", "Cold Pizza", "Apple jacks", "Oatmeal"};
  int[] testscore = {0, 25, 15, 75, 99};
  double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

  // Print Array Contents
  Console.WriteLine("The elements of each array are;\n");
  Console.WriteLine("breakfastfoods:\n" + String.Join(",", breakfastfoods));
  Console.WriteLine(); // Print an empty line to the screen

  // Print Array Contents
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakfastfoods:\n" + String.Join("\n", breakfastfoods));
  Console.WriteLine(); // Print an empty line to the screen

  // How long is my array? DETERMING ARRAY LENGTH
  Console.WriteLine("The length of the breakfastfoods array is: " + breakfastfoods.Length);
  // .Length is known as PROPERTY of the array

  // Acessing Elements in the array with the index.
  Console.WriteLine("The first element in breakfastfoods is: " + breakfastfoods[0]);
  Console.WriteLine("The second element in testscores is: " + testscore[1]);
  Console.WriteLine("The thrid element in GPA is: " + GPA[2]);


    } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LRFT MARGIN