using System;
using System.Drawing;
using CustomPaint.Figures;

namespace CustomPaint.Creators
{
    public class LineCreator : ICreator
    {
        public bool IsCanFill { get { return false; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Line(penColor, penWidth);
        }
    }
}
