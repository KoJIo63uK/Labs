using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>{1,4,6,9,12,3,15,16,2,3};
            var number = int.Parse(Console.ReadLine());

            var summ = 0;
            string message = "";
            foreach (var item in list)
            {
                if (item > number)
                {
                    summ += item;
                    message += $"{item} + ";
                }
            }

            message = message.Substring(0, message.Length - 3);
            Console.WriteLine($"{message} = {summ}");
        }
    }
}