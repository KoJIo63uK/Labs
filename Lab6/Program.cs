using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivanov = new Student("Ivan", "Ivanov", new DateTime(1759, 5, 15), 4);
            var petrov = new Student("Petr", "Petrov", new DateTime(1999, 9, 9), 5);
            
            var group = new Group("Nice boys");
            Console.WriteLine(group);
            
            group.Add(ivanov);
            group.Add(petrov);
            Console.WriteLine(group);

            Console.WriteLine(group.SearchBySecondName("Petrov"));
            Console.WriteLine(group.SearchByScore(4));
            Console.WriteLine(group.SearchByBirthday(new DateTime(1999, 9, 9)));

            group.Delete(ivanov);
            Console.WriteLine(group);
        }
    }

    public class Group
    {
        public string Name { get; set; }
        public int Count => _students.Count;

        private List<Student> _students = new List<Student>();

        public Group(string name)
        {
            Name = name;
        }

        public Student SearchBySecondName(string secondName)
        {
            return _students.Find(s => s.SecondName == secondName);
        }

        public Student SearchByScore(int score)
        {
            return _students.Find(s => s.Score == score);
        }

        public Student SearchByBirthday(DateTime birthday)
        {
            return _students.Find(s => s.Birthday == birthday);
        }

        public void Add(Student student)
        {
            Console.WriteLine($"Add student {student} to group {Name}");
            _students.Add(student);
        }

        public void Delete(Student student)
        {
            Console.WriteLine($"Remove student {student} from group {Name}");
            _students.Remove(student);
        }

        public override string ToString()
        {
            var group = $"{Name}\n";
            foreach (var student in _students)
            {
                group += $"{student}\n";
            }

            return group;
        }
    }
    
    public class Student
    {
        public string FullName => $"{_secondName} {_name}";
        public string SecondName => _secondName;
        public DateTime Birthday { get; }

        public int Score { get; set; }
        
        private readonly string _name;
        private readonly string _secondName;

        public Student(string name, string secondName, DateTime birthday, int score)
        {
            _name = name;
            _secondName = secondName;
            Birthday = birthday;
            Score = score;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}