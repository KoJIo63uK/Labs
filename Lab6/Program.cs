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
            group.PrintGroupInfo();
            
            group.Add(ivanov);
            group.Add(petrov);
            group.PrintGroupInfo();

            group.PrintStudentInfo(group.SearchBySecondName("Petrov"));
            group.PrintStudentInfo(group.SearchByScore(4));
            group.PrintStudentInfo(group.SearchByBirthday(new DateTime(1999, 9, 9)));

            group.Delete(ivanov);
            group.PrintGroupInfo();
        }
    }

    public class Group
    {
        public string Name { get; set; }
        public int Count => _students.Length;

        private Student[] _students;

        public Group(string name)
        {
            Name = name;
        }

        public Student SearchBySecondName(string secondName)
        {
            foreach (var item in _students)
            {
                if (item.SecondName == secondName)
                {
                    return item;
                }
            }
            
            return null;
        }

        public Student SearchByScore(int score)
        {
            foreach (var item in _students)
            {
                if (item.Score == score)
                {
                    return item;
                }
            }
            
            return null;
        }

        public Student SearchByBirthday(DateTime birthday)
        {
            foreach (var item in _students)
            {
                if (item.Birthday == birthday)
                {
                    return item;
                }
            }
            
            return null;
        }

        public void Add(Student student)
        {
            if (_students == null)
            {
                _students = new[] {student};
            }
            else
            {
                var newStudents = new Student[_students.Length + 1];
                _students.CopyTo(newStudents, 0);
                newStudents[newStudents.Length - 1] = student;
                _students = newStudents;
            }
            
            Console.WriteLine($"Add student {student} to group {Name}");
        }

        public void Delete(Student student)
        {
            try
            {
                if(_students != null)
                {
                    var newStudents = new Student[_students.Length - 1];
                    var newIndex = 0;
                    for (int i = 0; i < _students.Length; i++)
                    {
                        if (_students[i] != student)
                        {
                            newStudents[newIndex] = _students[i];
                            newIndex++;
                        }
                    }

                    _students = newStudents;
                }
                Console.WriteLine($"Remove student {student} from group {Name}");
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        public void PrintGroupInfo()
        {
            Console.WriteLine(this);
        }

        public void PrintStudentInfo(Student student)
        {
            Console.WriteLine(student);
        }

        public override string ToString()
        {
            var group = $"{Name}\n";
            if(_students != null)
            {
                foreach (var student in _students)
                {
                    group += $"{student}\n";
                }
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
            var info = $"{FullName} Birthday = {Birthday:dd.MM.yyyy} Score = {Score} ";
            return info;
        }
    }
}