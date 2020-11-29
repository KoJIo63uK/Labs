using System;
using System.Collections.Generic;

namespace Lab6
{
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
}