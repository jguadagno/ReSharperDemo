using System;

namespace Animal
{
    public interface IAnimal
    {
        /// <summary>
        /// This is the name of the Animal
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// This is the age of the animal
        /// </summary>
        int Age { get; set; }
        /// <summary>
        /// This happens when the animal speaks
        /// </summary>
        void Speak();
    }
}