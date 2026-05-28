
using ConsoleApp1;
namespace TestProject1
{

    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
                var calcolatrice = new ConsoleApp1.Calcolatrice();
                double result = calcolatrice.Somma(2, 3);
                Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
                var calcolatrice = new ConsoleApp1.Calcolatrice();
                double result = calcolatrice.Sottrazione(5, 2);
                Assert.AreEqual(3, result);
        }

    }
}
