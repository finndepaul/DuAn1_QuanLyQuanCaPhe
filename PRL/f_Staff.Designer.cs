namespace PRL
{
    partial class f_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Staff));
            btn_Home = new Button();
            button10 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btn_Home
            // 
            btn_Home.BackColor = SystemColors.ButtonHighlight;
            btn_Home.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Home.Image = (Image)resources.GetObject("btn_Home.Image");
            btn_Home.ImageAlign = ContentAlignment.TopCenter;
            btn_Home.Location = new Point(12, 31);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(157, 84);
            btn_Home.TabIndex = 12;
            btn_Home.Text = "Trang Chủ";
            btn_Home.TextAlign = ContentAlignment.BottomCenter;
            btn_Home.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button10.BackColor = Color.White;
            button10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlText;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(12, 955);
            button10.Name = "button10";
            button10.Size = new Size(157, 68);
            button10.TabIndex = 13;
            button10.Text = "Đăng Xuất";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(12, 121);
            button4.Name = "button4";
            button4.Size = new Size(157, 68);
            button4.TabIndex = 15;
            button4.Text = "Thực Đơn";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(175, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1737, 992);
            panel1.TabIndex = 21;
            // 
            // f_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btn_Home);
            Controls.Add(button10);
            Controls.Add(button4);
            Controls.Add(panel1);
            Name = "f_Staff";
            Text = "f_Staff";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Home;
        private Button button10;
        private Button button4;
        private Panel panel1;
    }
}