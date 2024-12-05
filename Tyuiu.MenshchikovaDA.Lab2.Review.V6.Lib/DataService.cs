namespace Tyuiu.MenshchikovaDA.Lab2.Review.V6.Lib
{
    public class DataService
    {
        public double[][] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            int n = stopValue - startValue + 1;

            double[][] result = new double[n][];

            double x = startValue;

            for (int i = 0; i < n; i++)
            {
                result[i] = new double[2];
                result[i][0] = x;
                result[i][1] = Math.Round((1 + Math.Sin(Math.Sqrt(Math.Pow(x, 2) + 1))) / (Math.Cos(12 * x - 4)), 2);
                x++;
            }

            return result;
        }
    }
}
