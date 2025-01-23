namespace _4._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 11.22 };
            string[] artiekelen = { "snoepje", "Luxe Broodje", "Lunch Menu" };
            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "prijzen maar lekker",
                Sterren = 5
            };
            formulieren[1] = new Formulier()
            { Feedback = "Prijzen mmaar lekker", Sterren = 4 };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.Write(prijzen[i]);
            }
            for (int i = 0; i < formulieren.Length; i++)
            {
                foreach (Formulier formulier in formulieren)
                {
                    Console.WriteLine(formulier[i]);
                }
            }
        }
    }
}
