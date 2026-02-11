using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial05.Q1_05
{
    public class ProcessA
    {
        public static void ProcessMain()
        {
            int secret = 42;
            Console.WriteLine("Process A running...");
            Console.WriteLine($"Secret value in Process A: {secret}");
        }
    }
}
