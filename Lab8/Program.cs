using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ArrayItem>
            {
               new SummAfterItem(1),
               new SummAfterItem(2),
               new SummAfterItem(3),
               new SummAfterItem(4),
               new SummBeforeItem(5),
               new SummBeforeItem(6),
               new SummBeforeItem(7),
               new SummBeforeItem(8),
               new SummBeforeItem(9),
               new SummBeforeItem(10)
            };

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Action(i, list);
                Console.WriteLine(list[i].Value);
            }
        }
    }
}