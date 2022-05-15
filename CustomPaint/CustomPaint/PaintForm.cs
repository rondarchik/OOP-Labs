using CustomPaint.Figures;
using CustomPaint.Undo_Redo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPaint
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();

            penColor = Color.Black;
            fillColor = Color.White;

            IsDrawing = false;
            IsFill = false;

            pencilWidth = 1;

            bitMap = new Bitmap(Canva.Width, Canva.Height);
            graphica = Graphics.FromImage(bitMap);
            graphica.Clear(Color.White);
            Canva.Image = bitMap;

            Points = new List<Point>();
            figuresStorage = new Storage();
        }


        private Bitmap bitMap;
        private bool IsDrawing;
        private bool IsFill;
        private Point first, second;
        private List<Point> Points;
        private Figure figure;
        private Storage figuresStorage;
        private ICreate creator;
        private Color penColor, fillColor;
        private int pencilWidth;
        private Graphics graphica;

        //MOUSE
        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null && !creator.IsPolyline)
            {
                first = e.Location;

                Points.Clear();
                Points.Add(first);
                Points.Add(first);

                IsDrawing = !IsDrawing;
                figure.IsFill = IsFill;
            }
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                second = e.Location;

                Points[Points.Count - 1] = second;

                figure.points = Points.ToArray();
                Canva.Refresh();
            }
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsDrawing && !creator.IsPolyline)
            {
                second = e.Location;

                IsDrawing = !IsDrawing;

                if (first != second)
                {
                    Points[1] = second;
                    figuresStorage.UndoList.Push(figure);

                    if (!figuresStorage.RedoStack.IsEmpty())
                    {
                        figuresStorage.RedoStack.ClearStack();
                        Redo.Enabled = false;
                    }

                    Undo.Enabled = true;
                }

                figure = figure.Clone();
            }
        }

        private void Canva_MouseClick(object sender, MouseEventArgs e)
        {
            if (creator != null && creator.IsPolyline)
            {
                first = e.Location;

                if (e.Button == MouseButtons.Left)
                {
                    if (!IsDrawing)
                    {
                        Points.Clear();
                        Points.Add(first);
                        Points.Add(first);

                        IsDrawing = !IsDrawing;

                        figure.IsFill = IsFill;
                    }
                    else
                    {
                        Points.Add(first);
                    }
                }
                else if (e.Button == MouseButtons.Right && IsDrawing)
                {
                    IsDrawing = !IsDrawing;

                    Undo.Enabled = true;
                    figuresStorage.UndoList.Push(figure);
                    figure = figure.Clone();

                    if (!figuresStorage.RedoStack.IsEmpty())
                    {
                        figuresStorage.RedoStack.ClearStack();
                        Redo.Enabled = false;
                    }
                }
            }
        }

        private void Canva_Paint(object sender, PaintEventArgs e)
        {
            figuresStorage.DrawFigures(e.Graphics);

            if (IsDrawing)
            {
                figure.Draw(e.Graphics);
            }
        }

        //FIGURES
        private void Polygon_Click(object sender, EventArgs e)
        {
            creator = new PolygonCreate();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void PolyLines_Click(object sender, EventArgs e)
        {
            creator = new Polylines();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            creator = new LineCreate();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreate();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            creator = new EllipseCreate();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        //COLORS
        private void ChoosedColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
                penColor = colorDialog1.Color;

                if (figure != null)
                {
                    figure.color = penColor;
                    figure.SetPen();
                }
            }
        }

        private void FilledColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
                fillColor = colorDialog1.Color;

                if ((figure != null) && FillCheck.Enabled)
                {
                    // Содержит методы для локального или удаленного создания типов объектов или получения ссылок на существующие удаленные объекты.
                    // Создает экземпляр указанного типа, используя конструктор, который лучше всего соответствует указанным параметрам.
                    object[] args = new object[3] { penColor, fillColor, pencilWidth };
                    figure = (Figure)Activator.CreateInstance(figure.GetType(), args);
                }
            }
        }
        
        private void FillCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FillCheck.Checked)
            {
                IsFill = true;
            }
            else
            {
                IsFill = false;
            }
        }

        //OTHER OBJECTs
        private void Clear_Click(object sender, EventArgs e)
        {
            figuresStorage.Clear();
            Canva.Refresh();

            Undo.Enabled = false;
            Redo.Enabled = false;

            graphica.Clear(Canva.BackColor);
            Canva.Image = bitMap;
        }

        private void PenWidth_Scroll(object sender, EventArgs e)
        {
            pencilWidth = PenWidth.Value;

            if (figure != null)
            {
                figure.penWidth = pencilWidth;
                figure.SetPen();
            }

            PenLabel.Text = "Pen Width: " + pencilWidth.ToString();
        }

        //UNDO/REDO
        private void Undo_Click(object sender, EventArgs e)
        {
            figuresStorage.Undo();
            Canva?.Refresh();

            Redo.Enabled = true;
            if(figuresStorage.UndoList.IsEmpty())
                Undo.Enabled = false;
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            figuresStorage.Redo();
            Canva?.Refresh();

            Undo.Enabled = true;
            if (figuresStorage.RedoStack.IsEmpty())
                Redo.Enabled = false;
        }

        //just..
        private void SetStage(ICreate creator)
        {
            if (creator.IsCanFill)
            {
                FillCheck.Enabled = true;
            }
            else
            {
                FillCheck.Enabled = false;
            }
        }
    }
}
