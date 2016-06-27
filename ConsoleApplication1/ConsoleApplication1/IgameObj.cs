namespace ConsoleApplication1
{

    public interface IGameObject
    {
        string Name { get; }
        Point Position { get; }
        bool Active { get; }
        int Speed { get; set; }
    }
}