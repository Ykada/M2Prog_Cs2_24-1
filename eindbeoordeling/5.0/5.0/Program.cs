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
        class Room
        {
            internal int x, y;
            internal string[] level;

            internal Room(int x, int y, string[] level)
            {
                this.x = x;
                this.y = y;
                this.level = level;
            }
            Room start = new Room(0, 0, [
                "XXXXX",
                "X   X",
                "X   X",
                "X   X",
                "XXXXX"
            ]);
        }
        class Rooms
        {
            //Rooms.Add(start.getroomlocationkey(), start);
        }
        private void ShowRooms(int x, int y)
        {
            Room room = Rooms[$"{x}, {y}"];

            Console.WriteLine($" you are in room {x}, {y}");
            foreach (string r in room.level)
            {
                Console.WriteLine(r);
            }
        }
    }
}
