using System;

namespace CatTemplate
{
    public class NoneCat : Cat
    {
        public override void Meow()
        {
            Console.WriteLine("Gav");
        }

        public void None()
        {
            Console.WriteLine("None");
        }
    }
}