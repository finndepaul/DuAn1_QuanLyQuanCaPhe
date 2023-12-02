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
			cbx_LocLoaiSP = new ComboBox();
			label3 = new Label();
			dgv_Rank = new DataGridView();
			label5 = new Label();
			btn_Loc = new Button();
			label1 = new Label();
			dtp_End = new DateTimePicker();
			label2 = new Label();
			dtp_Start = new DateTimePicker();
			dgv_DoanhThu = new DataGridView();
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
			groupBox2.Controls.Add(cbx_LocLoaiSP);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(dgv_Rank);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(btn_Loc);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(dtp_End);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(dtp_Start);
			groupBox2.Controls.Add(dgv_DoanhThu);
			groupBox2.Location = new Point(10, 167);
			groupBox2.Margin = new Padding(3, 2, 3, 2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 2, 3, 2);
			groupBox2.Size = new Size(1483, 540);
			groupBox2.TabIndex = 15;
			groupBox2.TabStop = false;
			// 
			// lbl_Total
			// 
			lbl_Total.AutoSize = true;
			lbl_Total.Location = new Point(1021, 200);
			lbl_Total.Name = "lbl_Total";
			lbl_Total.Size = new Size(38, 15);
			lbl_Total.TabIndex = 17;
			lbl_Total.Text = "label4";
			// 
			// cbx_LocLoaiSP
			// 
			cbx_LocLoaiSP.FormattingEnabled = true;
			cbx_LocLoaiSP.Location = new Point(1280, 236);
			cbx_LocLoaiSP.Margin = new Padding(3, 2, 3, 2);
			cbx_LocLoaiSP.Name = "cbx_LocLoaiSP";
			cbx_LocLoaiSP.Size = new Size(198, 23);
			cbx_LocLoaiSP.TabIndex = 16;
			cbx_LocLoaiSP.SelectedIndexChanged += cbb_locloaisp_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(942, 200);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 14;
			label3.Text = "Tổng tiền:";
			// 
			// dgv_Rank
			// 
			dgv_Rank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_Rank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Rank.Location = new Point(904, 261);
			dgv_Rank.Margin = new Padding(3, 2, 3, 2);
			dgv_Rank.Name = "dgv_Rank";
			dgv_Rank.RowHeadersWidth = 51;
			dgv_Rank.RowTemplate.Height = 29;
			dgv_Rank.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Rank.Size = new Size(574, 274);
			dgv_Rank.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(25, 17);
			label5.Name = "label5";
			label5.Size = new Size(161, 19);
			label5.TabIndex = 10;
			label5.Text = "Thống kê sản phẩm: ";
			// 
			// btn_Loc
			// 
			btn_Loc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Loc.Location = new Point(904, 127);
			btn_Loc.Margin = new Padding(3, 2, 3, 2);
			btn_Loc.Name = "btn_Loc";
			btn_Loc.Size = new Size(574, 46);
			btn_Loc.TabIndex = 12;
			btn_Loc.Text = "Lọc";
			btn_Loc.UseVisualStyleBackColor = true;
			btn_Loc.Click += btn_Loc_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(904, 52);
			label1.Name = "label1";
			label1.Size = new Size(74, 19);
			label1.TabIndex = 6;
			label1.Text = "Từ ngày:";
			// 
			// dtp_End
			// 
			dtp_End.CustomFormat = "dd/MM/yyyy";
			dtp_End.Location = new Point(1179, 88);
			dtp_End.Margin = new Padding(3, 2, 3, 2);
			dtp_End.Name = "dtp_End";
			dtp_End.Size = new Size(219, 23);
			dtp_End.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(1179, 52);
			label2.Name = "label2";
			label2.Size = new Size(82, 19);
			label2.TabIndex = 7;
			label2.Text = "Đến ngày:";
			// 
			// dtp_Start
			// 
			dtp_Start.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dtp_Start.CustomFormat = "dd/MM/yyyy";
			dtp_Start.Location = new Point(904, 88);
			dtp_Start.Margin = new Padding(3, 2, 3, 2);
			dtp_Start.Name = "dtp_Start";
			dtp_Start.Size = new Size(219, 23);
			dtp_Start.TabIndex = 4;
			dtp_Start.Value = new DateTime(2023, 11, 28, 14, 57, 5, 0);
			// 
			// dgv_DoanhThu
			// 
			dgv_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_DoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgv_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_DoanhThu.Location = new Point(25, 52);
			dgv_DoanhThu.Margin = new Padding(3, 2, 3, 2);
			dgv_DoanhThu.Name = "dgv_DoanhThu";
			dgv_DoanhThu.RowHeadersWidth = 51;
			dgv_DoanhThu.RowTemplate.Height = 29;
			dgv_DoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_DoanhThu.Size = new Size(845, 483);
			dgv_DoanhThu.TabIndex = 3;
			// 
			// btn_BayNgay
			// 
			btn_BayNgay.BackColor = Color.YellowGreen;
			btn_BayNgay.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_BayNgay.ForeColor = Color.White;
			btn_BayNgay.Location = new Point(637, 20);
			btn_BayNgay.Margin = new Padding(3, 2, 3, 2);
			btn_BayNgay.Name = "btn_BayNgay";
			btn_BayNgay.Size = new Size(209, 95);
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
			btn_TrongNgay.Location = new Point(235, 20);
			btn_TrongNgay.Margin = new Padding(3, 2, 3, 2);
			btn_TrongNgay.Name = "btn_TrongNgay";
			btn_TrongNgay.Size = new Size(209, 95);
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
			btn_MuoiBonNgay.Location = new Point(1039, 20);
			btn_MuoiBonNgay.Margin = new Padding(3, 2, 3, 2);
			btn_MuoiBonNgay.Name = "btn_MuoiBonNgay";
			btn_MuoiBonNgay.Size = new Size(209, 95);
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
			groupBox1.Location = new Point(10, 9);
			groupBox1.Margin = new Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 2, 3, 2);
			groupBox1.Size = new Size(1483, 153);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			// 
			// f_DanhThu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1504, 717);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Margin = new Padding(3, 2, 3, 2);
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
		private Label label2;
		private DateTimePicker dtp_Start;
		private DataGridView dgv_DoanhThu;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Button btn_BayNgay;
		private Button btn_TrongNgay;
		private Button btn_MuoiBonNgay;
		private GroupBox groupBox1;
		private DataGridView dgv_Rank;
		private Label label3;
		private ComboBox cbx_LocLoaiSP;
		private Label lbl_Total;
	}
}