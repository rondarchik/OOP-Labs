using CustomPaint.Creators;
using CustomPaint.Figures;
using CustomPaint.PluginTools;
using System.Drawing;

namespace TrapezoidLibrary
{
    [Plugin("Trapezoid")]
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
