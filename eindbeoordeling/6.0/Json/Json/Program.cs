using System.Text.Json;
namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        void Run()
        {

            string text = File.ReadAllText("Product.json");
            string text2 = File.ReadAllText("player.json");
            string text3 = File.ReadAllText("Walking.json");
            Products product = JsonSerializer.Deserialize<Products>(text);
            Products product2 = JsonSerializer.Deserialize<Products>(text2);
            Products product3 = JsonSerializer.Deserialize<Products>(text3);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.lvl);
            Console.WriteLine(product.maxhp);
            Console.WriteLine(product.hp);
            Console.WriteLine(product.location);
            Console.WriteLine("");
            Console.WriteLine(product2.Name);
            Console.WriteLine(product2.lvl);
            Console.WriteLine(product2.maxhp);
            Console.WriteLine(product2.hp);
            Console.WriteLine(product2.location);
            Console.WriteLine("");
            Console.WriteLine(product3.Name);
            Console.WriteLine(product3.lvl);
            Console.WriteLine(product3.maxhp);
            Console.WriteLine(product3.hp);
            Console.WriteLine(product3.location);

        }
    }
    public class Products
    {
        public string Name { get; set; }
        public string lvl { get; set; }
        public string maxhp { get; set; }
        public string hp { get; set; }
        public string location { get; set; }

    }
}
