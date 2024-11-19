using System.Reflection.Metadata;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLengt.Text);
                double width = double.Parse(txtWidth.Text);
                double area = length * width;
                MessageBox.Show($"�Цa���n��: {area} ������", "�p�⵲�G");
            }
            catch (Exception)
            {
                MessageBox.Show("�п�J���Ī��Ʀr�I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCalculatePerimeter_Click(object sender, EventArgs e)
{
    try
    {
        double length = double.Parse(txtLength.Text);
        double width = double.Parse(txtWidth.Text);
        double perimeter = 2 * (length + width);  // �p��P��
        MessageBox.Show($"�Цa�P����: {perimeter} ���", "�p�⵲�G");
    }
    catch (Exception)
    {
        MessageBox.Show("�п�J���Ī��Ʀr�I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
