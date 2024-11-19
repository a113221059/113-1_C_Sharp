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
                MessageBox.Show($"田地面積為: {area} 平方單位", "計算結果");
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效的數字！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCalculatePerimeter_Click(object sender, EventArgs e)
{
    try
    {
        double length = double.Parse(txtLength.Text);
        double width = double.Parse(txtWidth.Text);
        double perimeter = 2 * (length + width);  // 計算周長
        MessageBox.Show($"田地周長為: {perimeter} 單位", "計算結果");
    }
    catch (Exception)
    {
        MessageBox.Show("請輸入有效的數字！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
