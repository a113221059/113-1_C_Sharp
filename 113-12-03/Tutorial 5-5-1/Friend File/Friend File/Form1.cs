﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            // 這裡是寫入名字的按鈕點擊事件處理程式
            try
            {
                StreamWriter outputFile;//S
                if(SaveFile.ShowDialog()==DialogResult.OK)
                    outputFile=File
                    o
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
