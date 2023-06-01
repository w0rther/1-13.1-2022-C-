namespace _18._3
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void Frm_Holmozog_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("Az egér koordináta X: {0}, Y: {1}", e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}