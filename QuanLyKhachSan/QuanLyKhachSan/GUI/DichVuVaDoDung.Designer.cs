namespace QuanLyKhachSan.GUI
{
    partial class DichVuVaDoDung
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
            this.comboBoxChon = new System.Windows.Forms.ComboBox();
            this.dataGridViewChon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDanhSach = new System.Windows.Forms.DataGridView();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.huyBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.themBt = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSach)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChon
            // 
            this.comboBoxChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChon.FormattingEnabled = true;
            this.comboBoxChon.Items.AddRange(new object[] {
            "Đồ Dùng",
            "Dịch Vụ",
            "Tất Cả"});
            this.comboBoxChon.Location = new System.Drawing.Point(451, 12);
            this.comboBoxChon.Name = "comboBoxChon";
            this.comboBoxChon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChon.TabIndex = 0;
            this.comboBoxChon.SelectedIndexChanged += new System.EventHandler(this.comboBoxChon_SelectedIndexChanged);
            // 
            // dataGridViewChon
            // 
            this.dataGridViewChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChon.Location = new System.Drawing.Point(13, 39);
            this.dataGridViewChon.Name = "dataGridViewChon";
            this.dataGridViewChon.ReadOnly = true;
            this.dataGridViewChon.Size = new System.Drawing.Size(560, 143);
            this.dataGridViewChon.TabIndex = 1;
            this.dataGridViewChon.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewChon_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(13, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách của khách hàng";
            // 
            // dataGridViewDanhSach
            // 
            this.dataGridViewDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSach.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDanhSach.Name = "dataGridViewDanhSach";
            this.dataGridViewDanhSach.RowTemplate.Height = 24;
            this.dataGridViewDanhSach.Size = new System.Drawing.Size(550, 182);
            this.dataGridViewDanhSach.TabIndex = 0;
            this.dataGridViewDanhSach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDanhSach_MouseClick);
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.Location = new System.Drawing.Point(378, 426);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(75, 23);
            this.xacNhanBt.TabIndex = 7;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = true;
            this.xacNhanBt.Click += new System.EventHandler(this.xacNhanBt_Click);
            // 
            // huyBt
            // 
            this.huyBt.Location = new System.Drawing.Point(119, 426);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(75, 23);
            this.huyBt.TabIndex = 5;
            this.huyBt.Text = "Huỷ";
            this.huyBt.UseVisualStyleBackColor = true;
            this.huyBt.Click += new System.EventHandler(this.huyBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số lượng:";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSoLuong.Location = new System.Drawing.Point(72, 188);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoLuong.TabIndex = 9;
            this.textBoxSoLuong.Text = "Nhập số khác 0";
            this.textBoxSoLuong.Enter += new System.EventHandler(this.textBoxSoLuong_Enter);
            this.textBoxSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBoxSoLuong.Leave += new System.EventHandler(this.textBoxSoLuong_Leave);
            // 
            // themBt
            // 
            this.themBt.Enabled = false;
            this.themBt.Location = new System.Drawing.Point(252, 186);
            this.themBt.Name = "themBt";
            this.themBt.Size = new System.Drawing.Size(75, 23);
            this.themBt.TabIndex = 10;
            this.themBt.Text = "Thêm";
            this.themBt.UseVisualStyleBackColor = true;
            this.themBt.Click += new System.EventHandler(this.themBt_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // DichVuVaDoDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.themBt);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xacNhanBt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewChon);
            this.Controls.Add(this.huyBt);
            this.Controls.Add(this.comboBoxChon);
            this.Name = "DichVuVaDoDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ và đồ dùng";
            this.Load += new System.EventHandler(this.DichVuVaDoDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSach)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChon;
        private System.Windows.Forms.DataGridView dataGridViewChon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button xacNhanBt;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Button themBt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewDanhSach;
    }
}