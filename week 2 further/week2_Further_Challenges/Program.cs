namespace week2_Further_Challenges;
internal class Program
{
    static void Main(string[] args)
    {
        var tc = new TemperatureConverter();

        tc.F = 32;

        // tc.C = (32 - tc.F) * (5d / 9);

        tc.F = tc.C * 9f / 5 + 32;

        Console.WriteLine($"Celsius = {tc.C} Farenheit = {tc.F}");
    }
}
