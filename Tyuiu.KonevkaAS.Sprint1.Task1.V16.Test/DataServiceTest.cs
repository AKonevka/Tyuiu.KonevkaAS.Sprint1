using Tyuiu.KonevkaAS.Sprint1.Task1.V16.Lib;
namespace Tyuiu.KonevkaAS.Sprint1.Task1.V16.Test
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
            Assert.Pass();
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double a = 3.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(x, res);

        }


    }
}