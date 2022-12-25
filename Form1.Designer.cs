
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gravX = new System.Windows.Forms.NumericUpDown();
            this.gravY = new System.Windows.Forms.NumericUpDown();
            this.picDisplayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьЗдесьКольцоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravY)).BeginInit();
            this.picDisplayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.ContextMenuStrip = this.picDisplayContextMenu;
            this.picDisplay.Location = new System.Drawing.Point(12, 85);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1023, 669);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
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
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество частиц:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(348, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(150, 50);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(534, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(501, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поменять цвета колец";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 786);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Гравитация по X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(592, 786);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 45);
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
            this.gravX.Location = new System.Drawing.Point(307, 781);
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
            this.gravX.Size = new System.Drawing.Size(150, 50);
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
            this.gravY.Location = new System.Drawing.Point(885, 782);
            this.gravY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gravY.Name = "gravY";
            this.gravY.ReadOnly = true;
            this.gravY.Size = new System.Drawing.Size(150, 50);
            this.gravY.TabIndex = 7;
            this.gravY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gravY.ValueChanged += new System.EventHandler(this.gravY_ValueChanged);
            // 
            // picDisplayContextMenu
            // 
            this.picDisplayContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.picDisplayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗдесьКольцоToolStripMenuItem});
            this.picDisplayContextMenu.Name = "picDisplayContextMenu";
            this.picDisplayContextMenu.Size = new System.Drawing.Size(264, 36);
            this.picDisplayContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.picDisplayContextMenu_Opening);
            // 
            // создатьЗдесьКольцоToolStripMenuItem
            // 
            this.создатьЗдесьКольцоToolStripMenuItem.Name = "создатьЗдесьКольцоToolStripMenuItem";
            this.создатьЗдесьКольцоToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.создатьЗдесьКольцоToolStripMenuItem.Text = "Создать здесь кольцо";
            this.создатьЗдесьКольцоToolStripMenuItem.Click += new System.EventHandler(this.создатьЗдесьКольцоToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1053, 912);
            this.Controls.Add(this.gravY);
            this.Controls.Add(this.gravX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDisplay);
            this.MaximumSize = new System.Drawing.Size(1075, 1506);
            this.MinimumSize = new System.Drawing.Size(1075, 968);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravY)).EndInit();
            this.picDisplayContextMenu.ResumeLayout(false);
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
    }
}

