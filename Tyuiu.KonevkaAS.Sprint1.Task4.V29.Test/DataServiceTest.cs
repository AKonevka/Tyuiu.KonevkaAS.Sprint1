using Tyuiu.KonevkaAS.Sprint1.Task4.V29.Lib;
namespace Tyuiu.KonevkaAS.Sprint1.Task4.V29.Test
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
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}