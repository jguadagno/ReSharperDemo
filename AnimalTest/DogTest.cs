using Animal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTest
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void TestDogAge()
        {
            int age = 5;
            var dog = new Dog {Age = 5};
            Assert.AreEqual(age, dog.Age);
        }

        [TestMethod]
        public void TestDogName()
        {
            string name = "Spike";
            var dog = new Dog() {Name = "Spike"};
            Assert.AreEqual(name, dog.Name);
        }
    }
}