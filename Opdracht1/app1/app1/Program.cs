namespace app1
{
    internal class Program
    {
        string[] vragen = new string[]
{
                "Am i trapped in your basement?", "What is the game you played the most",
                "What secret conspiracy would you like to actually start letting other people know?", "how long do you thing you will servive me", 
                "What secret conspiracy would you like to actually start letting other people know?", "What would you do if you won a million dollars?",
                "Have you ever made a discord bot", "Has someone caught you dancing in front of the mirror?", "Why do round pizzas come in square boxes?"
};
        static void Main(string[] args)
        {
            Program program = new Program(); //we hebben een program variable gemaakt
            program.run();
        }
        internal string GetRandomVraag()
        {
            Random rnd = new Random();
            int random =rnd.Next (vragen.Length);
            return vragen[random];
        }
        internal string vraag()
        {
            Console.WriteLine(GetRandomVraag());
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            return antwoord;

        }
        internal void run()
        {
            vraag();
            // i am held hostage in the basement of sammie
        }
    }
}
