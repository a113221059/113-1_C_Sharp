﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal INTERSTATE { get; private set; }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTERSTRATE = 0.005m;
            decimal balance;//餘額
            int months;//月份

            if(decimal.TryParse(startingBalTextBox.Text,out balance))
            {
                 if(int .TryParse(monthsTextBox.Text,out months))
                {
                    int count = 1;//
                    while(count<=months)
                    {
                        //計算餘額
                        balance = balance + (INTERSTATE * balance);
                        count += 1;
                    }
                    //顯示結果
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                 else
                {
                    //顯示錯誤訊息
                    MessageBox.Show("輸入{月份數量}資料格式錯誤");
                        }
            }
            else
            {
                //顯示錯誤訊息
                MessageBox.Show("輸入{起始餘額]資料錯誤");
            }

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void monthsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
