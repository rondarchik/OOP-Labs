using CustomPaint.Figures;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace CustomPaint.Actions
{
    [DataContract]
    public class Undo
    {
        [DataMember]
        private Stack<Figure> undoStack;

        public Undo()
        {
            undoStack = new Stack<Figure>();
        }

        public void Push(Figure figure)
        {
            undoStack.Push(figure);
        }

        public Figure RemoveLast()
        {
            Figure temp = undoStack.First();
            undoStack.Pop();
            return temp;
        }

        public Figure ReturnThis(int ind)
        {
            return undoStack.ElementAt(ind);
        }

        public bool IsEmpty()
        {
            if (undoStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int StackCount()
        {
            return undoStack.Count();
        }

        public void ClearStack()
        {
            undoStack.Clear();
        }
    }
}
