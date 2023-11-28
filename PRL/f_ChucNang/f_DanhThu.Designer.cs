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
            textBox1 = new TextBox();
            label5 = new Label();
            btn_Loc = new Button();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            cbx_LoaiSanPham = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_BayNgay = new Button();
            btn_TrongNgay = new Button();
            btn_MuoiBonNgay = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btn_Loc);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(cbx_LoaiSanPham);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1695, 720);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1299, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 27);
            textBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 23);
            label5.Name = "label5";
            label5.Size = new Size(199, 24);
            label5.TabIndex = 10;
            label5.Text = "Thống kê sản phẩm: ";
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
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Location = new Point(1439, 117);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // cbx_LoaiSanPham
            // 
            cbx_LoaiSanPham.FormattingEnabled = true;
            cbx_LoaiSanPham.Items.AddRange(new object[] { "Đồ uống", "Đồ ăn" });
            cbx_LoaiSanPham.Location = new Point(1439, 385);
            cbx_LoaiSanPham.Name = "cbx_LoaiSanPham";
            cbx_LoaiSanPham.Size = new Size(250, 28);
            cbx_LoaiSanPham.TabIndex = 11;
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
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(1044, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(966, 644);
            dataGridView1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1187, 272);
            label4.Name = "label4";
            label4.Size = new Size(107, 24);
            label4.TabIndex = 8;
            label4.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1286, 385);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1044, 419);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(645, 285);
            dataGridView2.TabIndex = 14;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label5;
        private Button btn_Loc;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private ComboBox cbx_LoaiSanPham;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_BayNgay;
        private Button btn_TrongNgay;
        private Button btn_MuoiBonNgay;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label4;
        private DataGridView dataGridView2;
    }
}