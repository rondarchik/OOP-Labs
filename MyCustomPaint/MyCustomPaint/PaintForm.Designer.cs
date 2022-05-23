namespace MyCustomPaint
{
    partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.Canva = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.PluginComboBox = new System.Windows.Forms.ComboBox();
            this.PluginButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.ActionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.FillCheckBox = new System.Windows.Forms.CheckBox();
            this.PenWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ToolboxLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.FiguresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PencilButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.PolylineButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.Menu.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).BeginInit();
            this.ColorPanel.SuspendLayout();
            this.FiguresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canva.Location = new System.Drawing.Point(0, 0);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(1432, 753);
            this.Canva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            this.Canva.Paint += new System.Windows.Forms.PaintEventHandler(this.Canva_Paint);
            this.Canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseClick);
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Menu.Controls.Add(this.PluginComboBox);
            this.Menu.Controls.Add(this.PluginButton);
            this.Menu.Controls.Add(this.SerializeButton);
            this.Menu.Controls.Add(this.DeserializeButton);
            this.Menu.Controls.Add(this.ActionsPanel);
            this.Menu.Controls.Add(this.FillCheckBox);
            this.Menu.Controls.Add(this.PenWidthTrackBar);
            this.Menu.Controls.Add(this.PenWidthLabel);
            this.Menu.Controls.Add(this.ClearButton);
            this.Menu.Controls.Add(this.ToolboxLabel);
            this.Menu.Controls.Add(this.ColorLabel);
            this.Menu.Controls.Add(this.ColorPanel);
            this.Menu.Controls.Add(this.FiguresPanel);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1432, 171);
            this.Menu.TabIndex = 1;
            // 
            // PluginComboBox
            // 
            this.PluginComboBox.FormattingEnabled = true;
            this.PluginComboBox.Location = new System.Drawing.Point(1097, 78);
            this.PluginComboBox.Name = "PluginComboBox";
            this.PluginComboBox.Size = new System.Drawing.Size(150, 24);
            this.PluginComboBox.TabIndex = 36;
            // 
            // PluginButton
            // 
            this.PluginButton.Location = new System.Drawing.Point(1097, 35);
            this.PluginButton.Name = "PluginButton";
            this.PluginButton.Size = new System.Drawing.Size(150, 31);
            this.PluginButton.TabIndex = 35;
            this.PluginButton.Text = "Add Plugins";
            this.PluginButton.UseVisualStyleBackColor = true;
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(1313, 35);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(112, 31);
            this.SerializeButton.TabIndex = 34;
            this.SerializeButton.Text = "Serialize";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(1313, 76);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(112, 31);
            this.DeserializeButton.TabIndex = 33;
            this.DeserializeButton.Text = "Deserialize";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.UndoButton);
            this.ActionsPanel.Controls.Add(this.RedoButton);
            this.ActionsPanel.Location = new System.Drawing.Point(517, 11);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(110, 55);
            this.ActionsPanel.TabIndex = 32;
            // 
            // UndoButton
            // 
            this.UndoButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.undo;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Location = new System.Drawing.Point(3, 3);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(45, 46);
            this.UndoButton.TabIndex = 18;
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.redo;
            this.RedoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedoButton.Location = new System.Drawing.Point(54, 3);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(46, 46);
            this.RedoButton.TabIndex = 17;
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // FillCheckBox
            // 
            this.FillCheckBox.AutoSize = true;
            this.FillCheckBox.Location = new System.Drawing.Point(16, 143);
            this.FillCheckBox.Name = "FillCheckBox";
            this.FillCheckBox.Size = new System.Drawing.Size(76, 20);
            this.FillCheckBox.TabIndex = 31;
            this.FillCheckBox.Text = "Is Feel?";
            this.FillCheckBox.UseVisualStyleBackColor = true;
            this.FillCheckBox.CheckedChanged += new System.EventHandler(this.FillCheckBox_CheckedChanged);
            // 
            // PenWidthTrackBar
            // 
            this.PenWidthTrackBar.Location = new System.Drawing.Point(181, 63);
            this.PenWidthTrackBar.Maximum = 25;
            this.PenWidthTrackBar.Name = "PenWidthTrackBar";
            this.PenWidthTrackBar.Size = new System.Drawing.Size(178, 56);
            this.PenWidthTrackBar.TabIndex = 30;
            this.PenWidthTrackBar.Scroll += new System.EventHandler(this.PenWidthTrackBar_Scroll);
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.AutoSize = true;
            this.PenWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenWidthLabel.Location = new System.Drawing.Point(188, 35);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(103, 25);
            this.PenWidthLabel.TabIndex = 29;
            this.PenWidthLabel.Text = "Pen Width";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1313, 115);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 31);
            this.ClearButton.TabIndex = 28;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ToolboxLabel
            // 
            this.ToolboxLabel.AutoSize = true;
            this.ToolboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolboxLabel.Location = new System.Drawing.Point(428, 22);
            this.ToolboxLabel.Name = "ToolboxLabel";
            this.ToolboxLabel.Size = new System.Drawing.Size(83, 25);
            this.ToolboxLabel.TabIndex = 27;
            this.ToolboxLabel.Text = "Toolbox";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(11, 35);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(114, 25);
            this.ColorLabel.TabIndex = 24;
            this.ColorLabel.Text = "Color Panel";
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.PenColorButton);
            this.ColorPanel.Controls.Add(this.FillColorButton);
            this.ColorPanel.Location = new System.Drawing.Point(11, 63);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(148, 74);
            this.ColorPanel.TabIndex = 25;
            // 
            // PenColorButton
            // 
            this.PenColorButton.BackColor = System.Drawing.Color.White;
            this.PenColorButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.color;
            this.PenColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PenColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenColorButton.Location = new System.Drawing.Point(3, 3);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(65, 65);
            this.PenColorButton.TabIndex = 7;
            this.PenColorButton.Text = "Pen";
            this.PenColorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PenColorButton.UseVisualStyleBackColor = false;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // FillColorButton
            // 
            this.FillColorButton.BackColor = System.Drawing.Color.White;
            this.FillColorButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.bucket;
            this.FillColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FillColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillColorButton.Location = new System.Drawing.Point(74, 3);
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(65, 65);
            this.FillColorButton.TabIndex = 14;
            this.FillColorButton.Text = "Fill";
            this.FillColorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FillColorButton.UseVisualStyleBackColor = false;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // FiguresPanel
            // 
            this.FiguresPanel.Controls.Add(this.PencilButton);
            this.FiguresPanel.Controls.Add(this.EraserButton);
            this.FiguresPanel.Controls.Add(this.LineButton);
            this.FiguresPanel.Controls.Add(this.RectangleButton);
            this.FiguresPanel.Controls.Add(this.EllipseButton);
            this.FiguresPanel.Controls.Add(this.PolygonButton);
            this.FiguresPanel.Controls.Add(this.PolylineButton);
            this.FiguresPanel.Location = new System.Drawing.Point(402, 75);
            this.FiguresPanel.Name = "FiguresPanel";
            this.FiguresPanel.Size = new System.Drawing.Size(653, 91);
            this.FiguresPanel.TabIndex = 26;
            // 
            // PencilButton
            // 
            this.PencilButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.pencil;
            this.PencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PencilButton.Location = new System.Drawing.Point(3, 3);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(85, 75);
            this.PencilButton.TabIndex = 9;
            this.PencilButton.Text = "Pencil";
            this.PencilButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PencilButton.UseVisualStyleBackColor = true;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.eraser;
            this.EraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.EraserButton.Location = new System.Drawing.Point(94, 3);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(85, 75);
            this.EraserButton.TabIndex = 10;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.line;
            this.LineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LineButton.Location = new System.Drawing.Point(185, 3);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(85, 75);
            this.LineButton.TabIndex = 4;
            this.LineButton.Text = "Line";
            this.LineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.rectangle;
            this.RectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.RectangleButton.Location = new System.Drawing.Point(276, 3);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(85, 75);
            this.RectangleButton.TabIndex = 5;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.circle;
            this.EllipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EllipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.EllipseButton.Location = new System.Drawing.Point(367, 3);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(85, 75);
            this.EllipseButton.TabIndex = 6;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.polygon;
            this.PolygonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolygonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PolygonButton.Location = new System.Drawing.Point(458, 3);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(85, 75);
            this.PolygonButton.TabIndex = 7;
            this.PolygonButton.Text = "Polygon";
            this.PolygonButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // PolylineButton
            // 
            this.PolylineButton.BackgroundImage = global::MyCustomPaint.Properties.Resources.polyline;
            this.PolylineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PolylineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolylineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PolylineButton.Location = new System.Drawing.Point(549, 3);
            this.PolylineButton.Name = "PolylineButton";
            this.PolylineButton.Size = new System.Drawing.Size(85, 75);
            this.PolylineButton.TabIndex = 8;
            this.PolylineButton.Text = "PolyLines";
            this.PolylineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PolylineButton.UseVisualStyleBackColor = true;
            this.PolylineButton.Click += new System.EventHandler(this.PolylineButton_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 753);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Canva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ActionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).EndInit();
            this.ColorPanel.ResumeLayout(false);
            this.FiguresPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canva;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.ComboBox PluginComboBox;
        private System.Windows.Forms.Button PluginButton;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.FlowLayoutPanel ActionsPanel;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.CheckBox FillCheckBox;
        private System.Windows.Forms.TrackBar PenWidthTrackBar;
        private System.Windows.Forms.Label PenWidthLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ToolboxLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.FlowLayoutPanel ColorPanel;
        private System.Windows.Forms.Button PenColorButton;
        private System.Windows.Forms.Button FillColorButton;
        private System.Windows.Forms.FlowLayoutPanel FiguresPanel;
        private System.Windows.Forms.Button PencilButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button PolygonButton;
        private System.Windows.Forms.Button PolylineButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

