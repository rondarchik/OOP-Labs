using MyCustomPaint.Creators;
using MyCustomPaint.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidLibrary
{
    //[Plugin("Trapezoid")]
    public class TrapezoidCreator : ICreator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color color, Color fillColor, int penWidth)
        {
            return new Trapezoid(color, fillColor, penWidth);
        }
    }
}
