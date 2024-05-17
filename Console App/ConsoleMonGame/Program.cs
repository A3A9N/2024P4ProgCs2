namespace ConsoleMonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConsoleMonFunctions();
        }

        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.Health == 0);
            Console.WriteLine(mon.Energy == 0); 
        }
    }

}
