using System;
using System.IO;

internal class ConsoleMonFactory
{
    internal void Load(string datafile)
    {

        string[] lines = File.ReadAllLines(datafile);

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
