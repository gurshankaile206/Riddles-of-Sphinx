using System;
using System.Collections.Generic;

class Program
{
  static List<string> riddles = new List<string>(new string[] {
    "What goes on four feet in the morning, two feet at noon, and three feet in the evening?",
    "I come from a mine and get surrounded by wood always. Everyone uses me. What am I?",
    "A box without hinges, key, or lid. Yet inside golden treasure is hid."
  });

  static List<string> answers = new List<string>(new string[] {
    "person",
    "pencil lead",
    "an egg"
  });


  static void Main()
  {
    Console.WriteLine("Welcome to the riddle of the Sphinx! It is an inquisitive sort, answer its questions well or be devoured!");
    Console.WriteLine("--------------");

    ShuffleRiddles();

    for (int index = 0; index < riddles.Count;) 
    {
      Console.WriteLine(riddles[index]);
      string answer = Console.ReadLine().ToLower();
      bool result = Sphinx(answer, index);
     
      if (result)
      { 
        index++;
        Console.WriteLine("Correct! Moving onto the next riddle");
      } else {
        Console.WriteLine("That's incorrect! I am supposed to eat you for getting the wrong answer but I will be nice for now, TRY AGAIN!");
      }
    }
  }

  static public void ShuffleRiddles () {
    Random rand = new Random();
    
    for (int currentIndex = 0; currentIndex < riddles.Count; currentIndex++) {
      int nextIndex = rand.Next(0, riddles.Count);

      string currentRiddle = riddles[currentIndex];
      string currentAnswer = answers[currentIndex];
      string nextRiddle = riddles[nextIndex];
      string nextAnswer = answers[nextIndex];

      riddles[currentIndex] = nextRiddle;
      answers[currentIndex] = nextAnswer;
      riddles[nextIndex] = currentRiddle;
      answers[nextIndex] = currentAnswer;
    }
  }

  static public bool Sphinx(string input, int index) 
  { 
    return (input == answers[index]);
  }
}