using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Farkle.Core;

namespace Farkle.Web.Controllers
{
    // TODO: Implement a HTML UI using Razor Views
    // ?? Use a partial view?
    public class GameController : Controller
    {
        //
        // GET: /Game/

        [HttpPost]
        public ActionResult NewGame(GameSetup setup)
        {
            var service = new FarkleService();
            var gameState = service.StartNewGame(setup);
            //return View("Play", gameState);
            return null;
        }

        [HttpPost]
        public ActionResult Play(GameState gameState, string move)
        {
            var service = new FarkleService();
            //gameState = service.Play(gameState, move);
            //return View(gameState);
            return null;
        }

    }
}
