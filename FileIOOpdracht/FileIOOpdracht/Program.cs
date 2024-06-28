using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] content = File.ReadAllLines("leesdezefile.txt");

        foreach (var line in content)
        {
            Console.WriteLine(line);
        }


        File.AppendAllText("leesdezefile.txt", "\nen een tweede regel aan data");

        string outputDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output");
        Directory.CreateDirectory(outputDir);


        string outputFile = Path.Combine(outputDir, "mijnnieuwefile.txt");
        File.WriteAllText(outputFile, "Dit is mijn nieuwe tekstbestand.");


        File.AppendAllText(outputFile, "\nDit is de tweede regel toegevoegd met AppendAllText.");

        Console.WriteLine("\nBestanden zijn gelezen en geschreven. Bekijk de output in de 'output' directory.");
    }
}
