using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomPaint.Figures
{
    class BrokenLine : Figure
    {
        public BrokenLine(Color color, int penWidth) : base(color, penWidth) { }

        public BrokenLine() { }

        public override Figure Clone()
        {
            return (BrokenLine)MemberwiseClone();
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
            return new BrokenLine(penColor, penWidth);
        }
    }
}
