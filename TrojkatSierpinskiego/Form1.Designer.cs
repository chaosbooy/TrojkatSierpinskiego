﻿namespace TrojkatSierpinskiego
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SufferSize = new System.Windows.Forms.NumericUpDown();
            this.Generate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SufferSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SufferSize
            // 
            this.SufferSize.BackColor = System.Drawing.SystemColors.Window;
            this.SufferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SufferSize.Location = new System.Drawing.Point(109, 12);
            this.SufferSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SufferSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SufferSize.Name = "SufferSize";
            this.SufferSize.Size = new System.Drawing.Size(120, 38);
            this.SufferSize.TabIndex = 1;
            this.SufferSize.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(235, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(161, 38);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate suffering";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Suffer);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(402, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(49, 38);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.numericUpDown1.Location = new System.Drawing.Point(32, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 38);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Triangle Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Layers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.SufferSize);
            this.Name = "Form1";
            this.Text = "Trójkąt Cierpi - ńskiego";
            ((System.ComponentModel.ISupportInitialize)(this.SufferSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SufferSize;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

