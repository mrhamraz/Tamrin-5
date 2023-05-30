using System;

namespace _04._Teacher_class_with_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of teacher:");

            Teacher teacher = new Teacher(Console.ReadLine());

            teacher.Print();
        }

        class Teacher
        {
            public string name;
            public string specialty;
            public int salary;

            public Teacher(string Name)
            {
                name = Name;
                specialty = "default";
                salary = 0;
            }

            public void Print()
            {
                Console.WriteLine($"\nName: {name} \nspecialty: {specialty} \nSalary: {salary} ");
            }
        }
    }
}
