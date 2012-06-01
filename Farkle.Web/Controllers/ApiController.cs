using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Farkle.Core;

namespace Farkle.Web.Controllers
{
    /// <summary>
    /// Entry point for a web based API for creating an UI with the tools of your choice. iOS, Android, etc.
    /// </summary>
    /// <remarks>
    /// With the exception of the Index, the Controller methods should return a JsonResult
    /// </remarks>
    public class ApiController : Controller
    {
        //
        // GET: /Api/

        /// <summary>
        /// Display the API Documenation
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        //Example of a JsonResult
        public JsonResult NewGame(GameSetup gameSetup)
        {
            return Json(
                       new {
                           GameState = new GameState()
                       });
        }
    }
}
