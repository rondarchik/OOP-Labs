using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Actions
{
    interface IMovable
    {
        void Move(PictureBox canvas, double dx, double dy, Point startPosX, Point startPosY);
    }

    interface ISelectable
    {
        void Select(PictureBox canvas);
    }
}
