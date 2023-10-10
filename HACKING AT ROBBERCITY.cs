using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string message1 = Console.ReadLine();
        string message2 = Console.ReadLine();
        string message3 = Console.ReadLine();

        string output = "";

        for(int i = 0; i < message1.Length; i += 2)
        {

            output += (char)(stringToByte(message2.ToUpper(), i) ^ stringToByte(message1.ToUpper(), i) ^ stringToByte(message3.ToUpper(), i));
        }

        Console.WriteLine(output);
    }

    static byte stringToByte(string m, int start)
    {
        char[] abd = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'}; 
        int a = _First(abd, m[start]);
        int b = _First(abd, m[start+1]);
        return (byte)(a*16+b);
    }

    static int _First(char[] a, char t)
    {
        for(int i = 0; i < a.Length; i++)
            if(a[i] == t)
                return i;
        return -1;
    }
}
