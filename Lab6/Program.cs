using System;

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
}