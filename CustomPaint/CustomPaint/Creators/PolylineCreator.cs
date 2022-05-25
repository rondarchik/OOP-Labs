using System;
using System.Drawing;
using CustomPaint.Figures;

namespace CustomPaint.Creators
{
    public class PolylineCreator : ICreator
    {
        public bool IsCanFill { get { return false; } }
        public bool IsPolyline { get { return true; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Polyline(penColor, penWidth);
        }
    }
}

