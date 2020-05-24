namespace FormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.FigureLabel = new System.Windows.Forms.Label();
            this.LineWeigthTB = new System.Windows.Forms.TrackBar();
            this.LineWeightLabel = new System.Windows.Forms.Label();
            this.LineColorBt = new System.Windows.Forms.Button();
            this.FigureColorBt = new System.Windows.Forms.Button();
            this.LineColorCD = new System.Windows.Forms.ColorDialog();
            this.FigureColorCD = new System.Windows.Forms.ColorDialog();
            this.UndoLastBt = new System.Windows.Forms.Button();
            this.ClearBt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LineWeigthTB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeCB
            // 
            this.TypeCB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(12, 48);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(198, 21);
            this.TypeCB.TabIndex = 0;
            this.TypeCB.TabStop = false;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DrawPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawPanel.Location = new System.Drawing.Point(216, 40);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(572, 398);
            this.DrawPanel.TabIndex = 1;
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            // 
            // FigureLabel
            // 
            this.FigureLabel.AutoSize = true;
            this.FigureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureLabel.Location = new System.Drawing.Point(12, 27);
            this.FigureLabel.Name = "FigureLabel";
            this.FigureLabel.Size = new System.Drawing.Size(53, 18);
            this.FigureLabel.TabIndex = 0;
            this.FigureLabel.Text = "Figure:";
            // 
            // LineWeigthTB
            // 
            this.LineWeigthTB.LargeChange = 1;
            this.LineWeigthTB.Location = new System.Drawing.Point(12, 111);
            this.LineWeigthTB.Minimum = 1;
            this.LineWeigthTB.Name = "LineWeigthTB";
            this.LineWeigthTB.Size = new System.Drawing.Size(195, 45);
            this.LineWeigthTB.TabIndex = 0;
            this.LineWeigthTB.TabStop = false;
            this.LineWeigthTB.Value = 5;
            this.LineWeigthTB.Scroll += new System.EventHandler(this.LineWeigthTB_Scroll);
            // 
            // LineWeightLabel
            // 
            this.LineWeightLabel.AutoSize = true;
            this.LineWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineWeightLabel.Location = new System.Drawing.Point(12, 90);
            this.LineWeightLabel.Name = "LineWeightLabel";
            this.LineWeightLabel.Size = new System.Drawing.Size(85, 18);
            this.LineWeightLabel.TabIndex = 2;
            this.LineWeightLabel.Text = "Line weight:";
            // 
            // LineColorBt
            // 
            this.LineColorBt.Location = new System.Drawing.Point(15, 162);
            this.LineColorBt.Name = "LineColorBt";
            this.LineColorBt.Size = new System.Drawing.Size(185, 34);
            this.LineColorBt.TabIndex = 0;
            this.LineColorBt.TabStop = false;
            this.LineColorBt.Text = "Choose line color..";
            this.LineColorBt.UseVisualStyleBackColor = true;
            this.LineColorBt.Click += new System.EventHandler(this.LineColorBt_Click);
            // 
            // FigureColorBt
            // 
            this.FigureColorBt.Location = new System.Drawing.Point(15, 211);
            this.FigureColorBt.Name = "FigureColorBt";
            this.FigureColorBt.Size = new System.Drawing.Size(185, 34);
            this.FigureColorBt.TabIndex = 3;
            this.FigureColorBt.TabStop = false;
            this.FigureColorBt.Text = "Choose figure color..";
            this.FigureColorBt.UseVisualStyleBackColor = true;
            this.FigureColorBt.Click += new System.EventHandler(this.FigureColorBt_Click);
            // 
            // UndoLastBt
            // 
            this.UndoLastBt.Location = new System.Drawing.Point(15, 344);
            this.UndoLastBt.Name = "UndoLastBt";
            this.UndoLastBt.Size = new System.Drawing.Size(185, 34);
            this.UndoLastBt.TabIndex = 5;
            this.UndoLastBt.TabStop = false;
            this.UndoLastBt.Text = "Undo last";
            this.UndoLastBt.UseVisualStyleBackColor = true;
            this.UndoLastBt.Click += new System.EventHandler(this.UndoLastBt_Click);
            // 
            // ClearBt
            // 
            this.ClearBt.Location = new System.Drawing.Point(15, 394);
            this.ClearBt.Name = "ClearBt";
            this.ClearBt.Size = new System.Drawing.Size(185, 34);
            this.ClearBt.TabIndex = 6;
            this.ClearBt.TabStop = false;
            this.ClearBt.Text = "Clear All";
            this.ClearBt.UseVisualStyleBackColor = true;
            this.ClearBt.Click += new System.EventHandler(this.ClearBt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open..";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBt);
            this.Controls.Add(this.UndoLastBt);
            this.Controls.Add(this.FigureColorBt);
            this.Controls.Add(this.LineColorBt);
            this.Controls.Add(this.LineWeightLabel);
            this.Controls.Add(this.LineWeigthTB);
            this.Controls.Add(this.FigureLabel);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LineWeigthTB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Label FigureLabel;
        private System.Windows.Forms.TrackBar LineWeigthTB;
        private System.Windows.Forms.Label LineWeightLabel;
        private System.Windows.Forms.Button LineColorBt;
        private System.Windows.Forms.Button FigureColorBt;
        private System.Windows.Forms.ColorDialog LineColorCD;
        private System.Windows.Forms.ColorDialog FigureColorCD;
        private System.Windows.Forms.Button UndoLastBt;
        private System.Windows.Forms.Button ClearBt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

