namespace School.Disciplines
{
    using System;
    using System.Text;
    public class Discipline
    {
        private string name;
        private int lectures;
        private int exercises;
        public string Comment { get; set; }

        public Discipline(string name, int nlectures, int nexercises)
        {
            this.Name = name;
            this.NumberOfLectures = nlectures;
            this.NumberOfExercises = nexercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Must enter name!!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentException("Invalid number of lectures!!");
                }
                this.lectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.exercises;
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentException("Invalid number of exercises!!");
                }
                this.exercises = value;
            }
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(this.name);
            str.Append("Number of lectures: ");
            str.AppendLine(this.NumberOfLectures.ToString());
            str.Append("Number of exercises: ");
            str.AppendLine(this.NumberOfExercises.ToString());

            return str.ToString();
        }
    }  
}
