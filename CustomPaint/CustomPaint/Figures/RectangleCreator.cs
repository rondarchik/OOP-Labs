using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class RectangleCreator : Creator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new MyRectangle(penColor, fillColor, penWidth);
        }
    }
}
