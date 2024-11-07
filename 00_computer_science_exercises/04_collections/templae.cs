using System;
using System.Linq;
using System.Collections;
class Collections {
  static void Main() { // DO NOT DELETE!



  /*
  In C# an collection is an ARRAY
  -- Each ITEM IN THE ARRAY IS AN ELEMENT 
  -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED 
  -- CONTENTS OF EACH ELEMENT CAN CHANGE 
  -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION 
  -- POSITION OF THE ELEMENT IS THE INDEX 
  -- FIRST ELEMENT INDEX IS 0.
  */

  // Declaring and defending an array 
  // string [] breakfastFoods = {"Bacon", "Eggs", "Cold Pizza", "Apple jacks", "Oatmeal"};
  // int[] testScores = {0, 25, 15, 75, 99};
  // double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

  // Print Array Contents
  // Console.WriteLine("The elements of each array are;\n");
  // Console.WriteLine("breakfastFoods:\n" + String.Join(",", breakfastFoods));
  // Console.WriteLine(); // Print an empty line to the screen
  /*
  // Print Array Contents
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakfastFoods:\n" + String.Join("\n", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen

  // How long is my array? DETERMING ARRAY LENGTH
  Console.WriteLine("The length of the breakfastFoods array is: " + breakfastFoods.Length);
  // .Length is known as PROPERTY of the array

  // Acessing Elements in the array with the index.
  Console.WriteLine("The first element in breakfastFoods is: " + breakfastFoods[0]);
  Console.WriteLine("The second element in testScores is: " + testScores[1]);
  Console.WriteLine("The thrid element in GPA is: " + GPA[2]);

  // Shortcut to Access Last item in an Array 
  // Console.WriteLine("The last element of breakfastFoods is: " + breakfastFoods[breakfastFoods.Length -1]);
  // Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length -1]);

  // CHANGING ELEMENTS IN THE ARRAY
  breakfastFoods[2] = "Frosted Flakes";
  testScores[0] = -5;
  GPA[1] = 1.3;
  Console.WriteLine("The elements of each array are;\n");
  Console.WriteLine("breakfastFoods:\n" + String.Join(",", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen
  */
  
  // Common erros with arrays 
  // Console.WriteLine(breakfastFoods[99]); // Index out of bounds -- Accessing index that does not exist in the array.

  // testScores[0] = "99"; // Error: Message "Cannot implicitly convert dataType to dataType"
  // Trying to put incorrect data type into the array.

  // COMMON ARRAY METHODS -- Ways to work with the array data.
  // Sorting an Array
  // int[] intArr = {-25, 50, 68, 523, -1205, 99918582, -1, 55, 0, 124};
  // string[] zooanimals = {"Tiger", "Lion", "Monkey", "Zebra", "Iguana"};

  // Array.Sort(intArr);
  // Array.Sort(zooanimals);
  // Array.Sort will sort string arrays ALPHABETICALLY A-Z and numerical arrays from LEAST to GREATEST
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("zooanimals:\n" + String.Join("\n", zooanimals));
  // Console.WriteLine(); // Print an empty line to the screen

  // Finding the MIN, MAX, and SUM for numerical arrays.
  // Console.WriteLine("The Minium value for intArr is: " + intArr.Min());
  // Console.WriteLine("The MAXIUM value for intArr is: " + intArr.Max());
  // Console.WriteLine("The SUM value for intArr is: " + intArr.Sum());

  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("intArr:\n" + String.Join("\n", intArr));
  // Console.WriteLine(); // Print an empty line to the screen

   // Array list --> Basically an array you can add/Remove elements from. 
   var exampleArrList = new ArrayList(); // Create an new ArrayList.
   // Adding elements to an ArrayList use .Add()
   exampleArrList.Add(5);
   exampleArrList.Add("STAR WARS REVENGE OF THE SITH");
   exampleArrList.Add(false);
   exampleArrList.Add(1.25D);

   // Create ArrayList with Values
   vae exampleArrList2 = new ArrayList()
    {
      -10, "Last Name", "Purple", false, 25.25D, 195000, 0.0D
    }; 

    // Console.WriteLine(exampleArrList[2]);
    // Console.WriteLine(exampleArrList2[5]);

    // Inserting to a specific position in the arrayList 
    // use .Insert(index, value)
    // exampleArrList.Insert(3, "Ogres are like onions.\n");
    // exampleArrList.Insert(0, -99);

    // .Remove(value) Removes the first OCCURENCE of the item from the ArrayList
    var newList = new ArrayList()
    {
      -10, 10, 15, -25, -10, 25, 33, -25, 40
    };
  // Console.WriteLine(newList[0]);
  // newList.Remove(-10);
  // Console.WriteLine(newList[0]);

  // Deleting based on index number
  // RemoveAt(value) --> deletes the item at the specified index
  // newList.RemoveAt(4);

  // Delete the first item 
  // newList.RemoveAt(0);

  // Delete the last item
  // newList.RemoveAt(newList-Length - 1);

  // Remove an entire range of elements.
  // .RemoveRange(firstIndex, lastIndex)
  // newList.RemoveRange (3, 8)

  // Shortcut to Delete from one item through end of list.
  // newList.RemoveRange(4, newList.Length - 1);

  // Does the arrayList contain a certain value.
  // Contains (value) returns ture if the list has that value, false otherwise.
  var playerInventory = new ArrayList()
    {
    "Sword", "Shield", "Bazooka", "1-up Power-up", "Death notebook", "Potato"
    };

  Console.WriteLine(playerInventory.Contains("Fishing pole"));
  Console.WriteLine(playerInventory.Contains("Sword"));

  if (playerInventory.Contains("Blue Key"))
  {
    // Do Something
  }


    } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LRFT MARGIN