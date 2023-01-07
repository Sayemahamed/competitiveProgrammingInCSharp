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
        int[]arr=getIntArr();
        string s=Console.ReadLine();
        if (arr[0] == 1 && arr[1]>0) { Console.WriteLine(0);return; }
        char[] sArr=s.ToCharArray();
        if (sArr[0] != '1' && arr[1]>0) { sArr[0] = '1'; arr[1]--; }
        for(int i = 1; i < sArr.Length; i++) 
        {
            if (arr[1] <= 0) break;
            if (sArr[i] != '0')
            {
                sArr[i] = '0';
                arr[1]--;
            }
        }
        printArr(sArr);
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