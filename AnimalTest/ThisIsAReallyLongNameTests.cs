using Animal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTest
{
    [TestClass]
    public class ThisIsAReallyLongNameTest
    {
        [TestMethod]
        public void TestThisIsAReallyLongNameAge()
        {
            int age = 5;
            var thisIsAReallyLongName = new ThisIsAReallyLongName {Age = 5};
            Assert.AreEqual(age, thisIsAReallyLongName.Age);
        }

        [TestMethod]
        public void TestThisIsAReallyLongNameName()
        {
            string name = "Spike";
            var thisIsAReallyLongName = new ThisIsAReallyLongName() {Name = "Spike"};
            Assert.AreEqual(name, thisIsAReallyLongName.Name);
        }
    }
}