using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public interface ICreate
    {
        bool IsCanFill { get; }
        bool IsPolyline { get; }

        Figure Create(Color penColor, Color fillColor, int penWidth);
    }
}
