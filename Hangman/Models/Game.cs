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
      
    public string Answer { get; }
    public List<char> GuessedLetters { get; set; }
    public List<string> CurrentAnswer = new List<string> {};

    public Game()
    {
      Random rand = new Random();
      int randNum = rand.Next(0, _words.Count - 1);
      Answer = _words[randNum];
    }

    public void setCurrentAnswer()
    {
      string[] answerArray = Answer.Split("");
      foreach(string letter in answerArray)
      {
        CurrentAnswer.Add("_ ");
      }
    }
  }
}