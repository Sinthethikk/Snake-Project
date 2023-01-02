using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake_Project
{
    class Snake
    {

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char dir = 'u';
        public int x { get; set; }
        public int y { get; set; }

        List<Position> snakeBody;

        public Snake()
        {
            Random rnd = new Random();
            x = rnd.Next(10, 59);
            y = rnd.Next(10, 39);

            snakeBody = new List<Position>();

            snakeBody.Add(new Position(x, y));
        }

        public string activeHead = "*";
        public void drawSnake()
        {
            
            foreach (Position pos in snakeBody)
            {
                
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write(activeHead);
            }
        }

        



        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void direction()
        {

            if(key == 'w' && dir != 'd')
            {
                dir = 'u';
            }
            else if(key == 's' && dir != 'u')
            {
                dir = 'd';
            }else if(key == 'd' && dir != 'l')
            {
                dir = 'r';
            }else if(key == 'a' && dir != 'r')
            {
                dir = 'l';
            }
        }

        public void moveSnake()
        {
            direction();

            if (dir == 'u')
            {
                y--;
            }
            else if (dir == 'd')
            {
                y++;
            }else if (dir == 'r')
            {
                x++;
            }else if (dir == 'l')
            {
                x--;
            }

            snakeBody.Add(new Position(x, y));
            Thread.Sleep(100);

        }

        public void Fail()
        {
            Position head = snakeBody[snakeBody.Count - 1];

            for(int i = 0; i < snakeBody.Count -2; i++)
            {
                Position sb = snakeBody[i];

                if(head.x == sb.x && head.y == sb.y)
                {
                    throw new SnakeEX("FAILED");
                }
            }
        }

        public void wallFail(Board board)
        {
            Position head = snakeBody[snakeBody.Count - 1];
            if (head.x >= board.Width || head.x <0 || head.y >= board.Length || head.y <= 0)
            {
                throw new SnakeEX("FAILED");
            }
        }
    }
}
