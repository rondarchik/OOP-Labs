using CustomPaint.Figures;
using CustomPaint.Undo_Redo;
using CustomPaint.Serialize;
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

            this.penColor = Color.Black;
            this.fillColor = Color.White;

            this.IsDrawing = false;
            this.IsFill = false;
            this.IsPencil = true;
            this.IsEraser = false;
            this.IsFigure = false;

            this.pencilWidth = 1;

            this.bitMap = new Bitmap(Canva.Width, Canva.Height);
            graphica = Graphics.FromImage(bitMap);
            graphica.Clear(Color.White);
            Canva.Image = bitMap;

            this.Points = new List<Point>();
            this.figuresStorage = new Storage();

            this.serializer = new Serializer();
            this.plugin = new PluginLoading();

            this.pencil = new Pen(Color.Black);
            this.eraser = new Pen(Color.White, 10);
            pencil.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pencil.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            this.x1 = this.y1 = 0;
        }


        private Bitmap bitMap;
        private bool IsDrawing;
        private bool IsPencil;
        private bool IsFigure;
        private bool IsEraser;
        private bool IsFill;
        private Point first, second;
        private List<Point> Points;
        private Figure figure;
        private Storage figuresStorage;
        private Creator creator;
        private Color penColor, fillColor;
        private int pencilWidth;
        private int x1, y1;
        private Graphics graphica;
        private Pen pencil;
        private Pen eraser;
        private Serializer serializer;
        private PluginLoading plugin;
        private Type current;

        //MOUSE
        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null && !creator.IsPolyline)
            {
                if (e.Button == MouseButtons.Left)
                {
                    first = e.Location;

                    Points.Clear();
                    Points.Add(first);
                    Points.Add(first);

                    IsDrawing = !IsDrawing;
                    figure.IsFill = IsFill;
                }
            }
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing && IsFigure)
            {

                second = e.Location;

                Points[Points.Count - 1] = second;

                figure.points = Points.ToArray();
                Canva.Refresh();
            }

            if (IsPencil && e.Button == MouseButtons.Left)
            {
                IsFigure = false;
                graphica.DrawLine(pencil, x1, y1, e.X, e.Y);
                Canva.Image = bitMap;
            }

            if (IsEraser && e.Button == MouseButtons.Left)
            {
                IsFigure = false;
                graphica.DrawLine(eraser, x1, y1, e.X, e.Y);
                Canva.Image = bitMap;
            }

            x1 = e.X;
            y1 = e.Y;
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsDrawing && !creator.IsPolyline)
            {
                second = e.Location;

                IsDrawing = !IsDrawing;
                //IsFigure = !IsFigure;

                if (first != second)
                {
                    Points[1] = second;
                    figuresStorage.UndoStack.Push(figure);

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

                if (e.Button == MouseButtons.Left)
                {
                    first = e.Location;

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
                else if (e.Button == MouseButtons.Right)
                {
                    IsDrawing = !IsDrawing;

                    Undo.Enabled = true;
                    figuresStorage.UndoStack.Push(figure);
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
        private void PencilButton_Click(object sender, EventArgs e)
        {
            /*creator = new CurveLineCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);*/
            IsPencil = true;
            IsEraser = false;
            IsDrawing = false;

        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            IsEraser = true;
            IsPencil = false;
            IsDrawing = false;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            creator = new PolygonCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void PolyLines_Click(object sender, EventArgs e)
        {
            creator = new PolylinesCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            creator = new LineCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            creator = new EllipseCreator();
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
                pencil.Color = colorDialog1.Color;

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
            pencil.Width = PenWidth.Value;
            eraser.Width = PenWidth.Value;

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
            if (figuresStorage.UndoStack.IsEmpty())
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

        //SERIALIZE/DESERIALIZE/SAVE
        private void SerializeButton_Click(object sender, EventArgs e)
        {
            serializer.Serialize(figuresStorage);
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            figuresStorage = serializer.Deserialize(figuresStorage);
            Canva.Refresh();

            if (!figuresStorage.UndoStack.IsEmpty())
            {
                Undo.Enabled = true;
            }
            if (!figuresStorage.RedoStack.IsEmpty())
            {
                Redo.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image(*.jpg)|*.jpg|All files|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var map = bitMap.Clone(new Rectangle(0, 0, Canva.Width, Canva.Height), bitMap.PixelFormat);
                map.Save(saveFileDialog1.FileName);//, ImageFormat.Jpeg);

            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitMap = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                Canva.Image = bitMap;
            }
        }

        //PLUGIN
        private void AddPlugin_Click(object sender, EventArgs e)
        {
            string pluginName;
            openFileDialog1.Filter = @"Your plugin (*.dll)|*.dll";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pluginName = plugin.Load(openFileDialog1);

                    if (pluginName != "")
                    {
                        Plugins.Items.Add(pluginName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Plugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pluginName = Plugins.GetItemText(Plugins.SelectedItem);

            current = plugin.GetPluginType(pluginName);
            creator = (Creator)Activator.CreateInstance(current);
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        //just..
        private void SetStage(Creator creator)
        {
            IsPencil = false;
            IsEraser = false;
            IsFigure = true;

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
