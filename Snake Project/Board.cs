using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Project
{
    class Board
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public Board()
        {

            Length = 50;
            Width = 80;

            Console.CursorVisible = false;

        }


        public void Drawboard()
        {

            Console.Clear();

            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");

            }for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Length);
                Console.Write("-");

            }for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");

            }for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("|");
            }

        }

    }
}
