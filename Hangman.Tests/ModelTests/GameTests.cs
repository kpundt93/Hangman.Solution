using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_SelectsRandomAnswer_String()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(string), newGame.Answer.GetType());
    }

    [TestMethod]
    public void SetCurrentAnswer_SetsAnswerToBlanks_String()
    {
      Game newGame = new Game();
      char[] answerArray = newGame.Answer.ToCharArray();
      newGame.SetCurrentAnswer();
      Assert.AreEqual(answerArray.Length, newGame.CurrentAnswer.Count);
    }

    [TestMethod]
    public void GuessLetter_CompareGuessToAnswer_True()
    {
      Game newGame = new Game();
      newGame.Answer = "test";
      Assert.AreEqual(newGame.GuessLetter('e'), true);
    }

    [TestMethod]
    public void GuessLetter_ContainsLetter_True()
    {
      Game newGame = new Game();
      newGame.GuessLetter('a');
      Assert.AreEqual(newGame.GuessedLetters.Contains('a'), true);
    }

    [TestMethod]
    public void GuessLetter_FillsInBlank_e()
    {
      Game newGame = new Game();
      newGame.Answer = "test";
      newGame.SetCurrentAnswer();
      newGame.GuessLetter('e');
      Assert.AreEqual(newGame.CurrentAnswer[1], 'e');
    }

    [TestMethod]
    public void CheckWin_CheckForWin_true()
    {
      Game newGame = new Game();
      newGame.Answer = "a";
      newGame.SetCurrentAnswer();
      newGame.GuessLetter('a');
      Assert.AreEqual(newGame.CheckWin(), true);
    }

    [TestMethod]
    public void CheckLoss_CheckForLoss_true()
    {
      Game newGame = new Game();
      newGame.Answer = "test";
      newGame.wrongGuesses = 7;
      Assert.AreEqual(newGame.CheckLoss(), true);
    }
  }
}