using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Robot robick = new Robot();
            int i = 0;

            Console.WriteLine("Введите путь робота при помощи стрелочек на клавиатуре(W - вверх, S - вниз, A - влево, D - вправо");
            Console.SetCursorPosition(robick.x, robick.y);
            Console.CursorVisible = false;
            ConsoleKeyInfo key;
            Console.Write((char)(127));

            while (run)
            {
                key = Console.ReadKey(true);
                robick.Shag(ref key, ref robick.x, ref robick.y);
                run = robick.End();
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"Вы вернулись.\nВсего шагов: {robick.count}");
            Console.ReadKey(true);

        }
    }
}
