using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/madlibs-story")]
    public ActionResult MadLibsStory()
    {
      MadLibsVariable myMadLibs = new MadLibsVariable();
      myMadLibs.SetPerson1(Request.Query["person1"]);
      myMadLibs.SetPerson2(Request.Query["person2"]);
      myMadLibs.SetAnimal(Request.Query["animal"]);
      myMadLibs.SetExclaimation(Request.Query["exclaimation"]);
      myMadLibs.SetVerb(Request.Query["verb"]);
      myMadLibs.SetNoun(Request.Query["noun"]);
      return View("MadLibs", myMadLibs);
    }
  }
}
