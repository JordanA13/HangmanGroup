using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang_Man
{
    public enum Answers
    {
        Tiger, Elephant, Zebra, Lion, Bear
    }
    public class GamePoco
    {
        // properties of the class
        public string CurrentAnswer { get; set; }
        public int Guesses { get; set; }
        public bool HasWon { get; set; }


        public GamePoco()
        {
            // TODO: Set Current Answer to one of the values from the ENUM.
            // Ways to do this:
            // 1. Random Number Generator
            // 2. Giver the player a Menu of 1 - 5 and choose the answer based on that.
            // Pseudo Code for Random Number
            //int randomNum = new Random(1, 2);
            //CurrentAnswer = Answers[randomNum];
            CurrentAnswer = "Tiger";
        }
    }
}
