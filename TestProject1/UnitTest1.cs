using NUnit.Framework;
using project1.Controllers;

namespace TestProject1
{
    public class Tests
    {
        private studentController controller;
        [SetUp]
        public void Setup()
        {
            controller = new studentController();
        }

        [Test]
        public void Test1()
        {
            var result=controller.GetUsers();
            Assert.IsNotNull(result);
            
            Assert.Pass();
        }
    }
}