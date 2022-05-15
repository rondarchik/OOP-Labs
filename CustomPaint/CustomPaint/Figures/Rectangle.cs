using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CustomPaint.Figures
{
    public class Rectangle : Figure
    {
        private float width;

        private float height;

        private Brush brush;

        public Rectangle(Color penColor, Color fillColor, int penWidth) : base(penColor, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }

        public Rectangle() { }

        public override Figure Clone()
        {
            return (Rectangle)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            if (pen == null)
                SetPen();

            var first = new Point(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            var second = new Point(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));

            width = second.X - first.X;
            height = second.Y - first.Y;

            if (IsFill)
                graphics.FillRectangle(brush, first.X, first.Y, width, height);
            else
                // карандаш, координаты верхнего левого угла, выоста, широта
                graphics.DrawRectangle(pen, first.X, first.Y, width, height);
        }
    }

    public class RectangleCreate : ICreate
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Rectangle(penColor, fillColor, penWidth);
        }
    }
}
