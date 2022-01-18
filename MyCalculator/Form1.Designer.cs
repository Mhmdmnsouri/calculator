namespace MyCalculator
{
    partial class Frm1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Numric1 = new System.Windows.Forms.NumericUpDown();
            this.Numric2 = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMultiple = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numric2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(43, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "First number :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 66);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 19);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Second number :";
            // 
            // Numric1
            // 
            this.Numric1.Location = new System.Drawing.Point(150, 19);
            this.Numric1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Numric1.Name = "Numric1";
            this.Numric1.Size = new System.Drawing.Size(299, 25);
            this.Numric1.TabIndex = 2;
            // 
            // Numric2
            // 
            this.Numric2.Location = new System.Drawing.Point(150, 64);
            this.Numric2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Numric2.Name = "Numric2";
            this.Numric2.Size = new System.Drawing.Size(299, 25);
            this.Numric2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(147, 106);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(71, 33);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(224, 106);
            this.BtnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(71, 33);
            this.BtnMinus.TabIndex = 5;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMultiple
            // 
            this.BtnMultiple.Location = new System.Drawing.Point(301, 106);
            this.BtnMultiple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMultiple.Name = "BtnMultiple";
            this.BtnMultiple.Size = new System.Drawing.Size(71, 33);
            this.BtnMultiple.TabIndex = 6;
            this.BtnMultiple.Text = "*";
            this.BtnMultiple.UseVisualStyleBackColor = true;
            this.BtnMultiple.Click += new System.EventHandler(this.BtnMultiple_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(378, 106);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(71, 33);
            this.BtnDivide.TabIndex = 7;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 165);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiple);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.Numric2);
            this.Controls.Add(this.Numric1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.Numric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown Numric1;
        private System.Windows.Forms.NumericUpDown Numric2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMultiple;
        private System.Windows.Forms.Button BtnDivide;
    }
}

