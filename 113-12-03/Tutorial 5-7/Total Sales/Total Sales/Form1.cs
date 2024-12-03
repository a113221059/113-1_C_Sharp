using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                //
                decimal total = 0m;
                decimal sales;
                //

                //
                StreamReader inputFine;

                //
                inputFine = File.OpenText("Sales.txt");

                //
            while(!inputFine.EndOfStream)
            {
                    //讀取一行
                    //input=inputFile.ReadLine();

                    //獎讀取的資料轉為decimal
                    if (decimal.TryParse(inputFine.ReadLine(), out sales))
                    {
                        //加總
                        totalLabel += total-sales;
                    }
                    else
                    {
                        //
                        MessageBox.Show("Invalid input");
                    }



                }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
