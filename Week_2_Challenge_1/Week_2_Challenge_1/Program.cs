namespace Week_2_Challenge_1;
internal class Program
{
    static void Main(string[] args)
    {
        string[] codes = new string[]{
            "8638[3]",
            "3974[9]",
            "8645[6]",
            "9163[8]",
            "1936[9]",
            "2314[1]",
            "3245[3]",
            "5674[4]"
        };

        int sumOfValidChecksums = 0;

        for(int i = 0; i < codes.Length; i++){
            Console.Write(isValidChecksum(codes[i]) ? "\t" : "");
            Console.Write($"Code {codes[i]} is ");
            Console.WriteLine(isValidChecksum(codes[i]) ? "valid." : "NOT valid");
            sumOfValidChecksums += isValidChecksum(codes[i]) ? checksum(codes[i]) : 0;
        }

        Console.WriteLine($"The sum of all valid checksums is: {sumOfValidChecksums}");
    }

    public static bool isValidChecksum(string code) {
        return checksum(code) == int.Parse(code[5].ToString());
    }

    public static int checksum(string code){
        // Checksum:
        // Product of characters
        // Iterative sum of result
        int product = 1;
        for(int i = 0; i < 4; i++) product *= int.Parse(code[i].ToString());

        return iterativeSum(product);
    }

    public static int iterativeSum(int number){
        if(number < 10) return number;

        int sum = 0;

        while(number > 0){
            sum += number % 10;
            number /= 10;
        }
        
        return iterativeSum(sum);
    }
}
