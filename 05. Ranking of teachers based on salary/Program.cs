using System;

namespace _05._Ranking_of_teachers_based_on_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary of teacher:");

            Teacher teacher = new Teacher(Convert.ToInt32(Console.ReadLine()));

            teacher.Print();
            teacher.Ranking();
        }


        class Teacher
        {
            public string name;
            public string specialty;
            public int salary;

            public Teacher(int Salary)
            {
                name = "default";
                specialty = "default";
                salary = Salary;
            }

            public void Print()
            {
                Console.WriteLine($"\nName: {name} \nspecialty: {specialty} \nSalary: {salary} ");
            }

            public void Ranking()
            {
                if (salary > 10)
                    Console.WriteLine("\nRanking : A");

                else if (salary <= 10 && salary > 5 )
                    Console.WriteLine("\nRanking : B");

                else
                    Console.WriteLine("\nRanking : C");
            }
            
        }
    }
}

