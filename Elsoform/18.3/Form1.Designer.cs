namespace _18._3
{
    partial class PanelIgazit2
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
            this.PanelIgazit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelIgazit
            // 
            this.PanelIgazit.BackColor = System.Drawing.Color.Lime;
            this.PanelIgazit.Location = new System.Drawing.Point(280, 161);
            this.PanelIgazit.Name = "PanelIgazit";
            this.PanelIgazit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelIgazit.Size = new System.Drawing.Size(200, 100);
            this.PanelIgazit.TabIndex = 0;
            this.PanelIgazit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Holmozog_MouseMove);
            this.PanelIgazit.Resize += new System.EventHandler(this.Frm_Holmozog_Resize);
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelIgazit);
            this.Name = "Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelIgazit;
    }
}