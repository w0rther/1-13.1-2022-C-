namespace _18._3
{
    public partial class PanelIgazit2 : Form
    {
        public PanelIgazit2()
        {
            InitializeComponent();
        }

        private void Frm_Holmozog_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("Az egér koordináta X: {0}, Y: {1}", e.X, e.Y);
        }

        private void Frm_Holmozog_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Frm_Holmozog(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Frm_Holmozog_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void PanelIgazit();

        }

}