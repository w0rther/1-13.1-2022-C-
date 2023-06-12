namespace _18._6
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
            this.Lb_1 = new System.Windows.Forms.Label();
            this.Lb_4 = new System.Windows.Forms.Label();
            this.Lb_3 = new System.Windows.Forms.Label();
            this.Lb_2 = new System.Windows.Forms.Label();
            this.Btn_Bal = new System.Windows.Forms.Button();
            this.Btn_Jobb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_1
            // 
            this.Lb_1.Image = global::_18._6.Properties.Resources.letöltés;
            this.Lb_1.Location = new System.Drawing.Point(301, 28);
            this.Lb_1.Name = "Lb_1";
            this.Lb_1.Size = new System.Drawing.Size(153, 132);
            this.Lb_1.TabIndex = 0;
            // 
            // Lb_4
            // 
            this.Lb_4.Image = global::_18._6.Properties.Resources._114019;
            this.Lb_4.Location = new System.Drawing.Point(474, 174);
            this.Lb_4.Name = "Lb_4";
            this.Lb_4.Size = new System.Drawing.Size(153, 132);
            this.Lb_4.TabIndex = 2;
            // 
            // Lb_3
            // 
            this.Lb_3.Image = global::_18._6.Properties.Resources.artworks_NTnKi5DDnzsUrNih_ZODWOA_t500x500;
            this.Lb_3.Location = new System.Drawing.Point(301, 321);
            this.Lb_3.Name = "Lb_3";
            this.Lb_3.Size = new System.Drawing.Size(153, 132);
            this.Lb_3.TabIndex = 3;
            // 
            // Lb_2
            // 
            this.Lb_2.Image = global::_18._6.Properties.Resources.tumblr_inline_phviinIJuo1t0myks_500;
            this.Lb_2.Location = new System.Drawing.Point(127, 174);
            this.Lb_2.Name = "Lb_2";
            this.Lb_2.Size = new System.Drawing.Size(153, 132);
            this.Lb_2.TabIndex = 4;
            // 
            // Btn_Bal
            // 
            this.Btn_Bal.Location = new System.Drawing.Point(106, 71);
            this.Btn_Bal.Name = "Btn_Bal";
            this.Btn_Bal.Size = new System.Drawing.Size(75, 23);
            this.Btn_Bal.TabIndex = 5;
            this.Btn_Bal.Text = "Bal";
            this.Btn_Bal.UseVisualStyleBackColor = true;
            this.Btn_Bal.Click += new System.EventHandler(this.Btn_Bal_Click);
            // 
            // Btn_Jobb
            // 
            this.Btn_Jobb.Location = new System.Drawing.Point(583, 71);
            this.Btn_Jobb.Name = "Btn_Jobb";
            this.Btn_Jobb.Size = new System.Drawing.Size(75, 23);
            this.Btn_Jobb.TabIndex = 6;
            this.Btn_Jobb.Text = "Jobb";
            this.Btn_Jobb.UseVisualStyleBackColor = true;
            this.Btn_Jobb.Click += new System.EventHandler(this.Btn_Jobb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Jobb);
            this.Controls.Add(this.Btn_Bal);
            this.Controls.Add(this.Lb_2);
            this.Controls.Add(this.Lb_3);
            this.Controls.Add(this.Lb_4);
            this.Controls.Add(this.Lb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Lb_1;
        private Label Lb_4;
        private Label Lb_3;
        private Label Lb_2;
        private Button Btn_Bal;
        private Button Btn_Jobb;
    }
}