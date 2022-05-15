using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomPaint.Figures
{
    public class Ellipse : Figure
    {
        private float width;

        private float height;

        private Brush brush;


        public Ellipse(Color penColor, Color fillColor, int penWidth) : base(penColor, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }

        public Ellipse() { }

        public override Figure Clone()
        {
            // возвращает копию объекта
            return (Ellipse)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            if (pen == null)
            {
                SetPen();
            }

            var first = new Point(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            var second = new Point(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));

            width = second.X - first.X;
            height = second.Y - first.Y;

            if (IsFill)
            {
                graphics.FillEllipse(brush, first.X, first.Y, width, height);
            }

            // карандаш, координаты верхнего левого угла, выоста, широта
            graphics.DrawEllipse(pen, first.X, first.Y, width, height);
        }
    }

    public class EllipseCreate: ICreate
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Ellipse(penColor, fillColor, penWidth);
        }
    }
}