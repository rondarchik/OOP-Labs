using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomPaint.Figures
{
    public abstract class Figure
    {
        public Point[] points;

        public Color color;

        public Pen pen;

        public int penWidth;

        public bool IsFill { get; set; }

        public Figure(Color color, int width)
        {
            this.color = color;
            this.penWidth = width;
            pen = new Pen(color, width);
        }

        public Figure() { }

        public void SetPen()
        {
            pen = new Pen(color, penWidth);
        }

        public abstract void Draw(Graphics graphics);

        public abstract Figure Clone();
    }
}
