namespace PRL
{
    partial class f_Coffee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            lbl_Price2CO1 = new Label();
            lbl_Price1CO1 = new Label();
            pb_CO1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CO1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_Price2CO1);
            panel1.Controls.Add(lbl_Price1CO1);
            panel1.Controls.Add(pb_CO1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 196);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 164);
            label4.Name = "label4";
            label4.Size = new Size(16, 21);
            label4.TabIndex = 1;
            label4.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 132);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 3;
            label3.Text = "Cà Phê 1";
            // 
            // lbl_Price2CO1
            // 
            lbl_Price2CO1.AutoSize = true;
            lbl_Price2CO1.Location = new Point(114, 164);
            lbl_Price2CO1.Name = "lbl_Price2CO1";
            lbl_Price2CO1.Size = new Size(50, 20);
            lbl_Price2CO1.TabIndex = 2;
            lbl_Price2CO1.Text = "label1";
            // 
            // lbl_Price1CO1
            // 
            lbl_Price1CO1.AutoSize = true;
            lbl_Price1CO1.Location = new Point(25, 165);
            lbl_Price1CO1.Name = "lbl_Price1CO1";
            lbl_Price1CO1.Size = new Size(61, 20);
            lbl_Price1CO1.TabIndex = 2;
            lbl_Price1CO1.Text = "35.000đ";
            // 
            // pb_CO1
            // 
            pb_CO1.Location = new Point(45, 16);
            pb_CO1.Name = "pb_CO1";
            pb_CO1.Size = new Size(101, 101);
            pb_CO1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_CO1.TabIndex = 1;
            pb_CO1.TabStop = false;
            pb_CO1.Click += pb_CO1_Click;
            // 
            // f_Coffee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 222);
            Controls.Add(panel1);
            Name = "f_Coffee";
            Text = "f_Coffee";
            Load += f_Coffee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CO1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_Price2CO1;
        private Label lbl_Price1CO1;
        private PictureBox pb_CO1;
        private Label label3;
        private Label label4;
    }
}