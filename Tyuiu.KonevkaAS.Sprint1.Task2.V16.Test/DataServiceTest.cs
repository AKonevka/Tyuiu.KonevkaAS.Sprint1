using Tyuiu.KonevkaAS.Sprint1.Task2.V16.Lib;
namespace Tyuiu.KonevkaAS.Sprint1.Task2.V16.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            float x = 2;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(x, res);
        }
    }
}