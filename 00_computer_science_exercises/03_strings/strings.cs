using System;
class Strings {
  static void Main() {
    // In C# ALL STRINGS MUST USE DOUBLE-QUOTES " "

    string greeting = "Hello, how are you? Nice weather we got don't you think?\n";
    string goodbye = "See you later alligator.\n";

    // In C# strings are treated like an OBJECT that has properties and methods. 
    // PROPERTIES -- things that describe the object such as length, values, data type, etc. 
    // METHODS -- built in functions related to that object

    // Length is an important property for strings. 
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if(greeting.Length > goodbye.Length)
    {
      Console.WriteLine("The greeting has more characters than the goodbye.\n");
    }

      // Useful String Methods 

      Console.WriteLine(greeting.ToUpper()); // Make entrie string UPPERCASE
      Console.WriteLine(greeting.ToLower()); // Make entrie string lowercase

      // String Concatenation "Con-Cat-Uh-Nation"
      string comboString = greeeting + goodbye;
      Console.WriteLine(comboString);

      // String Concatenation Method #2
      string comboString2 = string.Concat(greeting, goodbye);
      Console.WriteLine(comboString2);

      String Interpolation -- Subtituting variables into strings 
      string combostring3 = $"My greeting is {greeting} and my goodbye is {goodbye}.\n";
      Console.WriteLine(combostring3);

      // Subtituting Variables into Strings Method 2
      Console.WriteLine("My greeting is " + greeting + "and my goodbye is " + goodbye ".\n"); 

      // Accessing Parts of Strings
      // index is a specific location of each character in a string
      // ALL string indexes start at 0
      Console.WriteLine(goodbye[0]); // Print the character at index 0.
      Console.WriteLine(goodbye[4]);

      // Where is it in my string? 
      Console.WriteLine(greeting.IndexOf("y"));

     
    
      
  }

}