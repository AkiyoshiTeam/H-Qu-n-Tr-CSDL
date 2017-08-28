namespace Quản_lí_lịch_trình_tài_xế
{
    partial class frmLichTrinhTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichTrinhTo));
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtkGioDen = new System.Windows.Forms.DateTimePicker();
            this.dtkGioDi = new System.Windows.Forms.DateTimePicker();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboChuyenXe = new System.Windows.Forms.ComboBox();
            this.cboTuyenDuong = new System.Windows.Forms.ComboBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNoiDen = new System.Windows.Forms.TextBox();
            this.txtNoiDi = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.txtMaLich = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLichTrinh = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1358, 60);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "LỊCH TRÌNH TRONG TỔ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dtkGioDen);
            this.groupBox1.Controls.Add(this.dtkGioDi);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboChuyenXe);
            this.groupBox1.Controls.Add(this.cboTuyenDuong);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Controls.Add(this.txtNoiDen);
            this.groupBox1.Controls.Add(this.txtNoiDi);
            this.groupBox1.Controls.Add(this.txtKhoangCach);
            this.groupBox1.Controls.Add(this.txtMaLich);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1334, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch trình";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1152, 117);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 31);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtkGioDen
            // 
            this.dtkGioDen.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtkGioDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkGioDen.Location = new System.Drawing.Point(620, 64);
            this.dtkGioDen.Name = "dtkGioDen";
            this.dtkGioDen.Size = new System.Drawing.Size(309, 26);
            this.dtkGioDen.TabIndex = 52;
            this.toolTip1.SetToolTip(this.dtkGioDen, "Định dạng: dd/mm/yyyy HH:mm tt");
            // 
            // dtkGioDi
            // 
            this.dtkGioDi.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtkGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkGioDi.Location = new System.Drawing.Point(620, 29);
            this.dtkGioDi.Name = "dtkGioDi";
            this.dtkGioDi.Size = new System.Drawing.Size(309, 26);
            this.dtkGioDi.TabIndex = 51;
            this.toolTip1.SetToolTip(this.dtkGioDi, "Định dạng: dd/mm/yyyy HH:mm tt");
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(115, 136);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(350, 27);
            this.cboMaNV.TabIndex = 24;
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(1003, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 31);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(1003, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 31);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(901, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "km";
            // 
            // cboChuyenXe
            // 
            this.cboChuyenXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenXe.FormattingEnabled = true;
            this.cboChuyenXe.Location = new System.Drawing.Point(115, 173);
            this.cboChuyenXe.Name = "cboChuyenXe";
            this.cboChuyenXe.Size = new System.Drawing.Size(350, 27);
            this.cboChuyenXe.TabIndex = 20;
            // 
            // cboTuyenDuong
            // 
            this.cboTuyenDuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyenDuong.FormattingEnabled = true;
            this.cboTuyenDuong.Location = new System.Drawing.Point(115, 99);
            this.cboTuyenDuong.Name = "cboTuyenDuong";
            this.cboTuyenDuong.Size = new System.Drawing.Size(350, 27);
            this.cboTuyenDuong.TabIndex = 19;
            this.cboTuyenDuong.SelectedIndexChanged += new System.EventHandler(this.cboTuyenDuong_SelectedIndexChanged);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(115, 64);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(350, 26);
            this.txtThang.TabIndex = 15;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtNoiDen
            // 
            this.txtNoiDen.Location = new System.Drawing.Point(620, 136);
            this.txtNoiDen.Name = "txtNoiDen";
            this.txtNoiDen.Size = new System.Drawing.Size(309, 26);
            this.txtNoiDen.TabIndex = 14;
            // 
            // txtNoiDi
            // 
            this.txtNoiDi.Location = new System.Drawing.Point(620, 99);
            this.txtNoiDi.Name = "txtNoiDi";
            this.txtNoiDi.Size = new System.Drawing.Size(309, 26);
            this.txtNoiDi.TabIndex = 13;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(620, 174);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.ReadOnly = true;
            this.txtKhoangCach.Size = new System.Drawing.Size(275, 26);
            this.txtKhoangCach.TabIndex = 12;
            // 
            // txtMaLich
            // 
            this.txtMaLich.Location = new System.Drawing.Point(115, 29);
            this.txtMaLich.Name = "txtMaLich";
            this.txtMaLich.ReadOnly = true;
            this.txtMaLich.Size = new System.Drawing.Size(350, 26);
            this.txtMaLich.TabIndex = 50;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.Location = new System.Drawing.Point(1152, 70);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(127, 31);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Khoảng cách : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tháng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã nhân viên : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giờ đi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giờ đến :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nơi đi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tuyến đường :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chuyến xe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nơi đến :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lịch :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLichTrinh);
            this.groupBox2.Location = new System.Drawing.Point(14, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 398);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch trình";
            // 
            // dgvLichTrinh
            // 
            this.dgvLichTrinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTrinh.Location = new System.Drawing.Point(12, 25);
            this.dgvLichTrinh.MultiSelect = false;
            this.dgvLichTrinh.Name = "dgvLichTrinh";
            this.dgvLichTrinh.ReadOnly = true;
            this.dgvLichTrinh.RowHeadersVisible = false;
            this.dgvLichTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTrinh.Size = new System.Drawing.Size(1309, 359);
            this.dgvLichTrinh.TabIndex = 1;
            this.dgvLichTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichTrinh_CellClick);
            this.dgvLichTrinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLichTrinh_KeyDown);
            this.dgvLichTrinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvLichTrinh_KeyUp);
            // 
            // frmLichTrinhTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLichTrinhTo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch trình trong tổ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLichTrinhTo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNoiDen;
        private System.Windows.Forms.TextBox txtNoiDi;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.TextBox txtMaLich;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChuyenXe;
        private System.Windows.Forms.ComboBox cboTuyenDuong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLichTrinh;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtkGioDi;
        private System.Windows.Forms.DateTimePicker dtkGioDen;
        private System.Windows.Forms.Button btnThoat;
    }
}