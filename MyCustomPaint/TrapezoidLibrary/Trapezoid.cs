using System.Runtime.Serialization;
using MyCustomPaint.Figures;


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
            pointsT = new Point[4] {
                new Point(base.points[0].X + width, base.points[0].Y),
                new Point(base.points[1].X - width, base.points[0].Y),
                base.points[1],
                new Point(base.points[0].X, base.points[1].Y)
            };

            if (pen == null)
            {
                SetPen();
            }

            if (IsFill)
            {
                graphics.FillPolygon(brush, pointsT);
            }

            graphics.DrawPolygon(pen, pointsT);
        }
    }
}
