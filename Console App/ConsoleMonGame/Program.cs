using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConsoleMonFunctions();
            TestSkillFunctions();
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
            targetMon.health = 200;
            casterMon.energy = 50;
            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == 100);

            Console.WriteLine(casterMon.energy == 30);
        }
    }


}
