using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        // [Route("/greeting_card")]
        // public ActionResult GreetingCard()
        // {
        //     LetterVariable myLetterVariable = new LetterVariable();
        //     myLetterVariable.SetRecipient(Request.Query["recipient"]);
        //     myLetterVariable.SetSender(Request.Query["sender"]);
        //     return View("Letter", myLetterVariable);
        // }
    }
}
