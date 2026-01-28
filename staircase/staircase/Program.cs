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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        int l = n;
        int m = 0;
        while (n > 0)
        {
            n--;
            while (m < n)
            {
                Console.Write(' ');
                m++;
            }
            m = l - n;
            while (m > 0)
            {
                Console.Write('#');
                m--;
            }
            Console.WriteLine();
            m = 0;
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        Result.staircase(15);
    }
}
