using System.Web.Mvc;

namespace StringPlayers.Controllers
{
    public class StringController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #region FixString
        [HttpPost]
        public ActionResult FixString(string InputText)
        {
            BL.StringFixer oStingBuilder = new BL.StringFixer();
            ViewBag.Result = oStingBuilder.FixString(InputText);
            return View("Index");
        }
        #endregion
    }
}