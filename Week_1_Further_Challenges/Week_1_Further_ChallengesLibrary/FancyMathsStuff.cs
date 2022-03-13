namespace Week_1_Further_ChallengesLibrary;
public class FancyMathsStuff{
    public static int GCD(int a, int b){
        if(b > a){
            int t = a;
            a = b;
            b = t; 
        }
        // We will use Euclid's Algorithm
        int temp;
        while(b != 0){
            temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int SumTo(int n) => n * (n + 1) / 2;
    public static int NumberOfMultiplesUpTo(int largeNumber, int SmallNumber) => (largeNumber - 1) / SmallNumber;
    public static int SumOfMultiplesUpTo(int largeNumber, int SmallNumber){
        return SmallNumber * SumTo(NumberOfMultiplesUpTo(largeNumber, SmallNumber)); 
    }
    public static int SumOfFibMultiplesOfN1UpToN2(int n1, int n2){
        int a = 1, b = 1, sum = 0, temp;
        while(a < n2) {
            sum += a %n1 == 0 ? a : 0;
            temp = a;
            a = a + b;
            b = temp;
        }
        return sum;
    }
}