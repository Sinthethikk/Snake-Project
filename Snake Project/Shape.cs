using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake_Project
{

    class Shapes
    {
        
        int x, y;
        Random rnd = new Random();


        public void Triangle()
        {
            for (x = 1; x <= rnd.Next(2, 10); x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("#");
                }
            }
        }

        public void DrawTri()
        {
            int rnx = rnd.Next(1, 49);
            int rny = rnd.Next(1, 79);

            Console.SetCursorPosition(rnx, rny);
            Triangle();
        }
        
    }
}
