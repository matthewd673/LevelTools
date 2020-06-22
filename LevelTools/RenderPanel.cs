using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelTools
{
    public class RenderPanel : Panel
    {

        public RenderPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = false;
        }

    }
}
