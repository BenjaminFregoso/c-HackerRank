using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int diagR = 0;
        int diagL = 0;
        int vertic = arr[0].Count - 1;
        int auxR = 0;
        int auxL = vertic;
       
        while (vertic >= 0)
            {
                diagR += arr[auxR][auxR];
                diagL += arr[auxR][auxL];
                auxR++;
                auxL--;
                vertic--;
            }
        return Math.Abs(diagR - diagL);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        List<List<int>> arr = [[11, 2, 4,9], [4, 5, 6,7], [10, 8, -12,6], [10, 8, -12, 6]];

        

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);

    }
}
