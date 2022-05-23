using MyCustomPaint.Figures;
using System.Drawing;


namespace MyCustomPaint.Creators
{
    // Интерфейс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Figure.
    public interface ICreator
    {
        bool IsCanFill { get; }
        bool IsPolyline { get; }

        Figure Create(Color penColor, Color fillColor, int penWidth);
    }
}
