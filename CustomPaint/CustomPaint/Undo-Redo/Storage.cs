using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomPaint.Undo_Redo
{
    public class Storage
    {
        // хранится история всех выполненных команд
        public Undo UndoList;

        // место, куда мы помещаем команду, когда она отменена
        public Redo RedoStack;

        public Storage()
        {
            UndoList = new Undo();
            RedoStack = new Redo();
        }

        public void Undo()
        {
            if (!UndoList.IsEmpty())
            {
                RedoStack.PushStack(UndoList.RemoveLast());
            }
        }

        public void Redo()
        {
            if (!RedoStack.IsEmpty())
            {
                UndoList.Push(RedoStack.PopStack());
            }
        }

        public void Clear()
        {
            UndoList.ClearList();
            RedoStack.ClearStack();
        }

        public void DrawFigures(Graphics graphics)
        {
            for (int i = 0; i < UndoList.ListCount(); i++)
            {
                UndoList.ReturnThis(i).Draw(graphics);
            }
        }
    }
}
