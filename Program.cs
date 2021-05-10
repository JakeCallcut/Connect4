using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            board.Display();
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Crosses, enter a column");
                int column = Convert.ToInt16(Console.ReadLine());
                board.Add("X", column);
                Console.Clear();
                board.Display();
                Console.ReadKey();
            }

        }
    }
}
