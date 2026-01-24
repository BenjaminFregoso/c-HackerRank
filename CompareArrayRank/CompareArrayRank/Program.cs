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
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int totalA = 0;
        int totalB = 0;
        int lenghtArray = a.Count() -1;

        while (lenghtArray >= 0)
        {
            if (a[lenghtArray] > b[lenghtArray])
            {
                totalA++;
            }
            else if (a[lenghtArray] < b[lenghtArray])
            {
                totalB++;
            }
            lenghtArray--;
        }
        return [totalA, totalB];
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> a = [5, 6, 7];
        List<int> b = [3, 6, 10];

        List<int> result = Result.compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));

    }
}
