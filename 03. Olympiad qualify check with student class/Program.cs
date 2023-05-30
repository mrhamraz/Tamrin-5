using System;

namespace _03._Olympiad_qualify_check_with_student_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter grade:");
            Student student = new Student(Convert.ToDouble(Console.ReadLine()));

            student.Print();
            student.Olympiad();
            
        }

        class Student
        {
            public string firstName;
            public string lastName;
            public int age;
            public double grade;
            public string schoolName;

            public Student(double num)
            {
                firstName = "default";
                lastName = "default";
                age = 0;
                grade = num;
                schoolName = "default";
            }

            public void Print()
            {
                Console.WriteLine($"\nName: {firstName} \nLast Name: {lastName} \nAge: {age} \nGrade: {grade} \nSchool Name: {schoolName} ");
            }
            public void Olympiad()
            {
                if (grade > 15)
                    Console.WriteLine("\nCan enter Olympiad");
                else
                    Console.WriteLine("\nCan Not enter Olympiad");
            }
        }
    }
}
