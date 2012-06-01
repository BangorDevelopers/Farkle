using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farkle.Core
{
    public class GameState
    {
        public IEnumerable<Player> Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public int PointsThisRound { get; set; }
        public bool Farkle { get; set; }
        public IEnumerable<Die> Dice { get; set; }
        public bool GameOver { get; set; }
    }

    public enum DieKeepAction
    {
        Yes,
        No,
        Unknown
    }

    public class Die
    {
        public Die()
        {
            Value = 0;
            Active = true;
            Keep = DieKeepAction.Unknown;
        }
        public int Value { get; set; }
        public bool Active { get; set; }  // dice that have been played are not active
        public DieKeepAction Keep { get; set; }
    }
}
