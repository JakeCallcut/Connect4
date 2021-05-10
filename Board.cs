﻿using System;

namespace Connect4
{
    class Board
    {
            public string[,] boardArray = new string[7,7] {
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
            };

        public int Add(string _player, int _column)
        {
            for (int i = 6; i > 0; i--)
            {
                if (this.boardArray[i, _column] == "- ")
                {
                    this.boardArray[i, _column] = _player + " ";
                    return 1;
                }
            }
            return 0;
        }

        public void Display()
        {
            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine(" ");
                for (int i = 0; i < 7; i++)
                { 
                    Console.Write(this.boardArray[1,i]);
                }
            }
            Console.WriteLine(" ");
        }
    }
}
