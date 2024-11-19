namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using System;
            using System.Windows.Forms;

namespace FenceCostCalculator
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    // 取得使用者輸入的數據
                    double length = double.Parse(txtLength.Text);
                    double width = double.Parse(txtWidth.Text);
                    double unitCost = double.Parse(txtUnitCost.Text);

                    // 計算周長與總成本
                    double perimeter = 2 * (length + width);
                    double totalCost = perimeter * unitCost;

                    // 顯示結果
                    lblResult.Text = $"總成本：{totalCost:F2} 單位貨幣";
                }
                catch (Exception)
                {
                    // 顯示錯誤訊息
                    MessageBox.Show("請輸入有效的數字！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
    }
}
