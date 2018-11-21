using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controllers{
  {
    [Route("/")]
    public ActionResult ThanksgivingForm()
    {
      return View();
    }

    [Route("/MadLib1")]
    public ActionResult ThanksgivingMadLib(string noun1, string noun2, string noun4, string noun5, string noun6, string noun7, string pluralNoun1, string pluralNoun2, string adjective1, string adjective2, string adjective 3, string number1, string number2)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.SetNoun1(noun1);
      myMadLibVariable.SetNoun2(noun2);
      myMadLibVariable.SetNoun3(noun3);
      myMadLibVariable.SetNoun4(noun4);
      myMadLibVariable.SetNoun5(noun5);
      myMadLibVariable.SetNoun6(noun6);
      myMadLibVariable.SetNoun7(noun7);
      myMadLibVariable.SetPluralNoun1(pluralNoun1);
      myMadLibVariable.SetPluralNoun2(pluralNoun2);
      myMadLibVariable.SetAdjective1(adjective1);
      myMadLibVariable.SetAdjective2(adjective2);
      myMadLibVariable.SetAdjective3(adjective3);
      myMadLibVariable.SetNumber1(number1);
      myMadLibVariable.SetNumber2(number2);
      return View (myMadLibVariable);
    }
  }
}
