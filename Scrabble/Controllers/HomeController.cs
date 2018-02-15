using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      WordScore dummyScore = new WordScore("");
      return View("Index", dummyScore);
    }

    [HttpPost("/calculate")]
    public ActionResult Calculate()
    {
      string newWord = Request.Form["word"];
      WordScore newScore = new WordScore(newWord);
      newScore.ScoreWord();

      return View("Index", newScore);
    }

  }
}
