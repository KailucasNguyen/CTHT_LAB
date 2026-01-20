using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Q3
{
    public static void Solution()
    {
        Console.WriteLine("Program started");

        int result = Add(11, 6);

        Console.WriteLine($"Result = {result}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}
