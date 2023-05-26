namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here are your requested files: ");
            Console.WriteLine("");

            gettingFiles("C:\\Users\\nadri\\Development\\School\\proofmap\\Periode_1.3-4\\Csharp\\2022csharp2");
        }

        static void gettingFiles(string path)
        {
            FileGetter getter = new FileGetter(path);

            foreach (FileInfo file in getter.files)
            {
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo dir in getter.dirs)
            {
                Console.WriteLine(dir.Name);
            }
        }
    }
}