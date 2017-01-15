using System;
using System.Collections.Generic;
using System.Linq;

namespace _02StudentsAdWokers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List <Student> students = new List<Student>()
            {
                new Student("Pesho", "Peshev", 6.00),
                new Student("Gosho", "Peshev", 5.00),
                new Student("Strahil", "Peshev", 4.00),
                new Student("Plesho", "Peshev", 3.00),
                new Student("Stamat", "Peshev", 2.00),
                new Student("Haralampi", "Peshev", 5.45),
                new Student("Ivan", "Peshev", 3.25),
                new Student("Dragan", "Peshev", 2.99),
                new Student("Hoshimin", "Peshev", 4.58),
                new Student("Gasho", "Peshev", 5.49),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Pesho", "Peshev",1568.78m, 60),
                new Worker("Gosho", "Peshev",769.58m, 78),
                new Worker("Strahil", "Peshev", 569.36m, 45.45),
                new Worker("Plesho", "Peshev", 8488.36m, 89.25),
                new Worker("Stamat", "Peshev",123.45m, 45.36),
                new Worker("Haralampi", "Peshev", 965.36m, 125.36),
                new Worker("Ivan", "Peshev",365.89m, 70.25),
                new Worker("Dragan", "Peshev", 698.37m, 120.90),
                new Worker("Hoshimin", "Peshev", 542.39m, 50),
                new Worker("Gasho", "Peshev", 658.56m, 100),
            };
            // Sort Students by grade
            var sortedStudentsByGrade =
                from student in students
                orderby student.Grade
                select student;
            // Sort Workers by MoneyPerHour() method
            var sortedWorkersByMoneyPerHour =
                from worker in workers
                orderby worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay)
                select worker;
            // Print sorted lists
            Console.WriteLine("Students sorted by grade:");

            foreach (var student in sortedStudentsByGrade)
            {
                Console.WriteLine(student.ConsoleLog()); 
            }

            Console.WriteLine("*************************");

            Console.WriteLine("Workerssorted by money per hour payment:");

            foreach (var worker in sortedWorkersByMoneyPerHour)
            {
                Console.Write(worker.ConsoleLog());
                Console.WriteLine("Payment by hour: {0:f2}", worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay));
                Console.WriteLine();
            }
             //Merge and sort
            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
         
        }
    }
}
