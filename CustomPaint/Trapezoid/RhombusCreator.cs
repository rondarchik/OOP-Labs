using CustomPaint.Creators;
using CustomPaint.Figures;
using CustomPaint.PluginTools;
using System.Drawing;

namespace TrapezoidLibrary
{
    [Plugin("Rhombus")]
    public class RhombusCreator : ICreator
    {
        public bool IsCanFill { get { return true; } }
        public bool IsPolyline { get { return false; } }

        public Figure Create(Color color, Color fillColor, int penWidth)
        {
            return new Rhombus(color, fillColor, penWidth);
        }
    }
}
