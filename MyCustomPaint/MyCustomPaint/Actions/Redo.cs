using MyCustomPaint.Figures;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace MyCustomPaint.Actions
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
