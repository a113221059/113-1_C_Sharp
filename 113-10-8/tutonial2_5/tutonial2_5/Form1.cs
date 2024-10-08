namespace tutonial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;
            ptxBack.Visible = false;
        }

        private void ptxFrom_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxBack.Visible = true;
        }

        private void btuShowBack_Click(object sender, EventArgs e)
        {

        }

        private void btuShowFrom_Click(object sender, EventArgs e)
        {

        }
    }
}
