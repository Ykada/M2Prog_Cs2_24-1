namespace MemSave
{
    internal class Program
    {
        string welkomstTekst = "hello world";
        string saveFile = "welkomState.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.Run();
        }

        void Run()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            bool bestaatDeFile = File.Exists(saveFile);
            if (bestaatDeFile)
            {
                welkomstTekst = File.ReadAllText(saveFile);
                Console.WriteLine(welkomstTekst);
            }
            while (true)
            {
                Console.WriteLine(welkomstTekst);
                Console.WriteLine("Enter a text, then press enter");
                File.WriteAllText(saveFile, welkomstTekst);
            }
        }
    }
}

