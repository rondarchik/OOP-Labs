using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace CustomPaint.Figures
{
    [DataContract]
    public class MyRectangle : Figure
    {
        [DataMember]
        private float width;

        [DataMember]
        private float height;

        [DataMember]
        private Brush brush;

        public MyRectangle(Color penColor, Color fillColor, int penWidth) : base(penColor, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }

        public MyRectangle() { }

        public override Figure Clone()
        {
            return (MyRectangle)MemberwiseClone();
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

}
