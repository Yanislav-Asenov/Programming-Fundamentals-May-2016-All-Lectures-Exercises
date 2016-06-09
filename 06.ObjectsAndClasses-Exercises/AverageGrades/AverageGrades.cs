using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    public class AverageGradess
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                students.Add(new Student());
                students[i].Name = studentInfo[0];
                students[i].Grades = GetStudentGrades(studentInfo);
            }



            List<Student> resultStudens = students.Where(student => student.AverageGrade >= 5.00).ToList();
            resultStudens = resultStudens.OrderBy(student => student.Name).ThenByDescending(student => student.AverageGrade).ToList();
            foreach (var student in resultStudens)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }

        }

        private static double[] GetStudentGrades(string[] studentInfo)
        {
            double[] result = new double[studentInfo.Length - 1];
            int studentsInfoIndex = 1;
            for (int i = 0; i < result.Length; i++)
            {
                double currentGrade = double.Parse(studentInfo[studentsInfoIndex]);
                result[i] = currentGrade;
                studentsInfoIndex++;
            }
            return result;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }
}
