namespace LTWNCFashion
{
    partial class CauHinh
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
            this.cbosv = new System.Windows.Forms.ComboBox();
            this.cboDt = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cbosv
            // 
            this.cbosv.FormattingEnabled = true;
            this.cbosv.Location = new System.Drawing.Point(235, 92);
            this.cbosv.Name = "cbosv";
            this.cbosv.Size = new System.Drawing.Size(196, 21);
            this.cbosv.TabIndex = 0;
            // 
            // cboDt
            // 
            this.cboDt.FormattingEnabled = true;
            this.cboDt.Location = new System.Drawing.Point(235, 218);
            this.cboDt.Name = "cboDt";
            this.cboDt.Size = new System.Drawing.Size(196, 21);
            this.cboDt.TabIndex = 1;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(235, 137);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(196, 20);
            this.txtuser.TabIndex = 2;
            // 
            // txtpss
            // 
            this.txtpss.Location = new System.Drawing.Point(235, 177);
            this.txtpss.Name = "txtpss";
            this.txtpss.Size = new System.Drawing.Size(196, 20);
            this.txtpss.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sever name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passwword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(235, 264);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(348, 264);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(83, 33);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy bỏ";
            // 
            // CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 327);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpss);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.cboDt);
            this.Controls.Add(this.cbosv);
            this.Name = "CauHinh";
            this.Text = "CauHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbosv;
        private System.Windows.Forms.ComboBox cboDt;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}