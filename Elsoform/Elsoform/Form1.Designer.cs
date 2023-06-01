namespace Elsoform
{
    partial class Form1
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
            this.lblszoveg = new System.Windows.Forms.Label();
            this.btnszamolj = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.nudszorzo = new System.Windows.Forms.NumericUpDown();
            this.nudoszto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudszorzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudoszto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblszoveg
            // 
            this.lblszoveg.BackColor = System.Drawing.Color.LawnGreen;
            this.lblszoveg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblszoveg.Location = new System.Drawing.Point(276, 181);
            this.lblszoveg.Name = "lblszoveg";
            this.lblszoveg.Size = new System.Drawing.Size(235, 22);
            this.lblszoveg.TabIndex = 0;
            this.lblszoveg.Text = "Helló world";
            this.lblszoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnszamolj
            // 
            this.btnszamolj.Location = new System.Drawing.Point(276, 221);
            this.btnszamolj.Name = "btnszamolj";
            this.btnszamolj.Size = new System.Drawing.Size(75, 23);
            this.btnszamolj.TabIndex = 1;
            this.btnszamolj.Text = "Számolj!";
            this.btnszamolj.UseVisualStyleBackColor = true;
            this.btnszamolj.Click += new System.EventHandler(this.btnszamolj_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(436, 221);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(75, 23);
            this.btnkilep.TabIndex = 2;
            this.btnkilep.Text = "Kilép";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.btnkilep_Click);
            // 
            // nudszorzo
            // 
            this.nudszorzo.Location = new System.Drawing.Point(231, 127);
            this.nudszorzo.Name = "nudszorzo";
            this.nudszorzo.Size = new System.Drawing.Size(120, 23);
            this.nudszorzo.TabIndex = 3;
            // 
            // nudoszto
            // 
            this.nudoszto.Location = new System.Drawing.Point(436, 127);
            this.nudoszto.Name = "nudoszto";
            this.nudoszto.Size = new System.Drawing.Size(120, 23);
            this.nudoszto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(267, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szorzó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(482, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Osztó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudoszto);
            this.Controls.Add(this.nudszorzo);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnszamolj);
            this.Controls.Add(this.lblszoveg);
            this.Name = "Form1";
            this.Text = "Első programunk";
            ((System.ComponentModel.ISupportInitialize)(this.nudszorzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudoszto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblszoveg;
        private Button btnszamolj;
        private Button btnkilep;
        private NumericUpDown nudszorzo;
        private NumericUpDown nudoszto;
        private Label label1;
        private Label label2;
    }
}