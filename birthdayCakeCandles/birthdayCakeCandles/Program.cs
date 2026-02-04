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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        int listSize = candles.Count - 1;
        int tallest = 0;
        int numTallest = 0;

        while (listSize >= 0)
        {
            if (candles[listSize] > tallest)
            {
                tallest = candles[listSize];
                numTallest = 1;
            }
            else if (candles[listSize] == tallest)
            {
                numTallest++;
            }
            listSize--;
        }

        return numTallest;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> candles = [4, 4, 1, 3];

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}
