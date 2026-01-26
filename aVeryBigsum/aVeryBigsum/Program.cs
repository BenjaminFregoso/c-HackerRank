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
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long aVeryBigSum(List<long> ar)
    {
        int arraySize = ar.Count - 1;
        long arraySum = 0;
        while (arraySize >= 0)
        {
            arraySum += ar[arraySize];
            arraySize--;
        }

        return arraySum;

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> ar = [1000000001, 1000000002, 1000000003, 1000000004, 1000000005];

        long result = Result.aVeryBigSum(ar);

        Console.WriteLine(result);

    }
}
