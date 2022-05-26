using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;


namespace CustomPaint.Figures
{
    [DataContract]
    public class Polygon : Figure
    {
        [DataMember]
        private Brush brush;

        public Polygon(Color penColor, Color fillColor, int penWidth) : base(penColor, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }

        public Polygon() { }

        public override Figure Clone()
        {
            return (Polygon)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {

            if (IsFill)
            {
                graphics.FillPolygon(brush, points);
            }

            graphics.DrawPolygon(Pen, points);
        }
    }
}
