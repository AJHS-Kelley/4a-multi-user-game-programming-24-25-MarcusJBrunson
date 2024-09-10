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

      
      
  }

}