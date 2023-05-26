using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirOpdracht
{
    internal class FileGetter
    {
        internal DirectoryInfo directory;
        internal FileInfo[] files;
        internal DirectoryInfo[] dirs;

        
        internal FileGetter(string path)
        {
            if (path != string.Empty) directory = new DirectoryInfo(path);
            else directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            
            files = directory.GetFiles();
            dirs = directory.GetDirectories();
        }
    }
}
