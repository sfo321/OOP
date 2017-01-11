using System;
using OOP_Principles_Part1_HW.Models;
using OOP_Principles_Part1_HW.Utils;

namespace OOP_Principles_Part1_HW
{
    public class Strtup
    {
        static void Main()
        {
            // School class One           
            var student1 = new Student("Pesho", "Peshev");
            student1.Comment = "Very good student";
            var student2 = new Student("Djordjano", "Puhlev");
            student2.Comment = "Pone da smetnesh 2 + 2, a? To peeneto e qsno...";
            var student3 = new Student("Fiki", "Strugarov");
            student3.Comment = "Izdislav go nqma, ne rzabra li?";
            var student4 = new Student("Azis", "Kretenchev");
            student4.Comment = "Matematikata ne e kato peeneto";
            var student5 = new Student("Bojko", "Borisov");
            student5.Comment = "Very bad student";

            var maths = new Discipline(Disciplines.Mathematics, 80, 40);
            var info = new Discipline(Disciplines.Informatics, 100, 60);
            var bio = new Discipline(Disciplines.Biology, 60, 30);
            var che = new Discipline(Disciplines.Chemistry, 70, 25);

            var teacher1 = new Teacher("Kalkulator", "Ivanovich");
            teacher1.Comment = "Bad Teacher";
            teacher1.AddDiscipline(maths);
            teacher1.AddDiscipline(info);

            var teacher2 = new Teacher("Kolio", "Himikala");
            teacher2.Comment = "Neshto izpushi tam...";
            teacher2.AddDiscipline(bio);
            teacher2.AddDiscipline(che);

            var schoolClass1 = new SchoolClass(4);
            schoolClass1.Comment = "Mnooo losh Klas e toq!";

            schoolClass1.AddTeacher(teacher1);
            schoolClass1.AddTeacher(teacher2);

            schoolClass1.AddStudent(student1);
            schoolClass1.AddStudent(student2);
            schoolClass1.AddStudent(student3);
            schoolClass1.AddStudent(student4);
            schoolClass1.AddStudent(student5);

            var school = new School();

            school.AddClass(schoolClass1);

            Console.WriteLine(school);


            // School class Two           
            var student6 = new Student("Hasan", "Reje");
            student6.Comment = "Shte ima klyc - klyc hahahaa";
            var student7 = new Student("Tatko", "Raza");
            student7.Comment = "Maj pak mi e losho";
            var student8 = new Student("Mustafa", "Karadaia");
            student8.Comment = "Odi si u turciq be bastun";
            var student9 = new Student("Volen", "Siderov");
            student9.Comment = "Kade e Hitler sega, a?";
            var student10 = new Student("Rosen", "Plevneliev");
            student10.Comment = "Very bad student";

            var mus = new Discipline(Disciplines.Music, 80, 40);
            var eng = new Discipline(Disciplines.English, 100, 60);
            var biol = new Discipline(Disciplines.Biology, 60, 30);
            var phy = new Discipline(Disciplines.Physics, 70, 25);

            var teacher3 = new Teacher("Svircho", "Kavalov");
            teacher3.Comment = "Kuku teacher";
            teacher3.AddDiscipline(mus);
            teacher3.AddDiscipline(eng);

            var teacher4 = new Teacher("Djaba", "Debelia");
            teacher4.Comment = "Tralala teacher";
            teacher4.AddDiscipline(biol);
            teacher4.AddDiscipline(phy);

            var schoolClass2 = new SchoolClass(6);
            schoolClass2.Comment = "Mnooo dobar Klas e toq!";

            schoolClass2.AddTeacher(teacher3);
            schoolClass2.AddTeacher(teacher4);

            schoolClass2.AddStudent(student6);
            schoolClass2.AddStudent(student7);
            schoolClass2.AddStudent(student8);
            schoolClass2.AddStudent(student9);
            schoolClass2.AddStudent(student10);

            var school1 = new School();

            school1.AddClass(schoolClass2);


            Console.WriteLine(school1);
        }
    }
}
