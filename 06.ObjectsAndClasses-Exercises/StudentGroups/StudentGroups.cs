using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> towns = GetTownsAndStudents();
            List<Group> groups = DistributeStudentsIntroGroups(towns);
            PrintGroups(groups, towns);
        }

        private static void PrintGroups(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var group in groups)
            {
                Console.WriteLine("{0}=> {1}",
                    group.Town,
                    string.Join(", ", group.Students.Select(x => x.Email).ToList()));
            }
        }

        private static List<Group> DistributeStudentsIntroGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                List<Student> students =
                    town.Students
                    .OrderBy(X => X.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (students.Any())
                {
                    Group currentGroup = new Group();
                    currentGroup.Town = town.Name;
                    currentGroup.Students = students.Take(town.NumberOfSeats).ToList();
                    groups.Add(currentGroup);
                    students = students.Skip(town.NumberOfSeats).ToList();
                }
            }
            return groups;
        }

        private static List<Town> GetTownsAndStudents()
        {
            List<Town> towns = new List<Town>();
            List<Student> students = new List<Student>();
            string[] data;
            string input = Console.ReadLine();

            char[] townSeparator = "=>".ToCharArray();
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    data = input.Split(townSeparator, StringSplitOptions.RemoveEmptyEntries);
                    string[] seats = data[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Town currentTown = new Town()
                    {
                        Name = data[0],
                        NumberOfSeats = int.Parse(seats[0]),
                        Students = new List<Student>()
                    };
                    towns.Add(currentTown);
                }
                else
                {
                    data = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student currentStudent = new Student()
                    {
                        Name = data[0].Trim(),
                        Email = data[1].Trim(),
                        RegistrationDate =
                        DateTime.ParseExact(data[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };
                    towns[towns.Count - 1].Students.Add(currentStudent);
                }
                input = Console.ReadLine();
            }
            return towns;
        }
    }

    class Group
    {
        public string Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public List<Student> Students { get; set; }
    }
}
