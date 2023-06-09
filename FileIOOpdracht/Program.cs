﻿namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("andthis.txt", "hello");

            string[] content = File.ReadAllLines("readthis.txt");
            ReadLines(content);


            if (Directory.Exists("output") == false)
            {
                Directory.CreateDirectory("output");
            }
            if (File.Exists("output/andthis.txt") == false && Directory.Exists("output") == true)
            {
                File.Move("andthis.txt", "output/andthis.txt");
            }

            string[] contentTheSecond = File.ReadAllLines("output/andthis.txt");
            ReadLines(contentTheSecond);

            File.AppendAllText("output/andthis.txt", "[HOW WAS YOUR DAY?]");
            ReadLines(contentTheSecond);
        }

        static void ReadLines(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}