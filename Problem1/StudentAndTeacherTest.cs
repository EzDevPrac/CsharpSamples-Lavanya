using System;

namespace Problem1
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.SetAge(18);
            student.Greet();
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();

        }
    }
}
