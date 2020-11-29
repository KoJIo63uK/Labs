using System.Collections.Generic;

namespace Lab8
{
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