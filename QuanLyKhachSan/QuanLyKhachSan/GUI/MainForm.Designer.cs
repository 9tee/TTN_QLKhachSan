namespace QuanLyKhachSan.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMainForm = new System.Windows.Forms.DataGridView();
            this.addKHBt = new System.Windows.Forms.Button();
            this.checkInBt = new System.Windows.Forms.Button();
            this.checkOutBt = new System.Windows.Forms.Button();
            this.datTruocBt = new System.Windows.Forms.Button();
            this.lichSuBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timKiemTb = new System.Windows.Forms.TextBox();
            this.timBt = new System.Windows.Forms.Button();
            this.comboBox_LoaiThongTin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNN_QLKSDataSet = new QuanLyKhachSan.TNN_QLKSDataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QuanLyKhachSan.TNN_QLKSDataSetTableAdapters.KhachHangTableAdapter();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNN_QLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMainForm);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 474);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewMainForm
            // 
            this.dataGridViewMainForm.AutoGenerateColumns = false;
            this.dataGridViewMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.cMTDataGridViewTextBoxColumn});
            this.dataGridViewMainForm.DataSource = this.khachHangBindingSource;
            this.dataGridViewMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMainForm.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMainForm.Name = "dataGridViewMainForm";
            this.dataGridViewMainForm.Size = new System.Drawing.Size(760, 385);
            this.dataGridViewMainForm.TabIndex = 0;
            // 
            // addKHBt
            // 
            this.addKHBt.Location = new System.Drawing.Point(16, 15);
            this.addKHBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addKHBt.Name = "addKHBt";
            this.addKHBt.Size = new System.Drawing.Size(143, 28);
            this.addKHBt.TabIndex = 1;
            this.addKHBt.Text = "Thêm khách hàng";
            this.addKHBt.UseVisualStyleBackColor = true;
            this.addKHBt.Click += new System.EventHandler(this.addKHBt_Click);
            // 
            // checkInBt
            // 
            this.checkInBt.Location = new System.Drawing.Point(16, 50);
            this.checkInBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkInBt.Name = "checkInBt";
            this.checkInBt.Size = new System.Drawing.Size(143, 28);
            this.checkInBt.TabIndex = 2;
            this.checkInBt.Text = "Check-in";
            this.checkInBt.UseVisualStyleBackColor = true;
            this.checkInBt.Click += new System.EventHandler(this.checkInBt_Click);
            // 
            // checkOutBt
            // 
            this.checkOutBt.Location = new System.Drawing.Point(16, 86);
            this.checkOutBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkOutBt.Name = "checkOutBt";
            this.checkOutBt.Size = new System.Drawing.Size(143, 28);
            this.checkOutBt.TabIndex = 3;
            this.checkOutBt.Text = "Check-out";
            this.checkOutBt.UseVisualStyleBackColor = true;
            this.checkOutBt.Click += new System.EventHandler(this.checkOutBt_Click);
            // 
            // datTruocBt
            // 
            this.datTruocBt.Location = new System.Drawing.Point(16, 122);
            this.datTruocBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datTruocBt.Name = "datTruocBt";
            this.datTruocBt.Size = new System.Drawing.Size(143, 28);
            this.datTruocBt.TabIndex = 4;
            this.datTruocBt.Text = "Đặt trước";
            this.datTruocBt.UseVisualStyleBackColor = true;
            this.datTruocBt.Click += new System.EventHandler(this.datTruocBt_Click);
            // 
            // lichSuBt
            // 
            this.lichSuBt.Location = new System.Drawing.Point(16, 158);
            this.lichSuBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lichSuBt.Name = "lichSuBt";
            this.lichSuBt.Size = new System.Drawing.Size(143, 28);
            this.lichSuBt.TabIndex = 5;
            this.lichSuBt.Text = "Lịch sử";
            this.lichSuBt.UseVisualStyleBackColor = true;
            this.lichSuBt.Click += new System.EventHandler(this.lichSuBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phần mềm quản lý khách sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông tin:";
            // 
            // timKiemTb
            // 
            this.timKiemTb.Location = new System.Drawing.Point(746, 128);
            this.timKiemTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timKiemTb.Name = "timKiemTb";
            this.timKiemTb.Size = new System.Drawing.Size(284, 22);
            this.timKiemTb.TabIndex = 8;
            // 
            // timBt
            // 
            this.timBt.Location = new System.Drawing.Point(893, 158);
            this.timBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timBt.Name = "timBt";
            this.timBt.Size = new System.Drawing.Size(136, 28);
            this.timBt.TabIndex = 9;
            this.timBt.Text = "Tìm kiếm";
            this.timBt.UseVisualStyleBackColor = true;
            this.timBt.Click += new System.EventHandler(this.timBt_Click);
            // 
            // comboBox_LoaiThongTin
            // 
            this.comboBox_LoaiThongTin.FormattingEnabled = true;
            this.comboBox_LoaiThongTin.Items.AddRange(new object[] {
            "CMT",
            "SĐT",
            "Họ tên"});
            this.comboBox_LoaiThongTin.Location = new System.Drawing.Point(746, 162);
            this.comboBox_LoaiThongTin.Name = "comboBox_LoaiThongTin";
            this.comboBox_LoaiThongTin.Size = new System.Drawing.Size(140, 24);
            this.comboBox_LoaiThongTin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại thông tin:";
            // tNN_QLKSDataSet
            // 
            this.tNN_QLKSDataSet.DataSetName = "TNN_QLKSDataSet";
            this.tNN_QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.tNN_QLKSDataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã Khách Hàng";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // cMTDataGridViewTextBoxColumn
            // 
            this.cMTDataGridViewTextBoxColumn.DataPropertyName = "CMT";
            this.cMTDataGridViewTextBoxColumn.HeaderText = "Chứng Minh Thư";
            this.cMTDataGridViewTextBoxColumn.Name = "cMTDataGridViewTextBoxColumn";
            this.cMTDataGridViewTextBoxColumn.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_LoaiThongTin);
            this.Controls.Add(this.timBt);
            this.Controls.Add(this.timKiemTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lichSuBt);
            this.Controls.Add(this.datTruocBt);
            this.Controls.Add(this.checkOutBt);
            this.Controls.Add(this.checkInBt);
            this.Controls.Add(this.addKHBt);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNN_QLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMainForm;
        private System.Windows.Forms.Button addKHBt;
        private System.Windows.Forms.Button checkInBt;
        private System.Windows.Forms.Button checkOutBt;
        private System.Windows.Forms.Button datTruocBt;
        private System.Windows.Forms.Button lichSuBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timKiemTb;
        private System.Windows.Forms.Button timBt;
        private TNN_QLKSDataSet tNN_QLKSDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private TNN_QLKSDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
    }
}