using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controllers{
  {

    [Route("/")]
    public ActionResult MadLib1()
    {
      return View ();
    }
  }
}