using System;

namespace Lab6
{
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