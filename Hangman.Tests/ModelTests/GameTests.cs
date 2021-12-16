using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Tests
{
  [TestClass]
  public class GameTests : IDisposable
  {
    public void Dispose()
    {
      GAme.ClearAll();
    }

    [TestMethod]
    public void GameConstructor_CreatesInstanceOf
  }
}