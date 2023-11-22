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
            btn_Home = new Button();
            btn_Logout = new Button();
            pn_Staff = new Panel();
            SuspendLayout();
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.Tan;
            btn_Home.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Home.ForeColor = SystemColors.ControlText;
            btn_Home.ImageAlign = ContentAlignment.TopCenter;
            btn_Home.Location = new Point(12, 31);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(157, 84);
            btn_Home.TabIndex = 12;
            btn_Home.Text = "Trang Chủ";
            btn_Home.TextAlign = ContentAlignment.BottomCenter;
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Anchor = AnchorStyles.Bottom;
            btn_Logout.BackColor = Color.White;
            btn_Logout.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Logout.ForeColor = SystemColors.ControlText;
            btn_Logout.ImageAlign = ContentAlignment.TopCenter;
            btn_Logout.Location = new Point(12, 959);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(157, 84);
            btn_Logout.TabIndex = 13;
            btn_Logout.Text = "Đăng Xuất";
            btn_Logout.TextAlign = ContentAlignment.BottomCenter;
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // pn_Staff
            // 
            pn_Staff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pn_Staff.Location = new Point(175, 31);
            pn_Staff.Name = "pn_Staff";
            pn_Staff.Size = new Size(1737, 1012);
            pn_Staff.TabIndex = 21;
            // 
            // f_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btn_Home);
            Controls.Add(btn_Logout);
            Controls.Add(pn_Staff);
            Name = "f_Staff";
            Text = "Staff";
            WindowState = FormWindowState.Maximized;
            Load += f_Staff_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Home;
        private Button btn_Logout;
        private Panel pn_Staff;
    }
}