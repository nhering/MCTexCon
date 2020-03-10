using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCTexCon
{
    public class TexMap
    {
        public string version { get; set; }
        public string fileName { get; set; }
        public List<TexBlock> texBlocks { get; set; }
    }

    public class TexBlock
    {
        public string name { get; set; }
        public Coordinate coord { get; set; }
        public Bitmap image { get; set; }
    }

    public class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
