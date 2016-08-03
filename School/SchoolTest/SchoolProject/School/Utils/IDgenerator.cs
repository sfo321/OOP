namespace SchoolProject.Utils
{
    using System.Threading;

    public static class IDgenerator
    {
        private static int idCounter;

        static IDgenerator()
        {
            idCounter = 0;
        }

        public static int GenerateId(int step)
        {
            var result = Interlocked.Increment(ref idCounter);
            return result + step;
        }
    }
}
