using System;

namespace Animal
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine("Dog says: Woof");
        }
    }
}