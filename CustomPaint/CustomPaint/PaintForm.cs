﻿using CustomPaint.Actions;
using CustomPaint.Creators;
using CustomPaint.Figures;
using CustomPaint.PluginTools;
using CustomPaint.SerializerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomPaint
{
    public partial class PaintForm : Form
    {
        #region LocalVaribles
        //public static FigureList figureList = new FigureList();
        //public static FigureCreatorList figureCreatorList = new FigureCreatorList();

        private Bitmap bitMap;
        private bool IsDrawing;
        /*public bool IsUserFigure = false;
        public bool IsFirstUserFigure = false;
        NewFigure constUserFigure = new NewFigure();*/
        private bool IsPencil;
        private bool IsFigure;
        private bool IsEraser;
        private bool IsFill;
        private Point first, second;
        private List<Point> Points;
        private Figure figure;
        private Storage figuresStorage;
        private ICreator creator;
        private Color penColor, fillColor;
        private int pencilWidth;
        private int x1, y1;
        private Graphics graphica;
        private Pen pencil;
        private Pen eraser;
        private Serializer serializer;
        private Plugin plugin;

        public object UserFigure { get; private set; }
        #endregion

        #region InitFunctions
        public PaintForm()
        {
            InitializeComponent();

            StartInit();

            //AddPlugins();

            //AddPluginFigures();
        }

        private void SetStage(ICreator creator)
        {
            IsPencil = false;
            IsEraser = false;
            IsFigure = true;

            if (creator.IsCanFill)
            {
                FillCheckBox.Enabled = true;
            }
            else
            {
                FillCheckBox.Enabled = false;
            }
        }

        private void StartInit()
        {
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
            this.plugin = new Plugin();

            this.pencil = new Pen(Color.Black);
            this.eraser = new Pen(Color.White, 10);
            pencil.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pencil.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            this.x1 = this.y1 = 0;
        }
        #endregion

        #region CanvaMouseActions
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
                        RedoButton.Enabled = false;
                    }

                    UndoButton.Enabled = true;
                }

                figure = (Figure)figure.Clone();
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

                    UndoButton.Enabled = true;
                    figuresStorage.UndoStack.Push(figure);
                    figure = (Figure)figure.Clone();

                    if (!figuresStorage.RedoStack.IsEmpty())
                    {
                        figuresStorage.RedoStack.ClearStack();
                        RedoButton.Enabled = false;
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

        #endregion

        #region SetColor
        private void PenColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
                penColor = colorDialog1.Color;
                pencil.Color = colorDialog1.Color;

                if (figure != null)
                {
                    figure.color = penColor;
                    figure.Pen.Color = penColor;
                }
            }
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
                fillColor = colorDialog1.Color;

                if ((figure != null) && FillCheckBox.Enabled)
                {
                    // Содержит методы для локального или удаленного создания типов объектов или получения ссылок на существующие удаленные объекты.
                    // Создает экземпляр указанного типа, используя конструктор, который лучше всего соответствует указанным параметрам.
                    object[] args = new object[3] { penColor, fillColor, pencilWidth };
                    figure = (Figure)Activator.CreateInstance(figure.GetType(), args);
                }
            }
        }

        private void FillCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FillCheckBox.Checked)
            {
                IsFill = true;
            }
            else
            {
                IsFill = false;
            }
        }

        #endregion

        #region FiguresButton
        private void PencilButton_Click(object sender, EventArgs e)
        {
            IsPencil = true;
            IsEraser = false;
            IsDrawing = false;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            IsPencil = false;
            IsEraser = true;
            IsDrawing = false;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            creator = new LineCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            creator = new EllipseCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            creator = new PolygonCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }

        private void PolylineButton_Click(object sender, EventArgs e)
        {
            creator = new PolylineCreator();
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }
        #endregion

        #region Undo/Redo
        private void UndoButton_Click(object sender, EventArgs e)
        {
            figuresStorage.Undo();
            Canva?.Refresh();

            RedoButton.Enabled = true;
            if (figuresStorage.UndoStack.IsEmpty())
                UndoButton.Enabled = false;
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            figuresStorage.Redo();
            Canva?.Refresh();

            UndoButton.Enabled = true;
            if (figuresStorage.RedoStack.IsEmpty())
                RedoButton.Enabled = false;
        }
        #endregion

        #region Serialize
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
                UndoButton.Enabled = true;
            }
            if (!figuresStorage.RedoStack.IsEmpty())
            {
                RedoButton.Enabled = true;
            }
        }
        #endregion

        #region PenWidth&CLear
        private void ClearButton_Click(object sender, EventArgs e)
        {
            figuresStorage.Clear();
            Canva.Refresh();

            UndoButton.Enabled = false;
            RedoButton.Enabled = false;

            graphica.Clear(Canva.BackColor);
            Canva.Image = bitMap;
        }

        private void WidthTrackBar_Scroll(object sender, EventArgs e)
        {
            pencilWidth = WidthTrackBar.Value;
            pencil.Width = WidthTrackBar.Value;
            eraser.Width = WidthTrackBar.Value;

            if (figure != null)
            {
                figure.penWidth = pencilWidth;
                figure.Pen.Width = pencilWidth;
            }

            PenWidthLabel.Text = "Pen Width: " + pencilWidth.ToString();
        }
        #endregion

        #region Plugins
        /*
        // .dll plugins adding
        private void AddPlugins()
        {
            // find a directory of .exe file      
            string AddInDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            // .dll files are to be located in the same directory as .exe is  
            var AddInAssemblies = Directory.EnumerateFiles(AddInDir, "*Library.dll");
            // types creating

            foreach (var ass in AddInAssemblies)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(ass);
                    Type[] types = assembly.GetExportedTypes();
                    foreach (var type in types)
                    {
                        if (type.IsClass && typeof(ICreator).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
                        {
                            var plugin = Activator.CreateInstance(type);
                            figureCreatorList.Creators.Add((ICreator)plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserFigureButton_Click(object sender, EventArgs e)
        {
            IsUserFigure = true;
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            NewFigure tempUserFigure = (NewFigure)clickedItem.Tag;
            figure = (NewFigure)tempUserFigure.Clone();
            constUserFigure = (NewFigure)tempUserFigure.Clone();
            IsFirstUserFigure = true;
        }


        private void AddUserFigures()
        {
            NewFigure.fieldHeight = Canva.Size.Width;
            NewFigure.fieldWidth = Canva.Size.Height;
            String localDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var userFiguresFiles = Directory.EnumerateFiles(localDirectory, "*UserFigure.txt");
            ToolStripMenuItem item;
            foreach (var userFigureFile in userFiguresFiles)
            {
                try
                {
                    Stream fileStream = File.Open(userFigureFile, FileMode.Open);
                    Serializer serializer = new Serializer();
                    NewFigure userFigure = new NewFigure()
                    {
                        userFigureList = serializer.DeserializeUserFigure(fileStream)
                    };
                    item = new ToolStripMenuItem()
                    {
                        Tag = userFigure
                    };
                    item.Click += new EventHandler(UserFigureButton_Click);
                    //menuStrip1.Add(item);
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            /*catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


        private void PluginButton_Click(object sender, EventArgs e)
        {
            string pluginName;
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"File dll (*.dll)|*.dll"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pluginName = plugin.Load(openFileDialog);

                if (pluginName != "")
                {
                    TrapezoidButton.Text = pluginName;
                    TrapezoidButton.Visible = true;
                }
            }
        }

        private void TrapezoidButton_Click(object sender, EventArgs e)
        {
            string pluginName = TrapezoidButton.Text;
            var type = plugin.GetPluginType(pluginName);

            creator = (ICreator)Activator.CreateInstance(type);
            figure = creator.Create(penColor, fillColor, pencilWidth);

            SetStage(creator);
        }
        #endregion
    }
}