namespace QuanLyKhachSan.GUI
{
    partial class ChonPhong
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
            this.phongDataGrid = new System.Windows.Forms.DataGridView();
            this.maPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhongNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhongGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trongDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tNN_QLKSDataSet1 = new QuanLyKhachSan.TNN_QLKSDataSet1();
            this.huyBt = new System.Windows.Forms.Button();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.phongTableAdapter = new QuanLyKhachSan.TNN_QLKSDataSet1TableAdapters.PhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNN_QLKSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // phongDataGrid
            // 
            this.phongDataGrid.AutoGenerateColumns = false;
            this.phongDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPDataGridViewTextBoxColumn,
            this.giaPhongNgayDataGridViewTextBoxColumn,
            this.giaPhongGioDataGridViewTextBoxColumn,
            this.tangDataGridViewTextBoxColumn,
            this.trongDataGridViewCheckBoxColumn});
            this.phongDataGrid.DataSource = this.phongBindingSource;
            this.phongDataGrid.Location = new System.Drawing.Point(12, 12);
            this.phongDataGrid.Name = "phongDataGrid";
            this.phongDataGrid.Size = new System.Drawing.Size(560, 398);
            this.phongDataGrid.TabIndex = 0;
            // 
            // maPDataGridViewTextBoxColumn
            // 
            this.maPDataGridViewTextBoxColumn.DataPropertyName = "MaP";
            this.maPDataGridViewTextBoxColumn.HeaderText = "Mã Phòng";
            this.maPDataGridViewTextBoxColumn.Name = "maPDataGridViewTextBoxColumn";
            // 
            // giaPhongNgayDataGridViewTextBoxColumn
            // 
            this.giaPhongNgayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaPhongNgayDataGridViewTextBoxColumn.DataPropertyName = "GiaPhongNgay";
            this.giaPhongNgayDataGridViewTextBoxColumn.HeaderText = "Giá Ngày";
            this.giaPhongNgayDataGridViewTextBoxColumn.Name = "giaPhongNgayDataGridViewTextBoxColumn";
            // 
            // giaPhongGioDataGridViewTextBoxColumn
            // 
            this.giaPhongGioDataGridViewTextBoxColumn.DataPropertyName = "GiaPhongGio";
            this.giaPhongGioDataGridViewTextBoxColumn.HeaderText = "Giá Theo Giờ";
            this.giaPhongGioDataGridViewTextBoxColumn.Name = "giaPhongGioDataGridViewTextBoxColumn";
            // 
            // tangDataGridViewTextBoxColumn
            // 
            this.tangDataGridViewTextBoxColumn.DataPropertyName = "Tang";
            this.tangDataGridViewTextBoxColumn.HeaderText = "Tầng";
            this.tangDataGridViewTextBoxColumn.Name = "tangDataGridViewTextBoxColumn";
            // 
            // trongDataGridViewCheckBoxColumn
            // 
            this.trongDataGridViewCheckBoxColumn.DataPropertyName = "Trong";
            this.trongDataGridViewCheckBoxColumn.HeaderText = "Trống";
            this.trongDataGridViewCheckBoxColumn.Name = "trongDataGridViewCheckBoxColumn";
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.tNN_QLKSDataSet1;
            // 
            // tNN_QLKSDataSet1
            // 
            this.tNN_QLKSDataSet1.DataSetName = "TNN_QLKSDataSet1";
            this.tNN_QLKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // huyBt
            // 
            this.huyBt.Location = new System.Drawing.Point(126, 426);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(75, 23);
            this.huyBt.TabIndex = 1;
            this.huyBt.Text = "Huỷ";
            this.huyBt.UseVisualStyleBackColor = true;
            this.huyBt.Click += new System.EventHandler(this.huyBt_Click);
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.Location = new System.Drawing.Point(362, 426);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(75, 23);
            this.xacNhanBt.TabIndex = 2;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = true;
            this.xacNhanBt.Click += new System.EventHandler(this.xacNhanBt_Click);
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // ChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.xacNhanBt);
            this.Controls.Add(this.huyBt);
            this.Controls.Add(this.phongDataGrid);
            this.Name = "ChonPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn phòng";
            this.Load += new System.EventHandler(this.ChonPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNN_QLKSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView phongDataGrid;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Button xacNhanBt;
        private TNN_QLKSDataSet1 tNN_QLKSDataSet1;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private TNN_QLKSDataSet1TableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhongNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhongGioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trongDataGridViewCheckBoxColumn;
    }
}