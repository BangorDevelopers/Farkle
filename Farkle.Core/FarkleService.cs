using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farkle.Core
{
    /// <summary>
    /// The main service for the business logic of the Game
    /// </summary>
    // TODO: Implement the class methods, create additional classes as necessary to best component-ize the design
    public class FarkleService
    {
        public GameState StartNewGame(GameSetup setup)
        {
            return new GameState();
        }

        public GameState Play(GameState gameState, GameMove move)
        {
            // TODO: Look at the gameState passed in to get the dice values to keep
            // the player can Bank, Roll or they Farkled and must move to the next player
            // modify the scores, current player and return the game state

            return new GameState();
        }

        // Tired of playing so quitting early
        // TODO: Consider saving game state for resuming later.
        public void Quit(GameState gameState)
        {
            return;
        }
    }
}
