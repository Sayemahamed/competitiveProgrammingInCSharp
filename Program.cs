using System;
using System.Linq;

class codeforces
{
    //Start of Input/Output Methods
    static int[] getIntArr() => Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    static long[]getLongArr()=>Console.ReadLine().Split(' ').Select(x=>Convert.ToInt64(x)).ToArray();
    static double[]getDoubleArr()=>Console.ReadLine().Split(' ').Select(x=>Convert.ToDouble(x)).ToArray();
    static string[]getWords()=>Console.ReadLine().Split(' ');
    static void printArr<T>(T[] x) {for (var i = 0; i < x.Length; i++)Console.Write($"{x[i]} ");}
    //End of Input/Output Methods



    static void Main()
    {
        int[] intArr = getIntArr();
    }
}