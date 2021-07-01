using System;
using System.Collections.Generic;
using System.Text;
namespace Hang_Man
{
    public class GameRepo
    {
        public GamePoco game = new GamePoco();
        public GamePoco GetGame()
        {
            return game;
        }
        public GamePoco UpdateGame(string guess)
        {
            game.Guesses += 1;
            if (guess == game.CurrentAnswer)
            {
                game.HasWon = true;
            }

            return game;
            // TODO: WIN STATUS
        }
    }
}
