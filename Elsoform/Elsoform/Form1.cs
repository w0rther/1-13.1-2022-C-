namespace Elsoform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnszamolj_Click(object sender, EventArgs e)
        {
            lblszoveg.Text = Convert.ToString(nudszorzo.Value / nudoszto.Value);
        }

        private void btnkilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}