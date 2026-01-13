using System;
using System.IO;

namespace Tutorial01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("+-------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\t\t\t\tTHÔNG TIN CƠ BẢN VỀ MÔI TRƯỜNG HỆ THỐNG \t\t\t\t|");
            Console.WriteLine("+-------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\t\t\t\t\tMÔI TRƯỜNG HỆ ĐIỀU HÀNH \t\t\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Hệ điều hành (OS Version):\t\t\t|{Environment.OSVersion}\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Nền tảng 64-bit:\t\t\t\t|{Environment.Is64BitOperatingSystem}\t\t\t\t\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Tên máy (Machine Name):\t\t\t|{Environment.MachineName} \t\t\t\t\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Người dùng hiện tại:\t\t\t\t|{Environment.UserName} \t\t\t\t\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Thời gian (Uptime)\t\t\t\t|{Environment.TickCount/60000} phút \t\t\t\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Thư mục làm việc hiện tại\t\t\t|{Environment.CurrentDirectory} \t|");
            Console.WriteLine("+-------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
