using static System.Console;
using static System.Convert;

/// <summary>
/// По данным двум числам 1 ≤ a, b ≤ 2⋅10^9 найдите их наибольший общий делитель.
/// 
/// Sample Input 1:
/// 18 35
///
/// Sample Output 1:
/// 1
///
/// Sample Input 2:
/// 14159572 63967072
///
/// Sample Output 2:
/// 4
/// </summary>

namespace _01.Introduction.Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ReadLine().Split();
            var a = ToInt64(input[0]);
            var b = ToInt64(input[1]);

            WriteLine(Gcd(a, b));
        }

        public static long Gcd(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a >= b)
            {
                return Gcd(a % b, b);
            }
            
            if (b >= a)
            {
                return Gcd(a, b % a);
            }

            return 1;
        }
    }
}
