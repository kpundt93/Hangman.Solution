using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class Game
  {
    private static List<string> _words = new List<string> {
      "inspection",
      "magazine",
      "passenger",
      "consequence",
      "contribution",
      "tradition",
      "insect",
      "energy",
      "history",
      "union",
      "audience",
      "entertainment",
      "hat",
      "economics",
      "music",
      "philosophy",
      "driver",
      "recipe",
      "singer",
      "tennis"
      };
      
    public string Answer { get; set; }
    public List<char> GuessedLetters = new List<char> {};
    public List<char> CurrentAnswer = new List<char> {};

    public int wrongGuesses { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> { };

    public Game()
    {
      Random rand = new Random();
      int randNum = rand.Next(0, _words.Count - 1);
      Answer = _words[randNum];
      wrongGuesses = 0;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void SetCurrentAnswer()
    {
      char[] answerArray = Answer.ToCharArray();
      foreach(char letter in answerArray)
      {
        CurrentAnswer.Add('_');
      }
    }

    public bool GuessLetter(char letter)
    {
      char[] answerArray = Answer.ToCharArray();
      if(GuessedLetters.Contains(letter))
      {
        return false;
      }
      else if(Answer.Contains(letter))
      {
        for(int i = 0; i < CurrentAnswer.Count; i++)
        {
          if(answerArray[i] == letter)
          {
            CurrentAnswer[i] = letter;
          }
        }
        GuessedLetters.Add(letter);
        return true;
      }
      else
      {
        GuessedLetters.Add(letter);
        wrongGuesses++;
        return true;
      }
    }

    public bool CheckWin()
    {
      string currentAnswerString = string.Join("", CurrentAnswer);
      if (currentAnswerString == Answer)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CheckLoss()
    {
      if(wrongGuesses >= 6)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}