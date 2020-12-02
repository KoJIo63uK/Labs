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
    
    public abstract class ArrayItem
    {
        public int Value { get; set; }
        public abstract void Action(int currentIndex, List<ArrayItem> array);

        public ArrayItem(int value)
        {
            Value = value;
        }
    }
    
    public class SummAfterItem : ArrayItem
    {
        public override void Action(int currentIndex, List<ArrayItem> array)
        {
            for (int i = currentIndex + 1; i < array.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Value += array[i].Value;
                }
            }
        }

        public SummAfterItem(int value) : base(value)
        {
        }
    }
    
    public class SummBeforeItem : ArrayItem
    {
        public override void Action(int currentIndex, List<ArrayItem> array)
        {
            for (int i = currentIndex - 1; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Value += array[i].Value;
                }
            }
        }

        public SummBeforeItem(int value) : base(value)
        {
        }
    }
}