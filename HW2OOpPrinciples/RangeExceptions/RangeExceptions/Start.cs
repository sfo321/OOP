namespace RangeExceptions
{
    using System;

    public class RangeExceptionMain
    {
        static void Main()
        {

            try
            {
                int number = 200;
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid input", 1, 100);
                }
            }

            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(1974, 10, 01);
                if (date < new DateTime(1977, 03, 11) || date > new DateTime(1980, 05, 15))
                {
                    throw new InvalidRangeException<DateTime>("Invalid date",
                    new DateTime(1977, 03, 11), new DateTime(1980, 05, 15));
                }
            }

            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}