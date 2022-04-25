using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{

    public class UC1_SnakeLadder
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

        }
    }
    
}
