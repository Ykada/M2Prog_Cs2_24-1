namespace _5._0
{
    internal class Program
    {
        internal void run()
        {
            Dictionary<int, string> personeelopnummer = new Dictionary<int, string>();
            personeelopnummer.Add(382942, "Jimbob");
            personeelopnummer.Add(759273, "Lunchly");
            string Jimbob = personeelopnummer[382942];
            string Lunchly = personeelopnummer[759273];

            foreach (KeyValuePair<int, string> item in personeelopnummer)
            {
                Console.WriteLine(Jimbob, personeelopnummer);
                Console.WriteLine(Lunchly, personeelopnummer);
            }
            foreach (int key in personeelopnummer.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string value in personeelopnummer.Values) 
            { 
                Console.WriteLine(value); 
            }
        }
    }
}
