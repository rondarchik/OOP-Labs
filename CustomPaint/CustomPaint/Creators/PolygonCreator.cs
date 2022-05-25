using System;
using System.Drawing;
using CustomPaint.Figures;

namespace CustomPaint.Creators
{
    public class PolygonCreator : ICreator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return true; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Polygon(penColor, fillColor, penWidth);
        }
    }
}

