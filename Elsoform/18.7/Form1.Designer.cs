namespace _18._7
{
    partial class Frm_Dinamikus
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
            this.lb_Eredmeny = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Eredmeny
            // 
            this.lb_Eredmeny.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_Eredmeny.Location = new System.Drawing.Point(0, 56);
            this.lb_Eredmeny.Name = "lb_Eredmeny";
            this.lb_Eredmeny.Size = new System.Drawing.Size(801, 23);
            this.lb_Eredmeny.TabIndex = 0;
            this.lb_Eredmeny.Text = "Darabszám: 0, összeg: 0, átlag: 0, minimum:0,maximum:0";
            this.lb_Eredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kattins a form üres területén! Létrejön egy új címke, rajta egy 1 és 100 közötti " +
    "szám.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Dinamikus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Eredmeny);
            this.Name = "Frm_Dinamikus";
            this.Text = "Komponens";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frm_Dinamikus_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lb_Eredmeny;
        private Label label1;
    }
}