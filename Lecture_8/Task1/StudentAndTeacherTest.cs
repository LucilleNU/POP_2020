using System;
namespace Lecture_8.Task1
{
    public class StudentAndTeacherTest
    {
        public void Main()
        {
            Person person = new Person();
            person.Say("Hello!!");

            Student student = new Student();
            student.SetAge(20);
            student.Say("Greeting!");
            student.GoToClasses();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Say("Hello");
            teacher.Explain();

            Console.ReadLine();
        }
    }
}
