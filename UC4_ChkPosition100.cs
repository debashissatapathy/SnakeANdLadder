using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class UC4_ChkPosition100
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


            private void Option(int roll)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Ladder(roll);
                        break;
                    case 2:
                        Snake(roll);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

            private void Snake(int roll)
            {
                Console.WriteLine("OOh no! Snake swallowed me!");
                Console.WriteLine("Going down by" + roll);

            }

            private void Ladder(int roll)
            {
                Console.WriteLine("Yay ! & Ladder taking me up!");
                Console.WriteLine("Going up by " + roll);

            }


            private int CheckBoundary(int displacement)
            {
                if (position < 0)
                {
                    position = 0;
                    return 0;
                }
                else if (position > 100)
                {
                    position -= displacement;
                    Console.WriteLine("Oops! You shot past position 100");
                    Console.WriteLine("You are moved back to previous position");
                    return 0;
                }
                else
                    return 1;
            }
        }
    }
}
