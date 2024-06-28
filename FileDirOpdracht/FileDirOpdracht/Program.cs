using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Users\am591\Documents\GitHub\2024P4ProgCs2");

        FileInfo[] files = dir.GetFiles();

        Console.WriteLine("Bestanden:");
        foreach (var file in files)
        {
            Console.WriteLine(file.Name);
        }

        DirectoryInfo[] directories = dir.GetDirectories();


        Console.WriteLine("\nMappen:");
        foreach (var directory in directories)
        {
            Console.WriteLine(directory.Name);
        }
    }
}
