using System;

namespace Animal
{
    public class ThisIsAReallyLongName : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine("ThisIsAReallyLongName says: SuperCal....");
        }
    }
}