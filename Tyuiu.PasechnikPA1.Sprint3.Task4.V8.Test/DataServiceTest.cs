using Tyuiu.PasechnikPA1.Sprint3.Task4.V8.Lib;
namespace Tyuiu.PasechnikPA1.Sprint3.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2237.227;
            Assert.AreEqual(wait, res);
        }
    }
}
