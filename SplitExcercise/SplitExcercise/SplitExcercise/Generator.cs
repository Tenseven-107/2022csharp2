using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace SplitExcercise
{
    internal class Generator
    {
        internal void Generate()
        {
            List<Tile> tiles = new List<Tile>();

            bool stairs = false;
            Random random = new Random();
            int y = random.Next(0, 4) * 16;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 16; i2++)
                {
                    Tile t = new Tile();
                    t.placement = new Rectangle(i2 * 16, i * 16, 16, 16);
                    if (i == 0 || i2 == 0 || i == 9 || i2 == 15)
                    {
                        t.sprite = new Rectangle(43, y, 16, 16);
                    }
                    else
                    {
                        if (random.Next(0, 100) < 10)
                        {
                            t.sprite = new Rectangle(0, y, 16, 16);
                        }
                        else
                        {
                            t.sprite = new Rectangle(21, y, 16, 16);
                            if (stairs)
                            {
                                t.sprite = new Rectangle(43, y, 16, 16);
                            }
                        }
                    }
                    tiles.Add(t);
                }
            }
            using (StreamWriter w = new StreamWriter("leveldata.txt"))
            {
                foreach (Tile t in tiles)
                {
                    w.WriteLine($"{t.placement.X},{t.placement.Y},16,16,{t.sprite.X},{t.sprite.Y},16,16");
                }
            }

            //examples for how large data becomes with different serilization methods
            //also the WHY we sometimes use manual serialization

            string data = JsonSerializer.Serialize(tiles);
            File.WriteAllText("leveldata.json", data);

            //deze is ter voorbeeld om even snel binary (byte enzo) te serializen, graag niet echt gebruiken ivm een security issue
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("leveldata.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fs, tiles);
            }
        }
    }
}
