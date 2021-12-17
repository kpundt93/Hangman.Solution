using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class GameController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/new")]
    public ActionResult Index()
    {
      Game newGame = new Game();
      newGame.SetCurrentAnswer();
      return View(newGame);
    }

    [HttpGet("/show")]
    public ActionResult Show(int id)
    {
      Game currentGame = Game.Find(id);
      return View(currentGame);
    }
  }
}