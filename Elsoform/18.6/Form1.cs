namespace _18._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Bal_Click(object sender, EventArgs e)
        {
            Image s = Lb_4.Image;
            Lb_4.Image = Lb_3.Image;
            Lb_3.Image = Lb_2.Image;
            Lb_2.Image = Lb_1.Image;
            Lb_1.Image = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Jobb_Click(object sender, EventArgs e)
        {
            Image s = Lb_1.Image;
            Lb_1.Image = Lb_2.Image;
            Lb_2.Image = Lb_3.Image;
            Lb_3.Image = Lb_4.Image;
            Lb_4.Image = s;
        }
    }
}