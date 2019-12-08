namespace LTWNCFashion
{
    partial class FrmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHangHoa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gdv_HH = new System.Windows.Forms.DataGridView();
            this.MaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.cboTH = new System.Windows.Forms.ComboBox();
            this.btnThemthhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemloai = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSLT = new DevExpress.XtraEditors.TextEdit();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.pct_HinhAnh = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gdv_HH, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 341);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 303);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gdv_HH
            // 
            this.gdv_HH.AllowUserToAddRows = false;
            this.gdv_HH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_HH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_HH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaH,
            this.MaTH,
            this.MaL,
            this.TenH,
            this.DGB,
            this.DGN,
            this.SL,
            this.DVT,
            this.mota,
            this.HinhAnh,
            this.Column1,
            this.Column2});
            this.gdv_HH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdv_HH.Location = new System.Drawing.Point(4, 4);
            this.gdv_HH.Margin = new System.Windows.Forms.Padding(4);
            this.gdv_HH.Name = "gdv_HH";
            this.gdv_HH.Size = new System.Drawing.Size(1137, 295);
            this.gdv_HH.TabIndex = 0;
            this.gdv_HH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_HH_CellClick);
            // 
            // MaH
            // 
            this.MaH.DataPropertyName = "MaHang";
            this.MaH.HeaderText = "Mã Hàng";
            this.MaH.Name = "MaH";
            // 
            // MaTH
            // 
            this.MaTH.DataPropertyName = "MaThuongHieu";
            this.MaTH.HeaderText = "Mã Thương Hiệu";
            this.MaTH.Name = "MaTH";
            // 
            // MaL
            // 
            this.MaL.DataPropertyName = "MaLoai";
            this.MaL.HeaderText = "Mã Loại";
            this.MaL.Name = "MaL";
            // 
            // TenH
            // 
            this.TenH.DataPropertyName = "TenHang";
            this.TenH.HeaderText = "Tên Hàng";
            this.TenH.Name = "TenH";
            // 
            // DGB
            // 
            this.DGB.DataPropertyName = "DonGiaBan";
            this.DGB.HeaderText = "Đơn Giá Bán";
            this.DGB.Name = "DGB";
            // 
            // DGN
            // 
            this.DGN.DataPropertyName = "DonGiaNhap";
            this.DGN.HeaderText = "Đơn Giá Nhập";
            this.DGN.Name = "DGN";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoluongTon";
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn Vị Tính";
            this.DVT.Name = "DVT";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "MoTa";
            this.mota.HeaderText = "Mô Tả";
            this.mota.Name = "mota";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "HinhAnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ThuongHieu";
            this.Column1.HeaderText = "TheLoai";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TheLoai";
            this.Column2.HeaderText = "ThuongHieu";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1145, 341);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Quản Lý Hàng Hóa";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 39);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.56134F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.43866F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1141, 300);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.53955F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.03854F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.19473F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Luu, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Sua, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1133, 56);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.ImageOptions.Image")));
            this.btn_Them.Location = new System.Drawing.Point(151, 4);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 48);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(372, 4);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 48);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.ImageOptions.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(866, 4);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 48);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Thoát";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Appearance.Options.UseFont = true;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(666, 4);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 48);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94839F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71075F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.35229F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pct_HinhAnh, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1135, 230);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.19743F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.80257F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel5.Controls.Add(this.labelControl10, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.cboLoai, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtTenHang, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.txtMaHang, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtGiaNhap, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.cboTH, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnThemthhieu, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnThemloai, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtDonGiaBan, 1, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.75325F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.24675F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(386, 224);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl10.Location = new System.Drawing.Point(3, 193);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(75, 16);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Đơn Giá Bán:";
            // 
            // cboLoai
            // 
            this.cboLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboLoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(132, 122);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(204, 24);
            this.cboLoai.TabIndex = 9;
            this.cboLoai.Click += new System.EventHandler(this.cboLoai_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenHang.Location = new System.Drawing.Point(132, 39);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Properties.Appearance.Options.UseFont = true;
            this.txtTenHang.Size = new System.Drawing.Size(204, 22);
            this.txtTenHang.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(3, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(3, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Thương Hiệu";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(3, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Loại";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl5.Location = new System.Drawing.Point(3, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Đơn Giá Nhập:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaHang.Location = new System.Drawing.Point(132, 3);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Properties.Appearance.Options.UseFont = true;
            this.txtMaHang.Size = new System.Drawing.Size(204, 22);
            this.txtMaHang.TabIndex = 5;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaNhap.Location = new System.Drawing.Point(132, 161);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Properties.Appearance.Options.UseFont = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(204, 22);
            this.txtGiaNhap.TabIndex = 7;
            // 
            // cboTH
            // 
            this.cboTH.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTH.FormattingEnabled = true;
            this.cboTH.Location = new System.Drawing.Point(132, 80);
            this.cboTH.Name = "cboTH";
            this.cboTH.Size = new System.Drawing.Size(204, 24);
            this.cboTH.TabIndex = 8;
            this.cboTH.Click += new System.EventHandler(this.cboTH_Click);
            // 
            // btnThemthhieu
            // 
            this.btnThemthhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemthhieu.Location = new System.Drawing.Point(342, 86);
            this.btnThemthhieu.Name = "btnThemthhieu";
            this.btnThemthhieu.Size = new System.Drawing.Size(41, 23);
            this.btnThemthhieu.TabIndex = 10;
            this.btnThemthhieu.Text = "...";
            this.btnThemthhieu.Click += new System.EventHandler(this.btnThemthhieu_Click);
            // 
            // btnThemloai
            // 
            this.btnThemloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemloai.Location = new System.Drawing.Point(342, 125);
            this.btnThemloai.Name = "btnThemloai";
            this.btnThemloai.Size = new System.Drawing.Size(41, 23);
            this.btnThemloai.TabIndex = 11;
            this.btnThemloai.Text = "...";
            this.btnThemloai.Click += new System.EventHandler(this.btnThemloai_Click);
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonGiaBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(133, 194);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(202, 23);
            this.txtDonGiaBan.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.tableLayoutPanel6.Controls.Add(this.labelControl6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelControl7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelControl8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtSLT, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtMoTa, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.cboDVT, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(653, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(349, 224);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl6.Location = new System.Drawing.Point(3, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Số Lượng";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl7.Location = new System.Drawing.Point(3, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Đơn Vị Tính";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl8.Location = new System.Drawing.Point(3, 78);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 16);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Mô Tả";
            // 
            // txtSLT
            // 
            this.txtSLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSLT.Location = new System.Drawing.Point(116, 3);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLT.Properties.Appearance.Options.UseFont = true;
            this.txtSLT.Size = new System.Drawing.Size(230, 22);
            this.txtSLT.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMoTa.Location = new System.Drawing.Point(116, 78);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Size = new System.Drawing.Size(230, 22);
            this.txtMoTa.TabIndex = 5;
            // 
            // cboDVT
            // 
            this.cboDVT.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboDVT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Cái",
            "Cặp"});
            this.cboDVT.Location = new System.Drawing.Point(116, 41);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(230, 24);
            this.cboDVT.TabIndex = 7;
            // 
            // pct_HinhAnh
            // 
            this.pct_HinhAnh.BackColor = System.Drawing.Color.White;
            this.pct_HinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pct_HinhAnh.Location = new System.Drawing.Point(395, 3);
            this.pct_HinhAnh.Name = "pct_HinhAnh";
            this.pct_HinhAnh.Size = new System.Drawing.Size(252, 224);
            this.pct_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_HinhAnh.TabIndex = 8;
            this.pct_HinhAnh.TabStop = false;
            this.pct_HinhAnh.DoubleClick += new System.EventHandler(this.pct_HinhAnh_DoubleClick);
            // 
            // FrmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 644);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHangHoa";
            this.Text = "FrmHangHoa";
            this.Load += new System.EventHandler(this.FrmHangHoa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_HinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gdv_HH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cboLoai;
        private DevExpress.XtraEditors.TextEdit txtTenHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private DevExpress.XtraEditors.TextEdit txtGiaNhap;
        private System.Windows.Forms.ComboBox cboTH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSLT;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private System.Windows.Forms.ComboBox cboDVT;
        private DevExpress.XtraEditors.SimpleButton btnThemthhieu;
        private DevExpress.XtraEditors.SimpleButton btnThemloai;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.PictureBox pct_HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}