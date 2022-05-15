using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPaint.Figures;

namespace CustomPaint.Undo_Redo
{
    public class Undo
    {
        private Stack<Figure> undoList;

        public Undo()
        {
            undoList = new Stack<Figure>();
        }

        public void Push(Figure figure)
        {
            undoList.Push(figure);
        }

        public Figure RemoveLast()
        {
            Figure temp = undoList.First();
            undoList.Pop();
            return temp;
        }

        public Figure ReturnThis(int ind)
        {
            return undoList.ElementAt(ind);
        }

        public bool IsEmpty()
        {
            if (undoList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ListCount()
        {
            return undoList.Count();
        }

        public void ClearList()
        {
            undoList.Clear();
        }
    }
}