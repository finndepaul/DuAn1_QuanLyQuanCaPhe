namespace PRL
{
    partial class f_Login
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
            label1 = new Label();
            label2 = new Label();
            txt_loginName = new TextBox();
            txt_Password = new TextBox();
            pb_Login = new PictureBox();
            btn_Cancel = new Button();
            btn_Login = new Button();
            Login = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_Login).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 230);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 0;
            label1.Text = "LoginName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 306);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_loginName
            // 
            txt_loginName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_loginName.Location = new Point(48, 261);
            txt_loginName.Name = "txt_loginName";
            txt_loginName.Size = new Size(400, 34);
            txt_loginName.TabIndex = 1;
            txt_loginName.KeyDown += txt_loginName_KeyDown;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(48, 337);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(400, 34);
            txt_Password.TabIndex = 2;
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.KeyDown += txt_Password_KeyDown;
            // 
            // pb_Login
            // 
            pb_Login.Image = Properties.Resources.Logo;
            pb_Login.Location = new Point(116, 12);
            pb_Login.Name = "pb_Login";
            pb_Login.Size = new Size(245, 112);
            pb_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Login.TabIndex = 4;
            pb_Login.TabStop = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.Crimson;
            btn_Cancel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(141, 469);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(200, 42);
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Turquoise;
            btn_Login.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ControlText;
            btn_Login.Location = new Point(141, 413);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(200, 42);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(86, 156);
            Login.Name = "Login";
            Login.Size = new Size(304, 36);
            Login.TabIndex = 0;
            Login.Text = "Đăng Nhập Hệ Thống";
            // 
            // f_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(497, 563);
            Controls.Add(pb_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_loginName);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Login);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(label1);
            Name = "f_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pb_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_loginName;
        private TextBox txt_Password;
        private PictureBox pb_Login;
        private Button btn_Cancel;
        private Button btn_Login;
        private Label Login;
    }
}