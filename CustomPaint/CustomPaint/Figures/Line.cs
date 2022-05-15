using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomPaint.Figures
{

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

    public class LineCreate : ICreate
    {
        public bool IsCanFill { get { return false; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color penColor, Color fillColor, int penWidth)
        {
            return new Line(penColor, penWidth);
        }
    }
}
