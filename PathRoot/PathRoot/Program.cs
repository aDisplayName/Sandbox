using System;
using System.IO;

namespace PathRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TryPath(@"C:/a/b.txt");
            TryPath(@"C:a/b.txt");
            TryPath(@"/a/b.txt");
            TryPath(@"a/b.txt");
        }

        private static void TryPath(string s)
        {
            Console.WriteLine($"path: {s} IsRooted {Path.IsPathRooted(s)}; IsFullyQualified {Path.IsPathFullyQualified(s)}");
        }
    }
}
