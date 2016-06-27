using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Maimuna fr = new Maimuna("Kichka", new Point(3, 6), true, 5);

            var positionToGo = new Point(50, 6);

            double deltaX = positionToGo.X - fr.Position.X;
            double deltaY = positionToGo.Y - fr.Position.Y;
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            var time = distance / fr.Speed;
            double newX = fr.Position.X;
            double newY = fr.Position.Y;
            while (positionToGo.X != fr.Position.X || fr.Position.Y != positionToGo.Y)
            {
                newX = newX + (deltaX / time);
                newY = newY + (deltaY / time);
                fr.Position.X = (int)newX;
                fr.Position.Y = (int)newY;
                Console.SetCursorPosition(fr.Position.X, fr.Position.Y);
                Console.Write(new Point(fr.Position.X, fr.Position.Y));
            }
        }
    }
}
