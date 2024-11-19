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
                    // ���o�ϥΪ̿�J���ƾ�
                    double length = double.Parse(txtLength.Text);
                    double width = double.Parse(txtWidth.Text);
                    double unitCost = double.Parse(txtUnitCost.Text);

                    // �p��P���P�`����
                    double perimeter = 2 * (length + width);
                    double totalCost = perimeter * unitCost;

                    // ��ܵ��G
                    lblResult.Text = $"�`�����G{totalCost:F2} ���f��";
                }
                catch (Exception)
                {
                    // ��ܿ��~�T��
                    MessageBox.Show("�п�J���Ī��Ʀr�I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
    }
}
