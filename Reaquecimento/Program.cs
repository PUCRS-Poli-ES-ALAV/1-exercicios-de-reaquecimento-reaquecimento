namespace Reaquecimento
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Possibilities(3);
            Console.WriteLine("Result:");
            Console.WriteLine(string.Join(", ", result));
        }
        static int Multiply(int number, int multiplier)
        {
            if (multiplier == 1) return number;
            return Multiply(number, multiplier - 1) + number;
        }
        static int Sum(int a, int b)
        {
            if (b == 0) return a;
            return Sum(a + 1, b - 1);
        }
        static double SumRest(int number)
        {
            if (number == 1) return 1.0;
            return SumRest(number - 1) + (1.0 / number);
        }
        static string InvertString(string str, int num = 0)
        {
            if (num == str.Length) return string.Empty;
            return InvertString(str, num + 1) + str[num];
        }
        static int Func(int num)
        {
            if (num == 1) return 1;
            if (num == 2) return 2;
            return (2 * Func(num - 1)) + (3 * Func(num - 2));
        }
        static int Ackerman(int m, int n)
        {
            if (m == 0) return n + 1;
            if (n == 0) return Ackerman(m - 1, 1);
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
        static (int sum, int product) SumAndProduct(int[] vector)
        {
            if (vector.Length == 0) return (0, 1);
            var sum = SumAndProduct(vector[1..]).sum + vector[0];
            var product = SumAndProduct(vector[1..]).product * vector[0];
            return (sum, product);
        }
        static bool IsPalindrome(string str)
        {
            if (str.Length == 1 || str.Length == 0) return true;
            if (str.First() != str.Last()) return false;
            return IsPalindrome(str.Substring(1, str.Length - 2));
        }
        // 0 -> []
        // 1 -> [A]
        // 2 -> [AB, BA]
        // 3 -> [ABC, ACB, BAC, BCA, CAB, CBA]
        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static List<string> Possibilities(int num, int option = 0)
        {
            if (num <= 0 || num > 26) return [];
            var options = Factorial(num);
            if (options == option) return [];
            var usableAlphabet = alphabet[..num];
            return Possibilities(num, option + 1).Append(OptionOrder(option, usableAlphabet)).ToList();
        }
        static string OptionOrder(int option, string segment)
        {
            return segment;
        }
        static int Factorial(int num)
        {
            if (num == 1) return 1;
            return Factorial(num - 1) * num;
        }
    }
}