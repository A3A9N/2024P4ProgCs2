using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string content = File.ReadAllText("stringsplit.txt");
       
     
        string[] keyValue = content.Split(':');

        
        foreach (var item in keyValue)
        {
            Console.WriteLine(item);
        }


        string[] vakken = keyValue[1].Split(',');

        Console.WriteLine("\nGesplitste vakken:");
        foreach (var vak in vakken)
        {
            Console.WriteLine(vak.Trim()); 
        }
    }
}
