using ConsoleMonGame.ConsoleMonGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

internal class ConsoleMonFactory
{
    internal void LoadJson(string datafile)
    {

        string json = File.ReadAllText(datafile);


        List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);

        foreach (var template in templates)
        {
            Console.WriteLine($"Name: {template.name}");
            Console.WriteLine($"Health: {template.health}");
            Console.WriteLine($"Energy: {template.energy}");
            Console.WriteLine($"Weakness: {template.weakness}");

            Console.WriteLine("Skills:");
            foreach (var skill in template.skills)
            {
                Console.WriteLine($"  Skill Name: {skill.name}");
                Console.WriteLine($"  Damage: {skill.damage}");
                Console.WriteLine($"  Energy Cost: {skill.energyCost}");
                Console.WriteLine($"  Element: {skill.element}");
                Console.WriteLine();
            }
        }
    }
}
