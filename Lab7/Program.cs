using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ListItem[]
            {
                new ListItem(0,1),
                new ListItem(1,2),
                new ListItem(2,3),
                new ListItem(3,4),
                new ListItem(4, null), 
            };

            var number = int.Parse(Console.ReadLine());
            var summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i].Summ(number, array);
            }

            Console.WriteLine(summ);
        }

        public class ListItem
        {
            public int Value { get; set; }
            public int? Next { get; set; }

            public ListItem(int value, int? next)
            {
                Value = value;
                Next = next;
            }

            public int Summ(int number, ListItem[] array)
            {
                return Value > number ? Value : 0;
            }
        }
    }
}