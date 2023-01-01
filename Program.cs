using System;
using System.Collections.Generic;
using System.Linq;

class codeforces
{
    //Start of Input/Output Methods
    static int[] getIntArr() => Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    static long[] getLongArr() => Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
    static double[] getDoubleArr() => Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
    static string[] getWords() => Console.ReadLine().Split(' ');
    static int getInt() => Convert.ToInt32(Console.ReadLine().Trim());
    static void printArr<T>(T[] x)
    {
        for (var i = 0; i < x.Length; i++) Console.Write($"{x[i]} "); Console.WriteLine();
    }
    //End of Input/Output Methods


    //Start of Helper functions
    static int gcd(int a,int b){if (b == 0) return a;return gcd(b, (a % b));}
    static int lcm(int a, int b) => a * b / gcd(a, b);
    static int bitCount(int num){int count = 0;while (num != 0){num &= num - 1;count++;}return count;}
    //End of Helper functions


    //Start of Auxiliary Function
    //End of Auxiliary Function


    //Start of Solve Function
    static void solve()
    {
        getInt();
        long[] arr = getLongArr();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%14<7)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
    //End of Solve Function


    static void Main()
    {
        int test = 1;
        //test = getInt();
        while (test-- > 0)
        {
            solve();
        }
    }
}