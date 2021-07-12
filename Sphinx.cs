using System;
using System.Collections.Generic;

class Program
{
  static List<string> riddles = new List<string>(new string[] {
    "What goes on four feet in the morning, two feet at noon, and three feet in the evening?"
  });

  static List<string> answers = new List<string>(new string[] {
    "person"
  });


  static void Main()
  {
    Console.WriteLine("Welcome to the riddle of the Sphinx! It is an inquisitive sort, answer its questions well or be devoured!");
    Console.WriteLine("--------------");
    Console.WriteLine(riddles[0]);

    while (true) {
      // do this thing
      string answer = Console.ReadLine();
      bool result = Sphinx(answer);
      if (result)
      {
        Console.WriteLine("Correct! You win");
        break;
      } else {
        Console.WriteLine("That's incorrect! I am supposed to eat you for getting the wrong answer but I will be nice for now, TRY AGAIN!");
      }
    }

    
  }

  static public bool Sphinx(string input) 
  { 
    return (input == answers[0]);
  }
}