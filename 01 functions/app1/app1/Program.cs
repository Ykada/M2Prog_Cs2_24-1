namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //we hebben een program variable gemaakt
            program.run();
        }
        internal void run()
        {
            Console.WriteLine("how long do you thing you will servive me");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord1 = Console.ReadLine();
            Console.WriteLine(antwoord1);
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord2 = Console.ReadLine();
            Console.WriteLine(antwoord2);
            Console.WriteLine("Have you ever made a discord bot");
            string antwoord3 = Console.ReadLine();
            Console.WriteLine(antwoord3);
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord4 = Console.ReadLine();
            Console.WriteLine(antwoord4);
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord5 = Console.ReadLine();
            Console.WriteLine(antwoord5);


            // i am held hostage in the basement of sammie
        }
    }
}
