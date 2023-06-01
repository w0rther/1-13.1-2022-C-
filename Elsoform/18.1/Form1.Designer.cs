namespace _18._1
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
            this.btnbalrafel = new System.Windows.Forms.Button();
            this.btnjobbrafel = new System.Windows.Forms.Button();
            this.btnbalrale = new System.Windows.Forms.Button();
            this.btnjobbrale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbalrafel
            // 
            this.btnbalrafel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbalrafel.Location = new System.Drawing.Point(166, 60);
            this.btnbalrafel.Name = "btnbalrafel";
            this.btnbalrafel.Size = new System.Drawing.Size(75, 23);
            this.btnbalrafel.TabIndex = 0;
            this.btnbalrafel.Text = "Balra fel";
            this.btnbalrafel.UseVisualStyleBackColor = false;
            this.btnbalrafel.Click += new System.EventHandler(this.btnbalrafel_Click);
            // 
            // btnjobbrafel
            // 
            this.btnjobbrafel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnjobbrafel.Location = new System.Drawing.Point(498, 60);
            this.btnjobbrafel.Name = "btnjobbrafel";
            this.btnjobbrafel.Size = new System.Drawing.Size(75, 23);
            this.btnjobbrafel.TabIndex = 1;
            this.btnjobbrafel.Text = "Jobbra fel";
            this.btnjobbrafel.UseVisualStyleBackColor = false;
            this.btnjobbrafel.Click += new System.EventHandler(this.btnjobbrafel_Click);
            // 
            // btnbalrale
            // 
            this.btnbalrale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbalrale.Location = new System.Drawing.Point(166, 214);
            this.btnbalrale.Name = "btnbalrale";
            this.btnbalrale.Size = new System.Drawing.Size(75, 23);
            this.btnbalrale.TabIndex = 2;
            this.btnbalrale.Text = "Balra le";
            this.btnbalrale.UseVisualStyleBackColor = false;
            this.btnbalrale.Click += new System.EventHandler(this.btnbalrale_Click);
            // 
            // btnjobbrale
            // 
            this.btnjobbrale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnjobbrale.Location = new System.Drawing.Point(498, 214);
            this.btnjobbrale.Name = "btnjobbrale";
            this.btnjobbrale.Size = new System.Drawing.Size(75, 23);
            this.btnjobbrale.TabIndex = 3;
            this.btnjobbrale.Text = "Jobbra le";
            this.btnjobbrale.UseVisualStyleBackColor = false;
            this.btnjobbrale.Click += new System.EventHandler(this.btnjobbrale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjobbrale);
            this.Controls.Add(this.btnbalrale);
            this.Controls.Add(this.btnjobbrafel);
            this.Controls.Add(this.btnbalrafel);
            this.Name = "Form1";
            this.Text = "Form ugratás";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnbalrafel;
        private Button btnjobbrafel;
        private Button btnbalrale;
        private Button btnjobbrale;
    }
}