using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomPaint.Figures
{
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

    public class Polylines : ICreate
    {
        public bool IsCanFill { get { return false; } }
        public bool IsPolyline { get { return true; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Polyline(penColor, penWidth);
        }
    }
}
