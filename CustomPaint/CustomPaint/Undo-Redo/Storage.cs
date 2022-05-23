using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace CustomPaint.Undo_Redo
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
            UndoStack.ClearList();
            RedoStack.ClearStack();
        }

        public void DrawFigures(Graphics graphics)
        {
            for (int i = 0; i < UndoStack.ListCount(); i++)
            {
                UndoStack.ReturnThis(i).Draw(graphics);
            }
        }
    }
}
