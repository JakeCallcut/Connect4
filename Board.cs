using System;

namespace Connect4
{
    class Board
    {
            public string[,] boardArray = new string[6,7] {
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
                {"- ", "- ", "- ", "- ", "- ", "- ", "- "},
            };

        public bool HasWon(string _player)
        {
            
        }

        public bool HasAdjacent(string _player, int _x, int _y, int _direction)  
        {
            { 
            /*
            _direction values:
            1 = top left
            2 = top middle
            3 = top right
            4 = middle left
            5 = middle right
            6 = bottom left
            7 = bottom middle
            8 = bottom right
            */
            }

            switch (_direction)
            {
                case 1:
                    if (this.boardArray[_y, _x] == this.boardArray[_y - 1, _x - 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (this.boardArray[_y, _x] == this.boardArray[_y - 1, _x])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (this.boardArray[_y, _x] == this.boardArray[_y - 1, _x + 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                    if (this.boardArray[_y, _x] == this.boardArray[_y, _x - 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 5:
                    if (this.boardArray[_y, _x] == this.boardArray[_y, _x + 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 6:
                    if (this.boardArray[_y, _x] == this.boardArray[_y + 1, _x - 1])                     //last edit, thinking about so many logic errors
                    {                                                                                   //what if the vector goes outside of the board?
                        return true;                                                                    //must be a beter way to do it            
                    }                                                                                    
                    else
                    {
                        return false;
                    }
                case 7:

                case 8:

                default:
                    return false;
            }
            
        }

        public int Add(string _player, int _column)
        {
            for (int i = 5; i > 0; i--)
            {
                if (this.boardArray[i, _column - 1] == "- ")
                {
                    this.boardArray[i, _column - 1] = _player + " ";
                    return 1;
                }
            }
            return 0;
        }

        public void Display()
        {
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(" ");
                for (int i = 0; i < 7; i++)
                { 
                    Console.Write(this.boardArray[j,i]);
                }
            }
            Console.WriteLine(" ");
        }
    }
}
