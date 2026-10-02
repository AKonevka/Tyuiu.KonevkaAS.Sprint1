using Tyuiu.KonevkaAS.Sprint1.Task3.V19.Lib;
namespace Tyuiu.KonevkaAS.Sprint1.Task3.V19.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 3;
            double y1 = 4;
            double y2 = 5;
            bool res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.AreEqual(false, res);
        }
    }
}