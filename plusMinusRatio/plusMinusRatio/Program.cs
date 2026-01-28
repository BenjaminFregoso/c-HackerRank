using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int arraySize = arr.Count - 1;
        decimal minRatio = 0;
        decimal zeroRatio = 0;
        decimal plusRatio = 0;

        while (arraySize >= 0)
        {
            if (arr[arraySize] > 0)
            {
                plusRatio++;
            }
            else if (arr[arraySize] < 0)
            {
                minRatio++;
            }
            else
            {
                zeroRatio++;
            }
            arraySize--;
        }
        arraySize = arr.Count;
        plusRatio = plusRatio / arraySize;
        minRatio = minRatio / arraySize;
        zeroRatio = zeroRatio / arraySize;

        Console.WriteLine(string.Format("{0:0.000000}", plusRatio));
        Console.WriteLine(string.Format("{0:0.000000}", minRatio));
        Console.WriteLine(string.Format("{0:0.000000}", zeroRatio));
    }


}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = [-4, 3, -9, 0, 4, 1];

        Result.plusMinus(arr);
    }
}
