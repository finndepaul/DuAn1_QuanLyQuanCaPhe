namespace PRL.f_ChucNang
{
    partial class f_DanhThu
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
            groupBox2 = new GroupBox();
            lbl_Total = new Label();
            dgv_Rank = new DataGridView();
            label5 = new Label();
            btn_Loc = new Button();
            label1 = new Label();
            dtp_End = new DateTimePicker();
            cbx_LocLoaiSP = new ComboBox();
            label2 = new Label();
            dtp_Start = new DateTimePicker();
            dgv_DoanhThu = new DataGridView();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_BayNgay = new Button();
            btn_TrongNgay = new Button();
            btn_MuoiBonNgay = new Button();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Rank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DoanhThu).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(lbl_Total);
            groupBox2.Controls.Add(dgv_Rank);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btn_Loc);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dtp_End);
            groupBox2.Controls.Add(cbx_LocLoaiSP);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtp_Start);
            groupBox2.Controls.Add(dgv_DoanhThu);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1695, 720);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.Location = new Point(1196, 288);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(87, 34);
            lbl_Total.TabIndex = 15;
            lbl_Total.Text = "label7";
            lbl_Total.Visible = false;
            // 
            // dgv_Rank
            // 
            dgv_Rank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Rank.Location = new Point(1054, 397);
            dgv_Rank.Name = "dgv_Rank";
            dgv_Rank.RowHeadersWidth = 51;
            dgv_Rank.RowTemplate.Height = 29;
            dgv_Rank.Size = new Size(635, 317);
            dgv_Rank.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 23);
            label5.Name = "label5";
            label5.Size = new Size(212, 24);
            label5.TabIndex = 10;
            label5.Text = "Thống Kê Doanh Thu: ";
            // 
            // btn_Loc
            // 
            btn_Loc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Loc.Location = new Point(1044, 180);
            btn_Loc.Name = "btn_Loc";
            btn_Loc.Size = new Size(645, 57);
            btn_Loc.TabIndex = 12;
            btn_Loc.Text = "Lọc";
            btn_Loc.UseVisualStyleBackColor = true;
            btn_Loc.Click += btn_Loc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1044, 70);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 6;
            label1.Text = "Từ ngày:";
            // 
            // dtp_End
            // 
            dtp_End.CustomFormat = "dd/MM/yyyy";
            dtp_End.Location = new Point(1439, 117);
            dtp_End.Name = "dtp_End";
            dtp_End.Size = new Size(250, 27);
            dtp_End.TabIndex = 5;
            // 
            // cbx_LocLoaiSP
            // 
            cbx_LocLoaiSP.FormattingEnabled = true;
            cbx_LocLoaiSP.Items.AddRange(new object[] { "Đồ uống", "Đồ ăn" });
            cbx_LocLoaiSP.Location = new Point(1449, 363);
            cbx_LocLoaiSP.Name = "cbx_LocLoaiSP";
            cbx_LocLoaiSP.Size = new Size(240, 28);
            cbx_LocLoaiSP.TabIndex = 11;
            cbx_LocLoaiSP.SelectedIndexChanged += cbx_LocLoaiSP_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1439, 70);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 7;
            label2.Text = "Đến ngày:";
            // 
            // dtp_Start
            // 
            dtp_Start.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Start.CustomFormat = "dd/MM/yyyy";
            dtp_Start.Location = new Point(1044, 117);
            dtp_Start.Name = "dtp_Start";
            dtp_Start.Size = new Size(262, 27);
            dtp_Start.TabIndex = 4;
            // 
            // dgv_DoanhThu
            // 
            dgv_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DoanhThu.Location = new Point(29, 70);
            dgv_DoanhThu.Name = "dgv_DoanhThu";
            dgv_DoanhThu.RowHeadersWidth = 51;
            dgv_DoanhThu.RowTemplate.Height = 29;
            dgv_DoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DoanhThu.Size = new Size(966, 644);
            dgv_DoanhThu.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1044, 288);
            label4.Name = "label4";
            label4.Size = new Size(149, 34);
            label4.TabIndex = 8;
            label4.Text = "Tổng Tiền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1054, 367);
            label6.Name = "label6";
            label6.Size = new Size(139, 24);
            label6.TabIndex = 8;
            label6.Text = "Top Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1296, 363);
            label3.Name = "label3";
            label3.Size = new Size(147, 24);
            label3.TabIndex = 8;
            label3.Text = "Loại sản phẩm:";
            // 
            // btn_BayNgay
            // 
            btn_BayNgay.BackColor = Color.YellowGreen;
            btn_BayNgay.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BayNgay.ForeColor = Color.White;
            btn_BayNgay.Location = new Point(728, 26);
            btn_BayNgay.Name = "btn_BayNgay";
            btn_BayNgay.Size = new Size(239, 127);
            btn_BayNgay.TabIndex = 1;
            btn_BayNgay.Text = "7 Ngày";
            btn_BayNgay.UseVisualStyleBackColor = false;
            btn_BayNgay.Click += btn_BayNgay_Click;
            // 
            // btn_TrongNgay
            // 
            btn_TrongNgay.BackColor = Color.YellowGreen;
            btn_TrongNgay.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TrongNgay.ForeColor = Color.White;
            btn_TrongNgay.Location = new Point(269, 26);
            btn_TrongNgay.Name = "btn_TrongNgay";
            btn_TrongNgay.Size = new Size(239, 127);
            btn_TrongNgay.TabIndex = 0;
            btn_TrongNgay.Text = "Trong ngày";
            btn_TrongNgay.UseVisualStyleBackColor = false;
            btn_TrongNgay.Click += btn_TrongNgay_Click;
            // 
            // btn_MuoiBonNgay
            // 
            btn_MuoiBonNgay.BackColor = Color.YellowGreen;
            btn_MuoiBonNgay.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MuoiBonNgay.ForeColor = Color.White;
            btn_MuoiBonNgay.Location = new Point(1187, 26);
            btn_MuoiBonNgay.Name = "btn_MuoiBonNgay";
            btn_MuoiBonNgay.Size = new Size(239, 127);
            btn_MuoiBonNgay.TabIndex = 2;
            btn_MuoiBonNgay.Text = "14 Ngày";
            btn_MuoiBonNgay.UseVisualStyleBackColor = false;
            btn_MuoiBonNgay.Click += btn_MuoiBonNgay_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btn_BayNgay);
            groupBox1.Controls.Add(btn_TrongNgay);
            groupBox1.Controls.Add(btn_MuoiBonNgay);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1695, 204);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // f_DanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 956);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "f_DanhThu";
            Text = "Doanh Thu";
            WindowState = FormWindowState.Maximized;
            Load += f_DanhThu_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Rank).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DoanhThu).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label5;
        private Button btn_Loc;
        private Label label1;
        private DateTimePicker dtp_End;
        private ComboBox cbx_LocLoaiSP;
        private Label label2;
        private DateTimePicker dtp_Start;
        private DataGridView dgv_DoanhThu;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_BayNgay;
        private Button btn_TrongNgay;
        private Button btn_MuoiBonNgay;
        private GroupBox groupBox1;
        private Label label4;
        private DataGridView dgv_Rank;
        private Label label6;
        private Label lbl_Total;
    }
}