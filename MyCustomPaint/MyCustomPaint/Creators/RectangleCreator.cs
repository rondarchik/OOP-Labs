using System;
using System.Drawing;
using MyCustomPaint.Figures;

namespace MyCustomPaint.Creators
{
    public class RectangleCreator : ICreator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new MyRectangle(penColor, fillColor, penWidth);
        }
    }
}
