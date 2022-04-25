using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class UC2_DiceNumer
    {
        public class SnakeAndLadder
        {
            private int position;
            private bool winCheck;
            private int totalDiceRoll;

            static Random random = new Random();

            public SnakeAndLadder()
            {
                position = 0;
                winCheck = false;
                totalDiceRoll = 0;
            }

            public void Describe()
            {
                Console.WriteLine("Player at " + position + " position.");
            }

            public void RollDice()
            {
                totalDiceRoll++;
                
                int Roll = random.Next(1, 7);
                Console.WriteLine("DIce Number: " + Roll);
                Console.WriteLine("Total dice rolled" + totalDiceRoll);
            }

        }
    }
}
