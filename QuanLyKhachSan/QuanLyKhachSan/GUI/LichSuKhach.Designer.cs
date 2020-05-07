namespace QuanLyKhachSan.GUI
{
    partial class LichSuKhach
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLichSuCuaKhach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichSuCuaKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lịch Sử Thuê Phòng Của Khách";
            // 
            // dataGridViewLichSuCuaKhach
            // 
            this.dataGridViewLichSuCuaKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLichSuCuaKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichSuCuaKhach.Location = new System.Drawing.Point(1, 36);
            this.dataGridViewLichSuCuaKhach.Name = "dataGridViewLichSuCuaKhach";
            this.dataGridViewLichSuCuaKhach.Size = new System.Drawing.Size(444, 286);
            this.dataGridViewLichSuCuaKhach.TabIndex = 2;
            // 
            // LichSuKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLichSuCuaKhach);
            this.Name = "LichSuKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichSuKhach";
            this.Load += new System.EventHandler(this.LichSuKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichSuCuaKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLichSuCuaKhach;
    }
}