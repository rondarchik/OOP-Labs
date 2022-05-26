﻿using System.Drawing;
using System.Runtime.Serialization;
using CustomPaint.Figures;


namespace TrapezoidLibrary
{
    [DataContract]
    public class Trapezoid : Figure
    {
        [DataMember]
        private Point[]? pointsT;

        [DataMember]
        private Brush brush;


        public Trapezoid(Color penColor, Color fillColor, int penWidth) : base(penColor, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }


        public override Figure Clone()
        {
            return (Trapezoid)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            // магические вычисления))
            int width = Math.Abs(base.points[1].X - base.points[0].X) / 3;
            pointsT = new Point[4] { new Point(points[0].X + width, points[0].Y), new Point(points[1].X - width, points[0].Y),
                                      points[1], new Point(points[0].X, points[1].Y) };


            if (IsFill)
            {
                graphics.FillPolygon(brush, pointsT);
            }

            graphics.DrawPolygon(Pen, pointsT);
        }
    }
}
