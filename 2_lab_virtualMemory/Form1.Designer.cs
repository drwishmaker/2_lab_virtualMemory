namespace _2_lab_virtualMemory
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
            this.textBoxFifo = new System.Windows.Forms.TextBox();
            this.textBoxLru = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.frameCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxDefault = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFifo
            // 
            this.textBoxFifo.Location = new System.Drawing.Point(12, 28);
            this.textBoxFifo.Multiline = true;
            this.textBoxFifo.Name = "textBoxFifo";
            this.textBoxFifo.ReadOnly = true;
            this.textBoxFifo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFifo.Size = new System.Drawing.Size(271, 230);
            this.textBoxFifo.TabIndex = 0;
            // 
            // textBoxLru
            // 
            this.textBoxLru.Location = new System.Drawing.Point(289, 28);
            this.textBoxLru.Multiline = true;
            this.textBoxLru.Name = "textBoxLru";
            this.textBoxLru.ReadOnly = true;
            this.textBoxLru.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLru.Size = new System.Drawing.Size(275, 230);
            this.textBoxLru.TabIndex = 1;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(138, 409);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 20);
            this.buttonFile.TabIndex = 2;
            this.buttonFile.Text = "Choose file";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // frameCount
            // 
            this.frameCount.Location = new System.Drawing.Point(12, 409);
            this.frameCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.frameCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameCount.Name = "frameCount";
            this.frameCount.Size = new System.Drawing.Size(120, 20);
            this.frameCount.TabIndex = 3;
            this.frameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxDefault
            // 
            this.textBoxDefault.Location = new System.Drawing.Point(12, 277);
            this.textBoxDefault.Multiline = true;
            this.textBoxDefault.Name = "textBoxDefault";
            this.textBoxDefault.ReadOnly = true;
            this.textBoxDefault.Size = new System.Drawing.Size(551, 107);
            this.textBoxDefault.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FIFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LRU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Frame";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDefault);
            this.Controls.Add(this.frameCount);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxLru);
            this.Controls.Add(this.textBoxFifo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFifo;
        private System.Windows.Forms.TextBox textBoxLru;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.NumericUpDown frameCount;
        private System.Windows.Forms.TextBox textBoxDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

