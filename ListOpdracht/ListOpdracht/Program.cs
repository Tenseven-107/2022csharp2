namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            ListOpdracht l = new ListOpdracht();
            l.ListFunc();
        }
    }

    internal class ListOpdracht
    {
        private List<String> birds = new List<String>
        {
            "uil",
            "kraai",
            "hond",
            "papegaai"
        };

        private List<String> birds2 = new List<String>
        {
            "meeuw",
            "duif"
        };


        internal void ListFunc()
        {
            birds.AddRange(birds2);
            birds.Remove("hond");

            for (int t = 0; t < birds.Count; t++)
            {
                Console.WriteLine(birds[t]);
            }
        }
    }
}