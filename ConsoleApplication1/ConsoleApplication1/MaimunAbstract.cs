using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Maimun
    {
        public string Name { get; set; }
        public Point Position { get; set; }
        public bool Active { get; set; }

        public Maimun(string name, Point position, bool active)
        {
            this.Name = name;
            this.Position = position;
            this.Active = active;
        }

        public void Move(Point moveto)
        {
            double deltaX = moveto.X - this.Position.X;
            double deltaY = moveto.Y - this.Position.Y;
            this.Position.X = 5;
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        }
    }
}
