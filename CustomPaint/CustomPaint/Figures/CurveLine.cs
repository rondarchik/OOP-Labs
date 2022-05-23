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
    public class CurveLine : Figure
    {
        [DataMember]
        private Pen pencil;

        public CurveLine(Color color, int penWidth) : base(color, penWidth) 
        {
            pencil.Width = penWidth;
            pencil.Color = color;
        }

        public CurveLine() { }

        public override Figure Clone()
        {
            return (CurveLine)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pencil, points[0], points[1]);
        }
    }
}
