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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addKHBt = new System.Windows.Forms.Button();
            this.checkInBt = new System.Windows.Forms.Button();
            this.checkOutBt = new System.Windows.Forms.Button();
            this.datTruocBt = new System.Windows.Forms.Button();
            this.lichSuBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timKiemTb = new System.Windows.Forms.TextBox();
            this.timBt = new System.Windows.Forms.Button();
            this.theToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 385);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(760, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // addKHBt
            // 
            this.addKHBt.Location = new System.Drawing.Point(12, 12);
            this.addKHBt.Name = "addKHBt";
            this.addKHBt.Size = new System.Drawing.Size(107, 23);
            this.addKHBt.TabIndex = 1;
            this.addKHBt.Text = "Thêm khách hàng";
            this.addKHBt.UseVisualStyleBackColor = true;
            this.addKHBt.Click += new System.EventHandler(this.addKHBt_Click);
            // 
            // checkInBt
            // 
            this.checkInBt.Location = new System.Drawing.Point(12, 41);
            this.checkInBt.Name = "checkInBt";
            this.checkInBt.Size = new System.Drawing.Size(107, 23);
            this.checkInBt.TabIndex = 2;
            this.checkInBt.Text = "Check-in";
            this.checkInBt.UseVisualStyleBackColor = true;
            this.checkInBt.Click += new System.EventHandler(this.checkInBt_Click);
            // 
            // checkOutBt
            // 
            this.checkOutBt.Location = new System.Drawing.Point(12, 70);
            this.checkOutBt.Name = "checkOutBt";
            this.checkOutBt.Size = new System.Drawing.Size(107, 23);
            this.checkOutBt.TabIndex = 3;
            this.checkOutBt.Text = "Check-out";
            this.checkOutBt.UseVisualStyleBackColor = true;
            this.checkOutBt.Click += new System.EventHandler(this.checkOutBt_Click);
            // 
            // datTruocBt
            // 
            this.datTruocBt.Location = new System.Drawing.Point(12, 99);
            this.datTruocBt.Name = "datTruocBt";
            this.datTruocBt.Size = new System.Drawing.Size(107, 23);
            this.datTruocBt.TabIndex = 4;
            this.datTruocBt.Text = "Đặt trước";
            this.datTruocBt.UseVisualStyleBackColor = true;
            this.datTruocBt.Click += new System.EventHandler(this.datTruocBt_Click);
            // 
            // lichSuBt
            // 
            this.lichSuBt.Location = new System.Drawing.Point(12, 128);
            this.lichSuBt.Name = "lichSuBt";
            this.lichSuBt.Size = new System.Drawing.Size(107, 23);
            this.lichSuBt.TabIndex = 5;
            this.lichSuBt.Text = "Lịch sử";
            this.lichSuBt.UseVisualStyleBackColor = true;
            this.lichSuBt.Click += new System.EventHandler(this.lichSuBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phần mềm quản lý khách sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông tin:";
            // 
            // timKiemTb
            // 
            this.timKiemTb.Location = new System.Drawing.Point(560, 104);
            this.timKiemTb.Name = "timKiemTb";
            this.timKiemTb.Size = new System.Drawing.Size(214, 20);
            this.timKiemTb.TabIndex = 8;
            // 
            // timBt
            // 
            this.timBt.Location = new System.Drawing.Point(670, 128);
            this.timBt.Name = "timBt";
            this.timBt.Size = new System.Drawing.Size(102, 23);
            this.timBt.TabIndex = 9;
            this.timBt.Text = "Tìm kiếm";
            this.timBt.UseVisualStyleBackColor = true;
            this.timBt.Click += new System.EventHandler(this.timBt_Click);
            // 
            // theToolStripMenuItem
            // 
            this.theToolStripMenuItem.Name = "theToolStripMenuItem";
            this.theToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.theToolStripMenuItem.Text = "Thêm Đồ Dùng Và Dịch Vụ";
            this.theToolStripMenuItem.Click += new System.EventHandler(this.theToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 26);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 560);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 599);
            this.MinimumSize = new System.Drawing.Size(800, 599);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addKHBt;
        private System.Windows.Forms.Button checkInBt;
        private System.Windows.Forms.Button checkOutBt;
        private System.Windows.Forms.Button datTruocBt;
        private System.Windows.Forms.Button lichSuBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timKiemTb;
        private System.Windows.Forms.Button timBt;
        private System.Windows.Forms.ToolStripMenuItem theToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}