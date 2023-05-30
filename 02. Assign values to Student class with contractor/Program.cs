using System;

namespace _02._Assign_values_to_Student_class_with_contractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Mammad", "Hamraz");

            student1.Print();
            student2.Print();
            
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


            public Student()
            {
                firstName = "default";
                lastName = "default";
                age = 0;
                grade = 0;
                schoolName = "default";
            }

            public Student(string fname,string lname)
            {
                firstName = fname;
                lastName = lname;
                age = 25;
                grade = 19.5;
                schoolName = "Iran";
            }


        }

    }

}
