using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = GetArray(5);

            for (int i = 0; i < list.Length; i++)
            {
                list[i].Action(i, list);
                Console.WriteLine(list[i].Value);
            }
        }
        
        public static ArrayItem[] GetArray(int count)
        {
            var random = new Random((int) DateTime.Now.Ticks);
            var array = new ArrayItem[count];
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = new SummAfterItem(random.Next(10));
                }
                else
                {
                    array[i] = new SummBeforeItem(random.Next(10));
                }

                Console.Write($"{array[i].Value} ");
            }

            Console.WriteLine();
            return array;
        }
    }

    public abstract class ArrayItem
    {
        public int Value { get; set; }
        public abstract void Action(int currentIndex, ArrayItem[] array);

        public ArrayItem(int value)
        {
            Value = value;
        }
    }
    
    public class SummAfterItem : ArrayItem
    {
        public override void Action(int currentIndex, ArrayItem[] array)
        {
            for (int i = currentIndex + 1; i < array.Length; i++)
            {
                if (array[i].Value % 2 == 0)
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
        public override void Action(int currentIndex, ArrayItem[] array)
        {
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                if (array[i].Value % 2 == 0)
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