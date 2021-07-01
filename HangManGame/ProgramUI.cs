using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang_Man
{
    public class ProgramUI
    {
        GameRepo gameRepo = new GameRepo();
        public void Run()
        {
            Console.WriteLine("Welcome to Hang man!");
            MainMenu();
        }
        public void MainMenu()
        {
            Console.WriteLine("Select an Option: \n" +
                 "1. Start Game\n" +
                 "2. Exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    GameMenu();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please make a different selection.");
                    MainMenu();
                    break;
            }
        }
        private void GameMenu()
        {
            GamePoco currentGame = gameRepo.GetGame();
            Console.WriteLine("Topic: Wild Animals (" + currentGame.Guesses + "/6): ");
            string input = Console.ReadLine();
            GamePoco game = gameRepo.UpdateGame(input);
            if (game.HasWon)

            {
                Console.WriteLine("SUCCESS! You Won in " + game.Guesses + " guesses.");
                MainMenu();
                return;
            }

            if (game.Guesses == 6)
            {
                Console.WriteLine("Too many attempts you lose.");
                MainMenu();
                return;
            }
            GameMenu();
        }
    }
}