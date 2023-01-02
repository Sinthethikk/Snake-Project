using System;

namespace Snake_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            Board board = new Board();
            Snake snake = new Snake();
            Shapes shapes = new Shapes();


            Console.WriteLine("Press Enter to start game (Go Fullscreen)");
            Console.WriteLine("Move with W-A-S-D");
            Console.Read();
            while (!done)
            {
                try
                {
                    board.Drawboard();
                    snake.Input();
                    shapes.DrawTri();
                    snake.drawSnake();
                    snake.moveSnake();
                    snake.Fail();
                    snake.wallFail(board);
                }
                catch(SnakeEX e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    done = true;
                }
                
            }

        }
    }
}
