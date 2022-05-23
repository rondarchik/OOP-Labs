

using System.Drawing;
using System.Runtime.Serialization;

namespace MyCustomPaint.Actions
{
    [DataContract]
    public class Storage
    {
        // хранится история всех выполненных команд
        [DataMember]
        public Undo UndoStack;

        // место, куда мы помещаем команду, когда она отменена
        [DataMember]
        public Redo RedoStack;

        public Storage()
        {
            UndoStack = new Undo();
            RedoStack = new Redo();
        }

        public void Undo()
        {
            if (!UndoStack.IsEmpty())
            {
                RedoStack.PushStack(UndoStack.RemoveLast());
            }
        }

        public void Redo()
        {
            if (!RedoStack.IsEmpty())
            {
                UndoStack.Push(RedoStack.PopStack());
            }
        }

        public void Clear()
        {
            UndoStack.ClearStack();
            RedoStack.ClearStack();
        }

        public void DrawFigures(Graphics graphics) //, Pen pen, Brush brush, Point StartPoint, Point FinishPoint, Point[] Points)
        {
            for (int i = 0; i < UndoStack.StackCount(); i++)
            {
                UndoStack.ReturnThis(i).Draw(graphics);//, pen, brush, StartPoint, FinishPoint, Points);
            }
        }
    }
}
