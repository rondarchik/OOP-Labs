using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


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
            if (pen == null)
            {
                SetPen();
            }

            // карандаш, первая точка, вторая точка
            graphics.DrawLine(pen, points[0], points[1]);
        }
    }
}
