namespace Week_1_Further_Challenges;

using Week_1_Further_ChallengesLibrary;
internal class Program
{
    static void Main(string[] args)
    {
        string mainString = "School of Computer Science";

        string removedSpaces = string.Join("", (string[]) mainString.Split(" "));

        int characterCount = numberOfCharacters(mainString);

        int sumOfMultiples = 
            FancyMathsStuff.SumOfMultiplesUpTo(1000, 3)
            + FancyMathsStuff.SumOfMultiplesUpTo(1000, 5)
            - FancyMathsStuff.SumOfMultiplesUpTo(1000, 15);
        
        int sumOfFib = FancyMathsStuff.SumOfFibMultiplesOfN1UpToN2(2, 4000000);

        Console.WriteLine($"Answer to Q1: {removedSpaces}");
        Console.WriteLine($"Answer to Q2: {characterCount} - Confirmation: {mainString.Length}");
        Console.WriteLine($"Answer to Q3:");
        Console.WriteLine($"    Part a: {sumOfMultiples}");
        Console.WriteLine($"    Part b: {sumOfFib}");
    }
    static int numberOfCharacters(string s) {
        int n = 0;
        while(s != ""){
            s = s.Remove(0, 1);
            n++;
        }
        return n;
    }
}
