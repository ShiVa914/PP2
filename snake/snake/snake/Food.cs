using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food
    {
        public static Point location;
        public static char sign;
        public ConsoleColor color;
        public Food()
        {
            sign = '+';
            color = ConsoleColor.Green;
            SetRandomPosition();
        }
        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 20);
            {
               // if (Food.sign == Wall.sign) ;
                //int x = new Random().Next(0, 70);
                //int y = new Random().Next(0, 20);//
            }
            location = new Point(x, y);
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
    }
}