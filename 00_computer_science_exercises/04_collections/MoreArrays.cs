using System;
using System.Linq;
using

class Template {
  static void Main() { // DO NOT DELETE!

  string[] = colors = {"Blue", "Green", "Yellow", "Purple", "Red"};
  // Looping through arrays 
  for (int i = 0; i < colors.length; i++)
  {
    Console.WriteLine(colors[i]);
  }
    
    // Looping through arrays 
    foreach (string i in colors)
    {
      Console.WriteLine(i);
    }

    // Looping through arrays practice 
    int[] numbers = {-10, 25, -345, 45, 9999, 1, 0, 68, 538, -999999};

    foreach (int i in numbers)
    {
        Console.WriteLine(i);
        if (i % 2 == 0)
      {
      Console.WriteLine("This number is even.\n");
      }
      else
      {
      Console.WriteLine("This number is odd.\n");
      }
      
    }

    // MULTIDIMENSIONAL ARRAYS
    // THIS CLASS WILL ONLY USE 2 DIMENSIONAL 
    int[,] nums = {{2, 4, 6}, {-1, 0, 1}};

    // Acessing elements in 2d arrays 
    Console.WriteLine(nums[0, 1]);
    Console.WriteLine(nums[1, 1]);

    // CHANGING ELEMENTS
    nums[1, 2] = 9001;
    // CHANGE ANY ELEMENT IN THE FIRST ARRAY
    nums[0, 1] = 500;

    // LOOPING THROUGH 2D ARRAYS
    foreach (int i in nums)
    {
      Console.WriteLine(i);
    }

    // LOOPING THROUGH 2D ARRAYS -- HARD MODE
    for (int i = 0; i < nums.GetLength(O); i++)
    {
      for (int j = 0; j < nums.GetLength(1); j++)
      {
        Console.WriteLine(nums[i, j]);
      }
    }







  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LRFT MARGIN