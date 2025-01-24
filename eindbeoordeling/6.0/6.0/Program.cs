namespace _6._0
{
    internal class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            string[] lines = File.ReadAllLines("quiz.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

    }
}
