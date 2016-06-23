namespace Timer
{
    class Program
    {
        static void Main()
        {
            Timer timer = new Timer(1);
            timer.InvokeDelegate();
        }
    }
}