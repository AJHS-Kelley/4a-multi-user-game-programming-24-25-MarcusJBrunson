  // Data Types and Operarators, Marcus Brunson, v0.0
  using System;

  class DataTypesOperatores {
  static void Main() {
    
    // This is a comment, it gets ignored.

    /*
    This is still a comment
    */

    // DATA TYPES
    // C# is STATICALLY TYPED -- once a variable has a data type, it cannot change.

    // Float - float -- decimal numbers, +/- including 0.0
    // Double - double -- decimal numbers, +/- including 0.0 <-- MOSTLY COMMON USED DECIMAL
    // Intergers -- int -- whole numbers, +/-, including 0

    // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

    // DECLARING (CREATING VARIABLES)
    // Method #1 -- Declared but Not assign
    // dataType variableName;

    int myInteger 
    double myDouble

    // Method #2 -- Declare AND Assign 
    int = myInteger2 = 1;
    double = myDouble2 = 2.05D;

    // Strings -- Collections of letters, numbers, special characters
    string myString = "I like star wars";

    // Boolean -- bool - True or False value
    bool mybool = true;
    bool fireResistant = true;
    bool hasPurpleKey = false;

    // Charater -- char -- a single character.
    char myChar = 'A';

    // ASSIGNING VALUES AFTER DECLARTION

    myInteger = 5;
    myDouble = -1.0D;

    // // PRINTING VARIABLES TO THE CONSOLE TERMINAL 
    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);

    // // PRINTING EXPRESSIONS TO THE CONSOLE TERMINAL 
    // Console.WriteLine(myInteger - 25);
    // Console.WriteLine(myDouble + 2.5D);

    // // PRINTING VARIABLES TO THE CONSOLE TERMINAL 
    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);

    // OPERATORS -- ARITHMETIC
    // Adition
    int myNewInt = myInteger + myInteger2;
    double mydouble = mydouble + mydouble2; 
    double myNewNumber = integer + myDouble;

    // Subtraction
    mynewnumber = myDouble - myInteger;

    // Division 
    mynewnumber = myDouble / myInteger

    // MULTIPLICATION 
    mynewnumber = mynewdouble * myInteger; 

    // MODULUS -- Divides, then returns the remainder 
    // Most commonly used to determine EVEN or ODD 
    mynewnumber = myDouble % 2

    int students = 6;
    int numSlices = 36;
    int leftOvers;

    leftOvers = numSlices % students

  // Increment / Decrement -- Most frequently used in LOOPS 
    int x=0;
    x++; // What is x equal to now?
  // Increment ++ adds 1 to the current value and puts the new value into the bucket
    x--;
  // Decrement -- subtracts 1 from current value and puts the new value into the bucket

  // Special assignment operarators 
  x += 1
  x *= 1
  x /= 1
  x -= 1
  x %= 1
  // Take current value, perfrom the calculation, put new value into bucket

  // COMPARSION OPERATORS
  // Evaluate the expression, Return true or false
  int y = 5
  int z = 3

  // IS-EQUAL-To == is the value on the left equal to the right?
  // Console.WriteLine(y == z);

  // NOT-EQUAL-TO != is the value on the left not equal to the right?
  // Console.WriteLine(y != z);

  // Greater THAN >
  // Console.WriteLine(y > z);

  // Greater THAN-OR-EQUAL TO >= 
  // Console.WriteLine(y >= z);
  // LESS THAN < 
  // Console.WriteLine(y < z);
  // Less THAN-OR-EQUAL TO <= 
  // Console.WriteLine(y <= z);

  Logical OPERATORS
  int b = 1
  double c = 2.0D; 
  string favcolor = "Blue";
  // Logical AND && -- all statments must be True
  // Cosole.WriteLine(b > 1 && c != 5.0D); // false because b is not > 1
  // Console.WriteLine(b == 1 && c < 10.0D); // both are true, whole expression is true 
  // If one expression most likely to be False, check for it First!
  // Console.WriteLine(hasPurpleKey == true && playerlevel > 5);

  // Logical OR || -- ONE statement must be True 
  // Cosole.WriteLine(b > 1 || c != 5.0D); // true because C is not equal to 5.0 
  // Console.WriteLine(b == 2 || c > 10.0D); // false because both expressons are false
  // Check for the statement most likely to be true first!
  // Console.WriteLine(hasPurpleKey == true && playerlevel > 3);

  Logical NOT ! -- Returns the opposite value of the expression.
  // Console.WriteLine(!(b > -1)); // True
  // Console.WriteLine(!(b > -1)); // False

  // READING USER INPUT FROM THE CONSOLE / TERMINAL 
  // Console.WriteLine("What is your player name? Type it and Enter.\n");

  // CREATE A VARIABLE TO STORE DATA 
  string playerName = Console.ReadLine();
  // Console.ReadLine() ONLY RETURNS string data types.
  // Console.WriteLine("What is your age? Type it and press ENTER.\n");
  string age = Console.ReadLine();
  // Console.WriteLine(age + age)
  // adding string data types together is called CONCATENATION

  // Print THE VARIABLE TO THE SCREEN 
  // Console.WriteLine("Your player name is " + playerName);

  // INPUTING NUMBERS FROM THE CONSOLE 
  // Console.WriteLine("How many chicken nuggies can you eat in 5 minutes? Enter an integer value and press enter.\n");
  int numNuggies = Convert.TOint32(Console.Readline());
  // Console.WriteLine(numNuggies- + numNuggies);

  // int day = 1
  // switch(day)
  {
    // case 1:
    //     Console.WriteLine("It's Monday.\n");
    //   break;
    // case 2:
    //     Console.WriteLine("It's Tuesday.\n")
    //   break;
    // case 3: 
    //     Console.WriteLine("It's Wednesday.\n");
    //   break;
    // // case 4 - 6
    // case 7: 
    //     Console.WriteLine("It's Sunday, go rest.\n");
    //     break;
  }

  // REPEATING STEPS OVER, AND OVER AGAIN 
  // LOOPS are used to repeat instructions multiple times.

  // while loops are "musical chairs" in computer science.
  // use while when you DO NOT know how many loops you need.
  // the code will run as long as the condition is true. 
  // while loop syntax:
  */

  // while (CONDITIONAL_EXPRESSION)
  // {
  //     Code to loop goes here.
  // }
 */

//  int z = 0; 
//  while (z <= 100) // What do I replace CONDITIONAL EXPRESSION with?
//  {
//     Console.WriteLine(z);
//     z++;
//  }

// int y = 100; 
// while (y = 100) // What do I replace CONDITIONAL EXPRESSION with?
//  {
//     Console.WriteLine(y);
//     y--;
//  }

  // for loops are like playing go fish. 
  // you know how many cards in our hand. 
  // used when you know how many loops you need ahead of time.

  /*
  for (statement1; statement2; statement3;)
  {
    Code to run each time through loop.
  }

  statement1 = code to run ONE TIME before the loop starts. 
  statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loop runs. 
  statement3 = code to run AFTER each loop. 
  

  Each 'trip' through the loop is called ITERATION.
  */

  // Counting to 10 with for loops.
  for (int i = 0; i <= 10; i++)
  {
    Console.WriteLine(i);
  }

 for (int i = 10; i >= 0; i--)
  {
    Console.WriteLine(i);
  }

  }
}