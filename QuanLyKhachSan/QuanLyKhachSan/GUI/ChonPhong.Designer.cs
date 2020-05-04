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
            this.phongDataGrid = new System.Windows.Forms.DataGridView();
            this.huyBt = new System.Windows.Forms.Button();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.checkPhong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // phongDataGrid
            // 
            this.phongDataGrid.AllowUserToAddRows = false;
            this.phongDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkPhong});
            this.phongDataGrid.Location = new System.Drawing.Point(12, 12);
            this.phongDataGrid.Name = "phongDataGrid";
            this.phongDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phongDataGrid.Size = new System.Drawing.Size(560, 398);
            this.phongDataGrid.TabIndex = 0;
            // 
            // huyBt
            // 
            this.huyBt.Location = new System.Drawing.Point(126, 426);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(75, 23);
            this.huyBt.TabIndex = 1;
            this.huyBt.Text = "Huỷ";
            this.huyBt.UseVisualStyleBackColor = true;
            this.huyBt.Click += new System.EventHandler(this.HuyBt_Click);
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.Location = new System.Drawing.Point(362, 426);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(75, 23);
            this.xacNhanBt.TabIndex = 2;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = true;
            this.xacNhanBt.Click += new System.EventHandler(this.XacNhanBt_Click);
            // 
            // checkPhong
            // 
            this.checkPhong.HeaderText = "Chọn Phòng";
            this.checkPhong.Name = "checkPhong";
            this.checkPhong.ReadOnly = true;
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
            this.Text = "Chọn phòng";
            this.Load += new System.EventHandler(this.ChonPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView phongDataGrid;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Button xacNhanBt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkPhong;
    }
}