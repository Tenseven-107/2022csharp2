namespace oefeningStreamingStudentenVersie
{
    internal class WorldMaker
    {
        private Random r;
        private int size;
        private string file;
        internal WorldMaker(string file, int size)
        {
            r = new Random();
            this.size = size;
            this.file = file;
        }
        internal void RollWorld()
        {
            int chunks = 0;

            using (FileStream f = File.Open(file, FileMode.Create, FileAccess.ReadWrite))
            {
                while (chunks < 3)
                {

                    MakeHorizontalWall(f);
                    for (int y = 1; y < size-1; y++)
                    {
                        f.WriteByte((byte)'#');//niet super net wordt ASCII
                        for (int x = 1; x < size-1; x++)
                        {
                            char c = RollTile();
                            f.WriteByte((byte)c);//niet super net wordt ASCII

                        }
                        f.WriteByte((byte)'#');//niet super net wordt ASCII
                        WriteNewLine(f);
                    }

                    MakeHorizontalWall(f);
                    chunks++;
                }
                f.Close();
            }
        }

        private char RollTile()
        {
            int v = 1;
            if (r.Next(100) < 20)
            {
                v = 0;
            }
            char c = v == 1 ? '.' : '#';
            return c;
        }

        private  void MakeHorizontalWall(FileStream f)
        {
            for (int x = 0; x < size; x++)
            {
                f.WriteByte((byte)'#');//niet super net wordt ASCII
            }
            WriteNewLine(f);
        }

        private static void WriteNewLine(FileStream f)
        {
            //newline
            f.WriteByte((byte)'\r');
            f.WriteByte((byte)'\n');
        }
    }
}