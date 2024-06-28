using ConsoleMonGame.ConsoleMonGame;
using ConsoleMonGame.ConsoleMonGame.ConsoleMonGame;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactoryFunctions();
        }

        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == 0);
            Console.WriteLine(mon.energy == 0); 
        }

        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");

            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            targetMon.weakness = Element.Fire; 

            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
                element = Element.Fire 
            };

            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -150); 
            Console.WriteLine(casterMon.energy == -20); 
        }
        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            //factory.Load("monsterdata.txt"); // Test voor niet-JSON bestand
            factory.LoadJson("monsterdata.json"); // Test voor JSON bestand
        }
    }


}
