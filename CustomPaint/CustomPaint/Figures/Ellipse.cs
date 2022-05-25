using System.Collections.Generic;
using System;
using System.Drawing;
using System.Runtime.Serialization;


namespace CustomPaint.Figures
{
    [DataContract]
    public class Ellipse : Figure
    {
        [DataMember]
        private float width;

        [DataMember]
        private float height;

        [DataMember]
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
}
