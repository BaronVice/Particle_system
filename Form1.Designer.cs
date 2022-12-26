
namespace Particle_system
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.picDisplayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьЗдесьКольцоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gravX = new System.Windows.Forms.NumericUpDown();
            this.gravY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.circleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.circleRadius = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.picDisplayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.ContextMenuStrip = this.picDisplayContextMenu;
            this.picDisplay.Location = new System.Drawing.Point(8, 55);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(682, 435);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.DoubleClick += new System.EventHandler(this.picDisplay_DoubleClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // picDisplayContextMenu
            // 
            this.picDisplayContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.picDisplayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗдесьКольцоToolStripMenuItem});
            this.picDisplayContextMenu.Name = "picDisplayContextMenu";
            this.picDisplayContextMenu.Size = new System.Drawing.Size(193, 26);
            this.picDisplayContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.picDisplayContextMenu_Opening);
            // 
            // создатьЗдесьКольцоToolStripMenuItem
            // 
            this.создатьЗдесьКольцоToolStripMenuItem.Name = "создатьЗдесьКольцоToolStripMenuItem";
            this.создатьЗдесьКольцоToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.создатьЗдесьКольцоToolStripMenuItem.Text = "Создать здесь кольцо";
            this.создатьЗдесьКольцоToolStripMenuItem.Click += new System.EventHandler(this.создатьЗдесьКольцоToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 40;
            this.timer2.Tag = "timer2";
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество частиц:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(232, 12);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(100, 36);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(356, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поменять цвета колец";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(390, 505);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Гравитация по X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(391, 554);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Гравитация по Y:";
            // 
            // gravX
            // 
            this.gravX.DecimalPlaces = 1;
            this.gravX.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gravX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravX.Location = new System.Drawing.Point(590, 503);
            this.gravX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gravX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gravX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.gravX.Name = "gravX";
            this.gravX.ReadOnly = true;
            this.gravX.Size = new System.Drawing.Size(100, 36);
            this.gravX.TabIndex = 6;
            this.gravX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gravX.ValueChanged += new System.EventHandler(this.gravX_ValueChanged);
            // 
            // gravY
            // 
            this.gravY.DecimalPlaces = 1;
            this.gravY.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gravY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravY.Location = new System.Drawing.Point(590, 552);
            this.gravY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gravY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gravY.Name = "gravY";
            this.gravY.ReadOnly = true;
            this.gravY.Size = new System.Drawing.Size(100, 36);
            this.gravY.TabIndex = 7;
            this.gravY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gravY.ValueChanged += new System.EventHandler(this.gravY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя:";
            // 
            // circleName
            // 
            this.circleName.Enabled = false;
            this.circleName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.circleName.Location = new System.Drawing.Point(82, 505);
            this.circleName.MaxLength = 14;
            this.circleName.Name = "circleName";
            this.circleName.Size = new System.Drawing.Size(223, 36);
            this.circleName.TabIndex = 9;
            this.circleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.circleName.TextChanged += new System.EventHandler(this.circleName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 552);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Радиус:";
            // 
            // circleRadius
            // 
            this.circleRadius.Enabled = false;
            this.circleRadius.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.circleRadius.Location = new System.Drawing.Point(110, 552);
            this.circleRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circleRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.ReadOnly = true;
            this.circleRadius.Size = new System.Drawing.Size(195, 36);
            this.circleRadius.TabIndex = 11;
            this.circleRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.circleRadius.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.circleRadius.ValueChanged += new System.EventHandler(this.circleRadius_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 598);
            this.Controls.Add(this.circleRadius);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.circleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gravY);
            this.Controls.Add(this.gravX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(718, 981);
            this.MinimumSize = new System.Drawing.Size(711, 442);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.picDisplayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown gravX;
        private System.Windows.Forms.NumericUpDown gravY;
        private System.Windows.Forms.ContextMenuStrip picDisplayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem создатьЗдесьКольцоToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox circleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown circleRadius;
    }
}

