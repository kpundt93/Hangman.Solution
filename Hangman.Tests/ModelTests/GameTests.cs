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
      string[] answerArray = newGame.Answer.Split("");
      newGame.setCurrentAnswer();
      Assert.AreEqual(answerArray.Length, newGame.CurrentAnswer.Count);
    }
  }
}