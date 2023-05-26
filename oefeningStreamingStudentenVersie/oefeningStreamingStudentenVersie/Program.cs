using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace oefeningStreamingStudentenVersie
{
    internal class Program
    {
        private string file;
        private int levelSize = 10;
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.ReadLevel();


            //Extra uitdagingen!!, als je levelSize groter zet, zal je meer verschil in de laad tijden gaan zien 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            {
                prog.ReadLevelBlader(2);
            }
            stopwatch.Stop();
            long readlevel = stopwatch.ElapsedMilliseconds;

            stopwatch = new Stopwatch();
            {
                prog.ReadLevelSkip(2);
            }
            stopwatch.Stop();
            long readlevelskip = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("ReadLevel loadTime: " + readlevel);
            Console.WriteLine("ReadLevelSkip loadTime: " + readlevelskip);
        }
        private void ReadLevel()
        {
            //gebruik een StreamReader om de regels 1 voor 1 te lezen

            //lees 10 regels, en zet die op het scherm

            using (StreamReader streamreader = new StreamReader(file))
            {
                string horizontaleRegel;
                for (int i = 0; i < 10; i++)
                {
                    horizontaleRegel = streamreader.ReadLine();
                    Console.WriteLine(horizontaleRegel);
                }
            }
        }

        private void ReadLevelSkip(int levelIndex)
        {
            //gebruik een StreamReader +FileStream om in 1 keer naar het level te springen

            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            using (StreamReader streamReader = new StreamReader(fs))
            {
                fs.Position = 0;//??verander dit
                for (int i = 0; i < levelSize; i++)
                {
                    string horizontaleRegel = streamReader.ReadLine();
                    Console.WriteLine(horizontaleRegel);
                }
            }

        }
        private void ReadLevelBlader(int levelIndex)
        {
            //gebruik een StreamReader en laat alleen het level zien dat je moet tonen (het derde level!)

            using (StreamReader streamReader = new StreamReader(file))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //blader tot je bij het level komt
                    //dan laat je het zien
                }
            }

        }
        private Program()
        {
            file = Path.Combine(new FileInfo(typeof(Program).Assembly.Location).Directory.FullName, "testworld.txt");

            WorldMaker maker = new WorldMaker(file, levelSize);
            maker.RollWorld();
        }

    }
}