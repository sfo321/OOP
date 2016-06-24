namespace School
{
    using Models;
    using Disciplines;
    using School;

    class Test
    {
        static void Main()
        {
            var Gosho = new Student("Gosho", "Petrov", 1);
            Gosho.Comment = "Gosho e losh!!!";
            var Pesho = new Student("Pesho", "Karadjov", 2);
            Pesho.Comment = "Pesho e poslushen!";


            var teacher = new Teacher("Ivan", "Ivanov");

            var math = new Discipline("Mathematics", 40, 40);
            var bio = new Discipline("Biology", 50, 50);
            var eng = new Discipline("English", 60, 60);
            var che = new Discipline("Chemistry", 30, 30);
            teacher.Comment = "Basi Dryndioto";

            teacher.AddDiscipline(bio);
            teacher.AddDiscipline(math);
            teacher.AddDiscipline(eng);
            teacher.AddDiscipline(che);


            SchoolClass Class = new SchoolClass("FirstC");
            SchoolClass OtherClass = new SchoolClass("FirstB");
            Class.AddTeacher(teacher);
            Class.AddStudent(Gosho);
            Class.AddStudent(Pesho);
            //Class.AddStudent(Pesho);

            var NewSchool = new Schooll();
            NewSchool.AddClass(Class);

            NewSchool.SchoolInfo();

            
                         
        }
    }
}
