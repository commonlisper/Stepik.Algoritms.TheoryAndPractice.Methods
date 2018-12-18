using static System.Console;
using static System.Convert;

/// <summary>
/// Дано целое число 1 ≤ n ≤ 40, необходимо вычислить n-е число Фибоначчи 
/// напомним, что F0 = 0, F1 = 1 и Fn = Fn−1 + Fn−2 при n ≥ 2).
///
/// Sample Input:
/// 3
///
/// Sample Output:
/// 2
/// </summary>

namespace _01.Introduction.Ex01
{
    class Program
    {
        public static void Main()
        {
            int n = ToInt32(ReadLine());

            WriteLine(Fib(n));
        }

        public static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            var fibArray = new int[n + 1];
            fibArray[0] = 0;
            fibArray[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }

            return fibArray[n];
        }
    }
}
