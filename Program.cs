using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOngoing = true;
            int turnNumber = 0;
            string currPlayer = "";
            var board = new Board();
            
            board.Display();
            Console.ReadKey();

            while (gameOngoing == true)
            {
                if (turnNumber % 2 == 0)
                {
                    currPlayer = "X";
                }
                else if (turnNumber % 2 == 1)
                {
                    currPlayer = "O";
                }
                turnNumber++;

                Console.WriteLine("{0}'s turn, please enter a column", currPlayer);
                int column = Convert.ToInt32(Console.ReadLine());
                board.Add(currPlayer, column);
                Console.Clear();
                board.Display();
            }
        }
    }
}
