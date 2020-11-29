using System.Collections.Generic;

namespace Lab8
{
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
}