using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using CustomPaint.Figures;

namespace CustomPaint.Undo_Redo
{
    [DataContract]
    public class Redo
    {
        [DataMember]
        private Stack<Figure> redoStack;

        public Redo()
        {
            redoStack = new Stack<Figure>();
        }

        public void PushStack(Figure figure)
        {
            redoStack.Push(figure);
        }

        public Figure PopStack()
        {
            return redoStack.Pop();
        }

        public bool IsEmpty()
        {
            if (redoStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearStack()
        {
            redoStack.Clear();
        }
    }
}
