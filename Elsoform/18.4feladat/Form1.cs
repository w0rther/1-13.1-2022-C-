namespace _18._4feladat
{
    public partial class Form1 : Form
    {
        int meretezo = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_M_Cs_Click(object sender, EventArgs e)
        {
            Width -= meretezo;
            Height -= meretezo;
        }

        private void Bt_M_N_Click(object sender, EventArgs e)
        {
            Width += meretezo;
            Height += meretezo;
        }

        private void Bt_Atl_No_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.1;
        }

        private void Bt_Atl_Cs_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.1)
                Opacity -= 0.1;
        }

        private void Bt_Kozep_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Bt_Le.Visible = Bt_Le_T.Visible = 
            Bt_Fel.Visible = Bt_Fel_T.Visible =
            Bt_Bal.Visible = Bt_Bal_T.Visible = 
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;
            
        }
        private void Bt_Fel_T_Click(object sender, EventArgs e)
        {
            Top = 0;
            Bt_Fel.Visible = Bt_Fel_T.Visible = false;
            Bt_Le.Visible = Bt_Le_T.Visible = true;
        }
        private void Bt_Fel_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0)
            {
                Top -= meretezo;
            }
            else
            {
                Top = 0;
                Bt_Fel.Visible = Bt_Fel_T.Visible = false;
            }
            Bt_Le.Visible = Bt_Le_T.Visible = true;

        }

        private void Bt_Le_T_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Bt_Fel.Visible = Bt_Fel_T.Visible = true;
            Bt_Le.Visible = Bt_Le_T.Visible = false;
        }
    }
}