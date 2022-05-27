namespace CustomPaint
{
    partial class PaintForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TrapezoidButton = new System.Windows.Forms.Button();
            this.PluginButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.WidthTrackBar = new System.Windows.Forms.TrackBar();
            this.FillCheckBox = new System.Windows.Forms.CheckBox();
            this.ActionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.FiguresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PencilButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.PolylineButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.ToolboxLabel = new System.Windows.Forms.Label();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.Canva = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).BeginInit();
            this.ActionsPanel.SuspendLayout();
            this.FiguresPanel.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.MenuPanel.Controls.Add(this.TrapezoidButton);
            this.MenuPanel.Controls.Add(this.PluginButton);
            this.MenuPanel.Controls.Add(this.ClearButton);
            this.MenuPanel.Controls.Add(this.DeserializeButton);
            this.MenuPanel.Controls.Add(this.SerializeButton);
            this.MenuPanel.Controls.Add(this.WidthTrackBar);
            this.MenuPanel.Controls.Add(this.FillCheckBox);
            this.MenuPanel.Controls.Add(this.ActionsPanel);
            this.MenuPanel.Controls.Add(this.FiguresPanel);
            this.MenuPanel.Controls.Add(this.ColorPanel);
            this.MenuPanel.Controls.Add(this.ToolboxLabel);
            this.MenuPanel.Controls.Add(this.PenWidthLabel);
            this.MenuPanel.Controls.Add(this.ColorLabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1906, 219);
            this.MenuPanel.TabIndex = 0;
            // 
            // TrapezoidButton
            // 
            this.TrapezoidButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TrapezoidButton.Location = new System.Drawing.Point(1477, 71);
            this.TrapezoidButton.Name = "TrapezoidButton";
            this.TrapezoidButton.Size = new System.Drawing.Size(157, 33);
            this.TrapezoidButton.TabIndex = 12;
            this.TrapezoidButton.Text = "Rhombus";
            this.TrapezoidButton.UseVisualStyleBackColor = true;
            this.TrapezoidButton.Visible = false;
            this.TrapezoidButton.Click += new System.EventHandler(this.TrapezoidButton_Click);
            // 
            // PluginButton
            // 
            this.PluginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PluginButton.Location = new System.Drawing.Point(1477, 33);
            this.PluginButton.Name = "PluginButton";
            this.PluginButton.Size = new System.Drawing.Size(157, 32);
            this.PluginButton.TabIndex = 10;
            this.PluginButton.Text = "Add figure";
            this.PluginButton.UseVisualStyleBackColor = true;
            this.PluginButton.Click += new System.EventHandler(this.PluginButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Location = new System.Drawing.Point(1706, 168);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 32);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeserializeButton.Location = new System.Drawing.Point(1706, 71);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(151, 32);
            this.DeserializeButton.TabIndex = 8;
            this.DeserializeButton.Text = "Deserialize";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SerializeButton.Location = new System.Drawing.Point(1706, 33);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(151, 32);
            this.SerializeButton.TabIndex = 1;
            this.SerializeButton.Text = "Serialize";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // WidthTrackBar
            // 
            this.WidthTrackBar.LargeChange = 50;
            this.WidthTrackBar.Location = new System.Drawing.Point(301, 69);
            this.WidthTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTrackBar.Maximum = 50;
            this.WidthTrackBar.Minimum = 1;
            this.WidthTrackBar.Name = "WidthTrackBar";
            this.WidthTrackBar.Size = new System.Drawing.Size(294, 56);
            this.WidthTrackBar.TabIndex = 7;
            this.WidthTrackBar.Value = 1;
            this.WidthTrackBar.Scroll += new System.EventHandler(this.WidthTrackBar_Scroll);
            // 
            // FillCheckBox
            // 
            this.FillCheckBox.AutoSize = true;
            this.FillCheckBox.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillCheckBox.Location = new System.Drawing.Point(116, 168);
            this.FillCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.FillCheckBox.Name = "FillCheckBox";
            this.FillCheckBox.Size = new System.Drawing.Size(84, 29);
            this.FillCheckBox.TabIndex = 6;
            this.FillCheckBox.Text = "Filled";
            this.FillCheckBox.UseVisualStyleBackColor = true;
            this.FillCheckBox.CheckedChanged += new System.EventHandler(this.FillCheckBox_CheckedChanged);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.UndoButton);
            this.ActionsPanel.Controls.Add(this.RedoButton);
            this.ActionsPanel.Location = new System.Drawing.Point(839, 11);
            this.ActionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(119, 66);
            this.ActionsPanel.TabIndex = 5;
            // 
            // UndoButton
            // 
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UndoButton.Image = global::CustomPaint.Properties.Resources.undo;
            this.UndoButton.Location = new System.Drawing.Point(4, 4);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(50, 50);
            this.UndoButton.TabIndex = 2;
            this.UndoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedoButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedoButton.Image = global::CustomPaint.Properties.Resources.redo;
            this.RedoButton.Location = new System.Drawing.Point(62, 4);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(50, 50);
            this.RedoButton.TabIndex = 3;
            this.RedoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // FiguresPanel
            // 
            this.FiguresPanel.Controls.Add(this.PencilButton);
            this.FiguresPanel.Controls.Add(this.EraserButton);
            this.FiguresPanel.Controls.Add(this.LineButton);
            this.FiguresPanel.Controls.Add(this.RectangleButton);
            this.FiguresPanel.Controls.Add(this.EllipseButton);
            this.FiguresPanel.Controls.Add(this.PolylineButton);
            this.FiguresPanel.Controls.Add(this.PolygonButton);
            this.FiguresPanel.Location = new System.Drawing.Point(712, 85);
            this.FiguresPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FiguresPanel.Name = "FiguresPanel";
            this.FiguresPanel.Size = new System.Drawing.Size(703, 96);
            this.FiguresPanel.TabIndex = 4;
            // 
            // PencilButton
            // 
            this.PencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PencilButton.Image = global::CustomPaint.Properties.Resources.pencil;
            this.PencilButton.Location = new System.Drawing.Point(4, 4);
            this.PencilButton.Margin = new System.Windows.Forms.Padding(4);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(89, 81);
            this.PencilButton.TabIndex = 2;
            this.PencilButton.Text = "Pencil";
            this.PencilButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PencilButton.UseVisualStyleBackColor = true;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraserButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EraserButton.Image = global::CustomPaint.Properties.Resources.eraser;
            this.EraserButton.Location = new System.Drawing.Point(101, 4);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(4);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(89, 81);
            this.EraserButton.TabIndex = 3;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LineButton.Image = global::CustomPaint.Properties.Resources.line;
            this.LineButton.Location = new System.Drawing.Point(198, 4);
            this.LineButton.Margin = new System.Windows.Forms.Padding(4);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(89, 81);
            this.LineButton.TabIndex = 4;
            this.LineButton.Text = "Line";
            this.LineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RectangleButton.Image = global::CustomPaint.Properties.Resources.rectangle;
            this.RectangleButton.Location = new System.Drawing.Point(295, 4);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(89, 81);
            this.RectangleButton.TabIndex = 5;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EllipseButton.Image = global::CustomPaint.Properties.Resources.circle;
            this.EllipseButton.Location = new System.Drawing.Point(392, 4);
            this.EllipseButton.Margin = new System.Windows.Forms.Padding(4);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(89, 81);
            this.EllipseButton.TabIndex = 6;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // PolylineButton
            // 
            this.PolylineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolylineButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PolylineButton.Image = global::CustomPaint.Properties.Resources.polyline;
            this.PolylineButton.Location = new System.Drawing.Point(489, 4);
            this.PolylineButton.Margin = new System.Windows.Forms.Padding(4);
            this.PolylineButton.Name = "PolylineButton";
            this.PolylineButton.Size = new System.Drawing.Size(89, 81);
            this.PolylineButton.TabIndex = 7;
            this.PolylineButton.Text = "Polyline";
            this.PolylineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PolylineButton.UseVisualStyleBackColor = true;
            this.PolylineButton.Click += new System.EventHandler(this.PolylineButton_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolygonButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PolygonButton.Image = global::CustomPaint.Properties.Resources.polygon;
            this.PolygonButton.Location = new System.Drawing.Point(586, 4);
            this.PolygonButton.Margin = new System.Windows.Forms.Padding(4);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(89, 81);
            this.PolygonButton.TabIndex = 8;
            this.PolygonButton.Text = "Polygon";
            this.PolygonButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.PenColorButton);
            this.ColorPanel.Controls.Add(this.FillColorButton);
            this.ColorPanel.Location = new System.Drawing.Point(16, 66);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(202, 94);
            this.ColorPanel.TabIndex = 3;
            // 
            // PenColorButton
            // 
            this.PenColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenColorButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PenColorButton.Image = global::CustomPaint.Properties.Resources.color;
            this.PenColorButton.Location = new System.Drawing.Point(4, 4);
            this.PenColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(89, 81);
            this.PenColorButton.TabIndex = 1;
            this.PenColorButton.Text = "Pen";
            this.PenColorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PenColorButton.UseVisualStyleBackColor = true;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // FillColorButton
            // 
            this.FillColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillColorButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillColorButton.Image = global::CustomPaint.Properties.Resources.bucket;
            this.FillColorButton.Location = new System.Drawing.Point(101, 4);
            this.FillColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(89, 81);
            this.FillColorButton.TabIndex = 2;
            this.FillColorButton.Text = "Fill";
            this.FillColorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FillColorButton.UseVisualStyleBackColor = true;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // ToolboxLabel
            // 
            this.ToolboxLabel.AutoSize = true;
            this.ToolboxLabel.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolboxLabel.Location = new System.Drawing.Point(712, 22);
            this.ToolboxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToolboxLabel.Name = "ToolboxLabel";
            this.ToolboxLabel.Size = new System.Drawing.Size(106, 34);
            this.ToolboxLabel.TabIndex = 2;
            this.ToolboxLabel.Text = "Toolbox";
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.AutoSize = true;
            this.PenWidthLabel.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PenWidthLabel.Location = new System.Drawing.Point(351, 22);
            this.PenWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(135, 34);
            this.PenWidthLabel.TabIndex = 1;
            this.PenWidthLabel.Text = "Pen Width";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorLabel.Location = new System.Drawing.Point(16, 22);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(147, 34);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color Panel";
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canva.Location = new System.Drawing.Point(0, 219);
            this.Canva.Margin = new System.Windows.Forms.Padding(4);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(1906, 836);
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            this.Canva.Paint += new System.Windows.Forms.PaintEventHandler(this.Canva_Paint);
            this.Canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseClick);
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // PaintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1906, 1055);
            this.Controls.Add(this.Canva);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).EndInit();
            this.ActionsPanel.ResumeLayout(false);
            this.FiguresPanel.ResumeLayout(false);
            this.ColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private TrackBar WidthTrackBar;
        private CheckBox FillCheckBox;
        private FlowLayoutPanel ActionsPanel;
        private FlowLayoutPanel FiguresPanel;
        private FlowLayoutPanel ColorPanel;
        private Button PenColorButton;
        private Button FillColorButton;
        private Label ToolboxLabel;
        private Label PenWidthLabel;
        private Label ColorLabel;
        private PictureBox Canva;
        private Button UndoButton;
        private Button RedoButton;
        private Button ClearButton;
        private Button DeserializeButton;
        private Button SerializeButton;
        private Button PencilButton;
        private Button EraserButton;
        private Button LineButton;
        private Button RectangleButton;
        private Button EllipseButton;
        private Button PolylineButton;
        private Button PolygonButton;
        private Button PluginButton;
        private ColorDialog colorDialog1;
        private Button TrapezoidButton;
    }
}