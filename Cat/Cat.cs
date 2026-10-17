using System;

namespace Animal
{
    public class Cat : IAnimal
    {
        /// <summary>
        /// This is the name of the Animal
        /// </summary>
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            // TODO: 
            Console.WriteLine("Cat says: Meow");
        }
    }
}
