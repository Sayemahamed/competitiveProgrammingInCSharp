using System;
using System.Collections.Generic;
using System.Linq;

class codeforces
{
    //Start of Input/Output Methods
    static int[] getIntArr() => Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    static long[]getLongArr()=>Console.ReadLine().Split(' ').Select(x=>Convert.ToInt64(x)).ToArray();
    static double[]getDoubleArr()=>Console.ReadLine().Split(' ').Select(x=>Convert.ToDouble(x)).ToArray();
    static string[]getWords()=>Console.ReadLine().Split(' ');
    static int getInt()=>Convert.ToInt32(Console.ReadLine().Trim());
    static void printArr<T>(T[] x) {for (var i = 0; i < x.Length; i++)Console.Write($"{x[i]} ");Console.WriteLine();
    }
    //End of Input/Output Methods


    //Start of Auxiliary Function

    //End of Auxiliary Function


    //Start of Solve Function
    static void solve()
    {
        string s= Console.ReadLine().Trim();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a' && s[i] != 'A' && s[i] != 'e' && s[i] != 'E' && s[i] != 'i' && s[i] != 'I' && s[i] != 'o' && s[i] != 'O' && s[i] != 'u' && s[i] != 'U' && s[i] != 'y' && s[i] != 'Y')
                Console.Write($".{s[i].ToString().ToLower()}");
        }
    }
    //End of Solve Function


    static void Main()
    {
        int test = 1;
        while(test-- > 0 )
        {
            solve();
            
        }
    }
}