using System.Collections.Generic;

namespace Lab8
{
    public abstract class ArrayItem
    {
        public int Value { get; set; }
        public abstract void Action(int currentIndex, List<ArrayItem> array);

        public ArrayItem(int value)
        {
            Value = value;
        }
    }
}