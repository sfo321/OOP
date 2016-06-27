namespace ConsoleApplication1
{
    using System; 

    public class Maimuna : Maimun, IGameObject
    {
        public int Speed { get; set; }

        public Maimuna(string name, Point position, bool active, int speed) : base(name, position, active)
        {
            this.Name = name;
            this.Position = position;
            this.Speed = speed;
            this.Active = active;
        }

        public new Point Move(Point positionToGo)
        {
            double deltaX = positionToGo.X - this.Position.X;
            double deltaY = positionToGo.Y - this.Position.Y;
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            var time = distance / this.Speed;
            double newX = this.Position.X;
            double newY = this.Position.Y;
            while (positionToGo.X != this.Position.X && positionToGo.Y != positionToGo.Y)
            {
                newX = this.Position.X + (deltaX / time);
                newY = this.Position.Y + (deltaY / time);
                return new Point((int)newX, (int)newY);
            }
            return new Point((int)newX, (int)newY);
        }
    }
}
