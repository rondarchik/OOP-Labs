using CustomPaint.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidLibrary
{
    [DataContract]
    public class Rhombus : Figure
    {
        [DataMember]
        private Point[]? pointsT;

        [DataMember]
        private Brush brush;


        public Rhombus(Color penColor, Color fillColor, int penWidth) : base(penColor, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }


        public override Figure Clone()
        {
            return (Rhombus)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            // магические вычисления))
            int width = Math.Abs(base.points[1].X - base.points[0].X) / 3;
            pointsT = new Point[4] {
                points[0],
                points[1],
                new Point(points[0].X, points[1].Y + (points[1].Y - points[0].Y)),
                new Point(points[0].X - (points[1].X - points[0].X), points[1].Y)
            };


            if (IsFill)
            {
                graphics.FillPolygon(brush, pointsT);
            }

            graphics.DrawPolygon(Pen, pointsT);
        }

    }
}
