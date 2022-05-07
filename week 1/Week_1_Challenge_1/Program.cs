namespace Week_1_Challenge_1;
using Week_1_Challenge_1Library;
internal class Program
{
    static void Main(string[] args)
    {
        var point1 = new Point(-4, -5);
        var point2 = new Point(-1,-1);

        double distance = Point.Distance(point1, point2);

        // slope is rise over run, so the denominator is run
        double denominator = Point.Run(point1, point2);

        int greatestCommonDenominator = FancyMathsStuff.GCD(1124, 136);

        Console.WriteLine(greatestCommonDenominator);

        // Initially Forgot to Square this
        // Might be a good idea to read questions properly
        int remainder = (int) Math.Pow(FancyMathsStuff.SumTo(10), 2) % 10;

        Console.WriteLine($"Answer to Q1: {distance}");
        Console.WriteLine($"Answer to Q2: {denominator}");
        Console.WriteLine($"Answer to Q3: {greatestCommonDenominator}");
        Console.WriteLine($"Answer to Q4: {remainder}");
    }
}