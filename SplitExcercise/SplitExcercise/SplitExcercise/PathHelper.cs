using System.IO;

namespace SplitExcercise
{
    public static class PathHelper
    {
        public static string ExeDir()
        {
            return new FileInfo(typeof(PathHelper).Assembly.Location).DirectoryName;
        }
    }
}



