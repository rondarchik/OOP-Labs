using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    // Абстрактный класс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Figure.
    public interface Creator
    {
        bool IsCanFill { get; }
        bool IsPolyline { get; }

        Figure Create(Color penColor, Color fillColor, int penWidth);
    }
}
