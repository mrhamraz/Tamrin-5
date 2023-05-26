using System;

namespace _01._Creat_a_Class_with_details_of_a_student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Enter first name:");
            student.firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            student.lastName = Console.ReadLine();

            Console.WriteLine("Enter age:");
            student.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter grade:");
            student.grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter school name:");
            student.schoolName = Console.ReadLine();

            student.Print();
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
                Console.WriteLine($"Name: {firstName} \nLast Name: {lastName} \nAge: {age} \nGrade: {grade} \nSchool Name: {schoolName} ");
            }
        }
    }
}
