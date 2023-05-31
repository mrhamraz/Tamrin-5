using System;

namespace _06._Print_student_informations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"ali","mammad","hasan" }; 

            /*
              for (int i = 0; i < students.Length; i++)
                Student student[i] = new Student();
            */
        }

        class Student
        {
            public string firstName;
            public string lastName;
            public int age;
            public double grade;
            public string schoolName;

            public void Print()
            {
                Console.WriteLine($"\nName: {firstName} \nLast Name: {lastName} \nAge: {age} \nGrade: {grade} \nSchool Name: {schoolName} ");
            }
        }

    }
}
