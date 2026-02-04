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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long minNum = 0;
        long maxNum = 0;
        int arraySize = arr.Count - 1;

        arr.Sort();

        while (arraySize >= 0)
        {
            if (arraySize == arr.Count - 1)
            {
                maxNum += arr[arraySize];
            }
            else if (arraySize == 0)
            {
                minNum += arr[arraySize];
            }
            else
            {
                minNum += arr[arraySize];
                maxNum += arr[arraySize];
            }
            arraySize--;
        }
        Console.Write(minNum.ToString() + " " + maxNum.ToString());
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = [7, 69, 2, 221, 8974];

        Result.miniMaxSum(arr);
    }
}
