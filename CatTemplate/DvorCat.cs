using System;

namespace CatTemplate
{
    public class DvorCat : Cat
    {
        public override void Meow()
        {
            Console.WriteLine("Dvor meow!!");
        }

        public void Say()
        {
            Console.WriteLine("Say");
        }
    }
}