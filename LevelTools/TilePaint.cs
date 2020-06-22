using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LevelTools
{
    public class TilePaint
    {

        public static int paintCt = 0;
        public static Dictionary<int, string> nameDict = new Dictionary<int, string>();

        public string name;
        public Color color;
        public SolidBrush brush;
        public readonly int id;

        public TilePaint(string name, int r, int g, int b, int id = -1)
        {
            this.name = name;
            color = Color.FromArgb(r, g, b);
            brush = new SolidBrush(color);

            if (id == -1)
                this.id = paintCt;
            else
                this.id = id;
            nameDict.Add(this.id, name);
            paintCt++;
        }

    }
}
