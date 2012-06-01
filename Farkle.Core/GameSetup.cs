using System.Collections.Generic;

namespace Farkle.Core
{
    public class GameSetup
    {
        public GameSetup()
        {
            // default game setup
            Players = new List<Player>
                          {
                              new Player("Player 1"),
                              new Player("Player 2")
                          };
            Rules = new GameRules();
        }
        public IEnumerable<Player> Players { get; set; }
        public GameRules Rules { get; set; }

    }
}