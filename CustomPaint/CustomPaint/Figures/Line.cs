using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;


namespace CustomPaint.Figures
{
    [DataContract]
    public class Line : Figure
    {
        public Line(Color color, int penWidth) : base(color, penWidth) { }

        public Line() { }

        public override Figure Clone()
        {
            return (Line)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            // карандаш, первая точка, вторая точка
            graphics.DrawLine(Pen, points[0], points[1]);
        }
    }
}
