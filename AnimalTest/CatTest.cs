using Animal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTest
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void TestCatAge()
        {
            int age = 5;
            var cat = new Cat {Age = 5};
            Assert.AreEqual(age, cat.Age);
        }

        [TestMethod]
        public void TestCatName()
        {
            string name = "Spike";
            var cat = new Cat() {Name = "Spike"};
            Assert.AreEqual(name, cat.Name);
        }
    }
}