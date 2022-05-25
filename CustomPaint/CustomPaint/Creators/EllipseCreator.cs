using CustomPaint.Figures;
using System;
using System.Drawing;

namespace CustomPaint.Creators
{
    public class EllipseCreator : ICreator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Ellipse(penColor, fillColor, penWidth);
        }
    }
}
