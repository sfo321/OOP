using System;

namespace OOP_Principles_Part1_HW.Utils
{
    public static class Validator
    {
        public static void ValidateGrade(int grade)
        {
            if(grade <= 0 || grade > 12)
            {
                throw new ArgumentOutOfRangeException("Invalid grade value!");
            }
        }

        public static void ValidateIntNumber(int classNumber)
        {
            if (classNumber <= 0 || classNumber > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid class number value!");
            }
        }

        public static void ValidateString(string input, string item)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException($"{item} cannot be null or empty");
            }
        }

        public static void ValidateIfNull(Object obj, string item)
        {
            if(obj == null)
            {
                throw new ArgumentException($"{item} cannot be null");
            }
        }
    }
}
