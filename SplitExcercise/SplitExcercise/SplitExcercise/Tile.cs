using System;
using System.Drawing;
using System.Text.Json.Serialization;

namespace SplitExcercise
{
    [Serializable]
    //public because of serialization
    public class Tile
    {
        [JsonInclude]
        public Rectangle placement;

        [JsonInclude]
        public Rectangle sprite;
    }
}
