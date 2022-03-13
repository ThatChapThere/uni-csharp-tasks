namespace Week_1_Challenge_1Library;
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
}