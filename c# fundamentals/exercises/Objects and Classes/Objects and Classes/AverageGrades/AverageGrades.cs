using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class AverageGrades
    {
        class Student
        {
            public string name { get; set; }
            public List<double> grades { get; set; }
            public double Average(List<double> grades)
            {
                return grades.Average();
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = ReadStudent();
            }
            students.Where(s => s.Average(s.grades) >= 5.00)
                .OrderByDescending(s => s.Average(s.grades)).OrderBy(s => s.name).ToList()
                .ForEach(x => Console.WriteLine("{0} -> {1:f2}", x.name, x.Average(x.grades)));
        }

        private static Student ReadStudent()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Student s = new Student()
            {
                name = input[0],
                grades = input.Where((x, pos) => pos > 0)
                .Select(double.Parse).ToList()
            };

            return s;
        }
    }
}
