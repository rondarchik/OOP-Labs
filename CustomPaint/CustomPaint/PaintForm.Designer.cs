namespace CustomPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Plugins = new System.Windows.Forms.ComboBox();
            this.AddPlugin = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.FillCheck = new System.Windows.Forms.CheckBox();
            this.PenWidth = new System.Windows.Forms.TrackBar();
            this.PenLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChoosedColor = new System.Windows.Forms.Button();
            this.FilledColor = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PencilButton = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.PolyLines = new System.Windows.Forms.Button();
            this.Canva = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidth)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Plugins);
            this.panel1.Controls.Add(this.AddPlugin);
            this.panel1.Controls.Add(this.SerializeButton);
            this.panel1.Controls.Add(this.DeserializeButton);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.FillCheck);
            this.panel1.Controls.Add(this.PenWidth);
            this.panel1.Controls.Add(this.PenLabel);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1452, 168);
            this.panel1.TabIndex = 0;
            // 
            // Plugins
            // 
            this.Plugins.FormattingEnabled = true;
            this.Plugins.Location = new System.Drawing.Point(1098, 74);
            this.Plugins.Name = "Plugins";
            this.Plugins.Size = new System.Drawing.Size(150, 24);
            this.Plugins.TabIndex = 23;
            this.Plugins.SelectedIndexChanged += new System.EventHandler(this.Plugins_SelectedIndexChanged);
            // 
            // AddPlugin
            // 
            this.AddPlugin.Location = new System.Drawing.Point(1098, 31);
            this.AddPlugin.Name = "AddPlugin";
            this.AddPlugin.Size = new System.Drawing.Size(150, 31);
            this.AddPlugin.TabIndex = 22;
            this.AddPlugin.Text = "Add Plugins";
            this.AddPlugin.UseVisualStyleBackColor = true;
            this.AddPlugin.Click += new System.EventHandler(this.AddPlugin_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(1314, 31);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(112, 31);
            this.SerializeButton.TabIndex = 21;
            this.SerializeButton.Text = "Serialize";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(1314, 72);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(112, 31);
            this.DeserializeButton.TabIndex = 20;
            this.DeserializeButton.Text = "Deserialize";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Undo);
            this.flowLayoutPanel3.Controls.Add(this.Redo);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(518, 7);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(110, 55);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // Undo
            // 
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Image = global::CustomPaint.Properties.Resources.undo1;
            this.Undo.Location = new System.Drawing.Point(3, 3);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(45, 46);
            this.Undo.TabIndex = 18;
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redo.Image = global::CustomPaint.Properties.Resources.redo2;
            this.Redo.Location = new System.Drawing.Point(54, 3);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(46, 46);
            this.Redo.TabIndex = 17;
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // FillCheck
            // 
            this.FillCheck.AutoSize = true;
            this.FillCheck.Location = new System.Drawing.Point(17, 139);
            this.FillCheck.Name = "FillCheck";
            this.FillCheck.Size = new System.Drawing.Size(76, 20);
            this.FillCheck.TabIndex = 14;
            this.FillCheck.Text = "Is Feel?";
            this.FillCheck.UseVisualStyleBackColor = true;
            this.FillCheck.CheckedChanged += new System.EventHandler(this.FillCheck_CheckedChanged);
            // 
            // PenWidth
            // 
            this.PenWidth.Location = new System.Drawing.Point(182, 59);
            this.PenWidth.Maximum = 25;
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(178, 56);
            this.PenWidth.TabIndex = 13;
            this.PenWidth.Scroll += new System.EventHandler(this.PenWidth_Scroll);
            // 
            // PenLabel
            // 
            this.PenLabel.AutoSize = true;
            this.PenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenLabel.Location = new System.Drawing.Point(189, 31);
            this.PenLabel.Name = "PenLabel";
            this.PenLabel.Size = new System.Drawing.Size(103, 25);
            this.PenLabel.TabIndex = 12;
            this.PenLabel.Text = "Pen Width";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1314, 111);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(112, 31);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Toolbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Panel";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ChoosedColor);
            this.flowLayoutPanel1.Controls.Add(this.FilledColor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 68);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ChoosedColor
            // 
            this.ChoosedColor.BackColor = System.Drawing.Color.White;
            this.ChoosedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosedColor.Location = new System.Drawing.Point(3, 3);
            this.ChoosedColor.Name = "ChoosedColor";
            this.ChoosedColor.Size = new System.Drawing.Size(55, 55);
            this.ChoosedColor.TabIndex = 7;
            this.ChoosedColor.Text = "Pen";
            this.ChoosedColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChoosedColor.UseVisualStyleBackColor = false;
            this.ChoosedColor.Click += new System.EventHandler(this.ChoosedColor_Click);
            // 
            // FilledColor
            // 
            this.FilledColor.BackColor = System.Drawing.Color.White;
            this.FilledColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledColor.Location = new System.Drawing.Point(64, 3);
            this.FilledColor.Name = "FilledColor";
            this.FilledColor.Size = new System.Drawing.Size(55, 55);
            this.FilledColor.TabIndex = 14;
            this.FilledColor.Text = "Fill";
            this.FilledColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FilledColor.UseVisualStyleBackColor = false;
            this.FilledColor.Click += new System.EventHandler(this.FilledColor_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.PencilButton);
            this.flowLayoutPanel2.Controls.Add(this.Eraser);
            this.flowLayoutPanel2.Controls.Add(this.Line);
            this.flowLayoutPanel2.Controls.Add(this.Rectangle);
            this.flowLayoutPanel2.Controls.Add(this.Ellipse);
            this.flowLayoutPanel2.Controls.Add(this.Polygon);
            this.flowLayoutPanel2.Controls.Add(this.PolyLines);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(403, 71);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(653, 91);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // PencilButton
            // 
            this.PencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PencilButton.Image = global::CustomPaint.Properties.Resources.pencil;
            this.PencilButton.Location = new System.Drawing.Point(3, 3);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(85, 75);
            this.PencilButton.TabIndex = 9;
            this.PencilButton.Text = "Pencil";
            this.PencilButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PencilButton.UseVisualStyleBackColor = true;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // Eraser
            // 
            this.Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Eraser.Image = global::CustomPaint.Properties.Resources.eraser;
            this.Eraser.Location = new System.Drawing.Point(94, 3);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(85, 75);
            this.Eraser.TabIndex = 10;
            this.Eraser.Text = "Eraser";
            this.Eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // Line
            // 
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Line.Image = global::CustomPaint.Properties.Resources.line;
            this.Line.Location = new System.Drawing.Point(185, 3);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(85, 75);
            this.Line.TabIndex = 4;
            this.Line.Text = "Line";
            this.Line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Rectangle.Image = global::CustomPaint.Properties.Resources.rectangle;
            this.Rectangle.Location = new System.Drawing.Point(276, 3);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(85, 75);
            this.Rectangle.TabIndex = 5;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Ellipse.Image = global::CustomPaint.Properties.Resources.circle;
            this.Ellipse.Location = new System.Drawing.Point(367, 3);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(85, 75);
            this.Ellipse.TabIndex = 6;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Polygon
            // 
            this.Polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Polygon.Image = global::CustomPaint.Properties.Resources.polygon1;
            this.Polygon.Location = new System.Drawing.Point(458, 3);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(85, 75);
            this.Polygon.TabIndex = 7;
            this.Polygon.Text = "Polygon";
            this.Polygon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // PolyLines
            // 
            this.PolyLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolyLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PolyLines.Image = global::CustomPaint.Properties.Resources.polyline;
            this.PolyLines.Location = new System.Drawing.Point(549, 3);
            this.PolyLines.Name = "PolyLines";
            this.PolyLines.Size = new System.Drawing.Size(85, 75);
            this.PolyLines.TabIndex = 8;
            this.PolyLines.Text = "PolyLines";
            this.PolyLines.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PolyLines.UseVisualStyleBackColor = true;
            this.PolyLines.Click += new System.EventHandler(this.PolyLines_Click);
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canva.Location = new System.Drawing.Point(0, 168);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(1452, 887);
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            this.Canva.Paint += new System.Windows.Forms.PaintEventHandler(this.Canva_Paint);
            this.Canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseClick);
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 1055);
            this.Controls.Add(this.Canva);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PenWidth)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Canva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChoosedColor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar PenWidth;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button PolyLines;
        private System.Windows.Forms.Button FilledColor;
        private System.Windows.Forms.CheckBox FillCheck;
        private System.Windows.Forms.Label PenLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.ComboBox Plugins;
        private System.Windows.Forms.Button AddPlugin;
        private System.Windows.Forms.Button PencilButton;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

