using Tyuiu.MenshchikovaDA.Lab2.Review.V6.Lib;

namespace Tyuiu.MenshchikovaDA.Lab2.Review.V6.Test
{
    public class Tests
    {
        [Test]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = 3;
            int stopValue = 7;

            double[][] true_result = [[3, 1.17], [4, 0.17], [5, 0.09], [6, 1.82], [7, -15.48]];

            double[][] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(result,true_result);
        }

    }
}