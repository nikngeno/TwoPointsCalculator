namespace TwoPointsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Distance(7, 4, 3, 17.0, 6.0, 2.0));
        }
        public static double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            // your code is here
            double d = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
            return d;
        }
    }
}
