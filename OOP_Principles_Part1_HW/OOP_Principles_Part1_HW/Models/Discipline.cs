using System.Text;
using OOP_Principles_Part1_HW.Utils;

namespace OOP_Principles_Part1_HW.Models
{
    public class Discipline
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(Disciplines disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Disciplines DisciplineName { get; set; }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                Validator.ValidateIntNumber(value);
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                Validator.ValidateIntNumber(value);
                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("=====");
            builder.AppendLine($"{this.DisciplineName}");
            builder.AppendLine($"Number of lectures: {this.NumberOfLectures}");
            builder.AppendLine($"Number of exercises: {this.NumberOfExercises}");
            return builder.ToString();
        }
    }
}
