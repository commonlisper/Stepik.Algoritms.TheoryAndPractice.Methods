using static System.Console;
using static System.Convert;

/// <summary>
/// Дано число 1 ≤ n ≤ 10^7, необходимо найти последнюю цифру n-го числа Фибоначчи.
///
/// Как мы помним, числа Фибоначчи растут очень быстро, поэтому при их вычислении нужно быть аккуратным с переполнением. 
/// В данной задаче, впрочем, этой проблемы можно избежать, поскольку нас интересует только последняя цифра числа Фибоначчи: если 0 ≤ a,b ≤ 9
/// — последние цифры чисел Fi и Fi+1 соответственно, то (a+b) mod 10 — последняя цифра числа Fi+2.
///
/// Sample Input:
/// 317457
///
/// Sample Output:
/// 2
/// </summary>

namespace _01.Introduction.Ex02
{
    class Program
    {
        public static void Main()
        {
            int n = ToInt32(ReadLine());

            WriteLine(FibLastNumber(n));
        }

        public static int FibLastNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            int[] fibArray = new int[n + 1];
            fibArray[0] = 0;
            fibArray[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                fibArray[i] = (fibArray[i - 1] + fibArray[i - 2]) % 10;
            }

            return fibArray[n];
        }
    }
}
