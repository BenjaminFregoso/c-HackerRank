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
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {

        int lenghtar = ar.Count - 1;
        int total = 0;
        while (lenghtar >= 0)
        {
            total += ar[lenghtar];
            lenghtar--;
        }
        return total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> ar = [1, 45, 1, 343, 56, 767, 88];

        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);

    }
}
