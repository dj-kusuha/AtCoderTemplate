using System;
using System.Runtime.CompilerServices;

namespace AtCoder.Problems
{
    public class ProblemA
    {
        public static void Main(string[] args)
        {
            var s = new SolveA();
            s.Solve();
        }

        public class Scanner
        {
            private string[] _s;
            private int _i;
            private readonly char[] _separators = new char[] { ' ' };

            public Scanner()
            {
                _s = new string[0];
                _i = 0;
            }

            public string Next()
            {
                if (_i < _s.Length) return _s[_i++];
                string st = Console.ReadLine();
                while (st == "") st = Console.ReadLine();
                _s = st.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
                if (_s.Length == 0) return Next();
                _i = 0;
                return _s[_i++];
            }

            public int NextInt() => int.Parse(Next());
            public long NextLong() => long.Parse(Next());
            public ulong NextULong() => ulong.Parse(Next());
            public double NextDouble() => double.Parse(Next());

            public int[] GetIntArray(int n, int add = 0)
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = NextInt() + add;
                }
                return array;
            }

            public long[] GetLongArray(int n, long add = 0)
            {
                long[] array = new long[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = NextLong() + add;
                }
                return array;
            }

            public double[] GetDoubleArray(int n, double add = 0)
            {
                double[] array = new double[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = NextDouble() + add;
                }
                return array;
            }

            public string[] GetStringArray(int n)
            {
                string[] array = new string[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = Next();
                }
                return array;
            }
        }

        public static class MathLib
        {
            /// <summary>
            /// 最大公約数
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long gcd(long a, long b) => b > 0 ? gcd(b, a % b) : a;

            /// <summary>
            /// 最小公倍数
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long lcm(long a, long b) => a / gcd(a, b) * b;
        }
    }

    public class SolveA
    {
        public void Solve()
        {
            var cin = new ProblemA.Scanner();
            var n = cin.NextLong();

            var result = GetAnswer(n);
            Console.WriteLine(result);
        }

        public string GetAnswer(long n)
        {
            return null;
        }
    }
}
