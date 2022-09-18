using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Robot
    {
        public int x = Console.WindowWidth / 2;
        public int y = Console.WindowHeight / 2;
        public int count = 0;

        public void Shag (ref ConsoleKeyInfo key, ref int x, ref int y)
        {
            if (key.KeyChar == 119 || key.KeyChar == 87)
            {
                Console.SetCursorPosition(x, --y);
                Console.Write("∙");
            }
            else if(key.KeyChar == 115 || key.KeyChar == 83)
            {
                Console.SetCursorPosition(x, ++y);
                Console.Write("∙");
            }
            else if (key.KeyChar == 97 || key.KeyChar == 65)
            {
                Console.SetCursorPosition(--x, y);
                Console.Write("∙");
            }
            else if (key.KeyChar == 100 || key.KeyChar == 68)
            {
                Console.SetCursorPosition(++x, y);
                Console.Write("∙");
            }
            count++;
            
        }   
        public bool End()
        {
            if(x == (Console.WindowWidth / 2) && y == (Console.WindowHeight / 2) || count > 100)
            {
                if (count > 100)
                {
                    Console.WriteLine("Не пришли");
                }
                return false;

            }
            return true;
        }
    }
}
