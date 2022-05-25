using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;


namespace CustomPaint.Figures
{
    // Абстрактный класс Figure определяет интерфейс класса, объекты которого надо создавать
    [DataContract]
    public abstract class Figure
    {
        [DataMember]
        public Point[] points;

        [DataMember]
        public Color color;

        //[DataMember]
        public Pen pen;

        [DataMember]
        public int penWidth;

        [DataMember]
        public Boolean IsFill { get; set; }

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
