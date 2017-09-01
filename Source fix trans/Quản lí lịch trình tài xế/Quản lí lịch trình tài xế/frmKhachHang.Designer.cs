namespace Quản_lí_lịch_trình_tài_xế
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDatve = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHuyve = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTuyenDuong = new System.Windows.Forms.ComboBox();
            this.dgvLichTrinh = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDatve,
            this.toolStripSeparator2,
            this.btnHuyve,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1358, 68);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDatve
            // 
            this.btnDatve.Image = ((System.Drawing.Image)(resources.GetObject("btnDatve.Image")));
            this.btnDatve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDatve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDatve.Name = "btnDatve";
            this.btnDatve.RightToLeftAutoMirrorImage = true;
            this.btnDatve.Size = new System.Drawing.Size(61, 65);
            this.btnDatve.Text = " Đặt vé ";
            this.btnDatve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDatve.Click += new System.EventHandler(this.btnDatve_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // btnHuyve
            // 
            this.btnHuyve.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyve.Image")));
            this.btnHuyve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHuyve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyve.Name = "btnHuyve";
            this.btnHuyve.Size = new System.Drawing.Size(64, 65);
            this.btnHuyve.Text = " Hủy vé ";
            this.btnHuyve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuyve.Click += new System.EventHandler(this.btnHuyve_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tuyến đường:";
            // 
            // cboTuyenDuong
            // 
            this.cboTuyenDuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyenDuong.FormattingEnabled = true;
            this.cboTuyenDuong.Location = new System.Drawing.Point(552, 76);
            this.cboTuyenDuong.Name = "cboTuyenDuong";
            this.cboTuyenDuong.Size = new System.Drawing.Size(350, 27);
            this.cboTuyenDuong.TabIndex = 8;
            this.cboTuyenDuong.SelectedIndexChanged += new System.EventHandler(this.cboTuyenDuong_SelectedIndexChanged);
            // 
            // dgvLichTrinh
            // 
            this.dgvLichTrinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTrinh.Location = new System.Drawing.Point(12, 118);
            this.dgvLichTrinh.MultiSelect = false;
            this.dgvLichTrinh.Name = "dgvLichTrinh";
            this.dgvLichTrinh.ReadOnly = true;
            this.dgvLichTrinh.RowHeadersVisible = false;
            this.dgvLichTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTrinh.Size = new System.Drawing.Size(1334, 567);
            this.dgvLichTrinh.TabIndex = 9;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 697);
            this.Controls.Add(this.dgvLichTrinh);
            this.Controls.Add(this.cboTuyenDuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng đặt vé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDatve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHuyve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTuyenDuong;
        private System.Windows.Forms.DataGridView dgvLichTrinh;
    }
}