namespace tutonial2_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptxBack = new PictureBox();
            ptxFrom = new PictureBox();
            btuShowBack = new Button();
            btuShowFrom = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFrom).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(209, 117);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(141, 191);
            ptxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            ptxBack.Click += pictureBox1_Click;
            // 
            // ptxFrom
            // 
            ptxFrom.Image = Properties.Resources.Ace_Spades;
            ptxFrom.Location = new Point(399, 117);
            ptxFrom.Name = "ptxFrom";
            ptxFrom.Size = new Size(146, 191);
            ptxFrom.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxFrom.TabIndex = 1;
            ptxFrom.TabStop = false;
            ptxFrom.Visible = false;
            ptxFrom.Click += ptxFrom_Click;
            // 
            // btuShowBack
            // 
            btuShowBack.Location = new Point(245, 323);
            btuShowBack.Name = "btuShowBack";
            btuShowBack.Size = new Size(92, 44);
            btuShowBack.TabIndex = 2;
            btuShowBack.Text = "背面";
            btuShowBack.UseVisualStyleBackColor = true;
            btuShowBack.Visible = false;
            btuShowBack.Click += btuShowBack_Click;
            // 
            // btuShowFrom
            // 
            btuShowFrom.Location = new Point(421, 323);
            btuShowFrom.Name = "btuShowFrom";
            btuShowFrom.Size = new Size(97, 44);
            btuShowFrom.TabIndex = 3;
            btuShowFrom.Text = "正面";
            btuShowFrom.UseVisualStyleBackColor = true;
            btuShowFrom.Visible = false;
            btuShowFrom.Click += btuShowFrom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btuShowFrom);
            Controls.Add(btuShowBack);
            Controls.Add(ptxFrom);
            Controls.Add(ptxBack);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFrom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxFrom;
        private Button btuShowBack;
        private Button btuShowFrom;
    }
}
