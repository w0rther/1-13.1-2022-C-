namespace _18._5
{
    partial class Frm_Csuszka
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
            this.Lb_Negyzet = new System.Windows.Forms.Label();
            this.Sb_Piros = new System.Windows.Forms.HScrollBar();
            this.Sb_Zold = new System.Windows.Forms.HScrollBar();
            this.Sb_Kek = new System.Windows.Forms.HScrollBar();
            this.Sb_Oldal = new System.Windows.Forms.HScrollBar();
            this.Lb_Oldal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_Negyzet
            // 
            this.Lb_Negyzet.BackColor = System.Drawing.Color.Black;
            this.Lb_Negyzet.Location = new System.Drawing.Point(234, 91);
            this.Lb_Negyzet.Name = "Lb_Negyzet";
            this.Lb_Negyzet.Size = new System.Drawing.Size(222, 196);
            this.Lb_Negyzet.TabIndex = 0;
            // 
            // Sb_Piros
            // 
            this.Sb_Piros.Location = new System.Drawing.Point(183, 403);
            this.Sb_Piros.Maximum = 255;
            this.Sb_Piros.Name = "Sb_Piros";
            this.Sb_Piros.Size = new System.Drawing.Size(378, 22);
            this.Sb_Piros.TabIndex = 1;
            this.Sb_Piros.ValueChanged += new System.EventHandler(this.Sb_Piros_ValueChanged);
            // 
            // Sb_Zold
            // 
            this.Sb_Zold.Location = new System.Drawing.Point(183, 449);
            this.Sb_Zold.Maximum = 255;
            this.Sb_Zold.Name = "Sb_Zold";
            this.Sb_Zold.Size = new System.Drawing.Size(378, 22);
            this.Sb_Zold.TabIndex = 2;
            this.Sb_Zold.ValueChanged += new System.EventHandler(this.Sb_Zold_ValueChanged);
            // 
            // Sb_Kek
            // 
            this.Sb_Kek.Location = new System.Drawing.Point(183, 502);
            this.Sb_Kek.Maximum = 255;
            this.Sb_Kek.Name = "Sb_Kek";
            this.Sb_Kek.Size = new System.Drawing.Size(378, 22);
            this.Sb_Kek.TabIndex = 3;
            this.Sb_Kek.ValueChanged += new System.EventHandler(this.Sb_Kek_ValueChanged);
            // 
            // Sb_Oldal
            // 
            this.Sb_Oldal.Location = new System.Drawing.Point(183, 58);
            this.Sb_Oldal.Maximum = 300;
            this.Sb_Oldal.Name = "Sb_Oldal";
            this.Sb_Oldal.Size = new System.Drawing.Size(378, 22);
            this.Sb_Oldal.TabIndex = 4;
            this.Sb_Oldal.ValueChanged += new System.EventHandler(this.Sb_Oldal_ValueChanged);
            // 
            // Lb_Oldal
            // 
            this.Lb_Oldal.AutoSize = true;
            this.Lb_Oldal.Location = new System.Drawing.Point(455, 23);
            this.Lb_Oldal.Name = "Lb_Oldal";
            this.Lb_Oldal.Size = new System.Drawing.Size(13, 15);
            this.Lb_Oldal.TabIndex = 5;
            this.Lb_Oldal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "A négyzet oldala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(104, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Piros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(104, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kék:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(106, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zöld:";
            // 
            // Frm_Csuszka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 575);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Oldal);
            this.Controls.Add(this.Sb_Oldal);
            this.Controls.Add(this.Sb_Kek);
            this.Controls.Add(this.Sb_Zold);
            this.Controls.Add(this.Sb_Piros);
            this.Controls.Add(this.Lb_Negyzet);
            this.Name = "Frm_Csuszka";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Csuszka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lb_Negyzet;
        private HScrollBar Sb_Piros;
        private HScrollBar Sb_Zold;
        private HScrollBar Sb_Kek;
        private HScrollBar Sb_Oldal;
        private Label Lb_Oldal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}