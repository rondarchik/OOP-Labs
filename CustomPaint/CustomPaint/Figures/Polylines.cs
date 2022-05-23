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
    class Polyline : Figure
    {
        public Polyline(Color color, int penWidth) : base(color, penWidth) { }

        public Polyline() { }

        public override Figure Clone()
        {
            return (Polyline)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            if (pen == null)
            {
                SetPen();
            }

            graphics.DrawLines(pen, points);
        }
    }

}
