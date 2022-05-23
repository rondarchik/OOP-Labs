using CustomPaint.Figures;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidPlugin.Figures
{
    [Plugin("Trapezoid")]
    public class TrapezoidCreator : Creator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color color, Color fillColor, int penWidth)
        {
            return new Trapezoid(color, fillColor, penWidth);
        }
    }
}
