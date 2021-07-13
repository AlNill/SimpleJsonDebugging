using System;

namespace SimpleJsonDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.Json.JsonSerializer.Serialize("Hello from feature2");
            Console.WriteLine("Hello World!");
        }
    }
}
