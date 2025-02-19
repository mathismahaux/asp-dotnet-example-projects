using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"Is Bastion the best boi ever?", "Is Jack Black Steve?", "Does a submarine swim?"};

      bool[] answers = {true, true, false};

      bool[] responses = new bool[questions.Length];

      if(questions.Length != answers.Length)
      {
        Console.WriteLine("WARNING: The sizes of the \"questions\" array and the \"answers\" array are different.");
      }

      int askingIndex = 0;

      foreach(string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = (Console.ReadLine()).ToLower();

        if(input == "true" || input == "false")
        {
          isBool = true;
        } else {
          isBool = false;
        }

        while(isBool == false)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = (Console.ReadLine()).ToLower();
          if(input == "true" || input == "false")
          {
            isBool = true;
          } else {
            isBool = false;
          }
        }

        if(input == "true")
        {
          inputBool = true;
        } else {
          inputBool = false;
        }

        responses[askingIndex] = inputBool;
        askingIndex ++;
      }

      int scoringIndex = 0;
      int score = 0; 

      foreach(bool answer in answers) 
      {
        bool currentResponse = responses[scoringIndex];  
        Console.WriteLine($"{scoringIndex + 1}. Input: {currentResponse} | Answer: {answer}");
        if(currentResponse == answer)
        {
          score++;
        }
        scoringIndex++;
      } 
      Console.WriteLine($"You got {score} out of {scoringIndex} correct!");
    }
  }
}
