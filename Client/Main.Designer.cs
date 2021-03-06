﻿namespace Client
{
    partial class Main
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMaMay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongThoiGian = new DevExpress.XtraEditors.TextEdit();
            this.txtThoiGianSuDung = new DevExpress.XtraEditors.TextEdit();
            this.tctThoiGianConLai = new DevExpress.XtraEditors.TextEdit();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnTinNhan = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianSuDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctThoiGianConLai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(181, 159);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(390, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(158, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 27);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Máy 01";
            // 
            // lblMaMay
            // 
            this.lblMaMay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMay.Appearance.Options.UseFont = true;
            this.lblMaMay.Location = new System.Drawing.Point(43, 77);
            this.lblMaMay.Margin = new System.Windows.Forms.Padding(4);
            this.lblMaMay.Name = "lblMaMay";
            this.lblMaMay.Size = new System.Drawing.Size(148, 22);
            this.lblMaMay.TabIndex = 44;
            this.lblMaMay.Text = "Tổng thời gian: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 130);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(184, 22);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Thời gian sử dụng: ";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 187);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 22);
            this.labelControl4.TabIndex = 46;
            this.labelControl4.Text = "Thời gian còn lại: ";
            // 
            // txtTongThoiGian
            // 
            this.txtTongThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTongThoiGian.Location = new System.Drawing.Point(216, 77);
            this.txtTongThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongThoiGian.Name = "txtTongThoiGian";
            this.txtTongThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThoiGian.Properties.Appearance.Options.UseFont = true;
            this.txtTongThoiGian.Size = new System.Drawing.Size(141, 28);
            this.txtTongThoiGian.TabIndex = 47;
            // 
            // txtThoiGianSuDung
            // 
            this.txtThoiGianSuDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThoiGianSuDung.Location = new System.Drawing.Point(216, 130);
            this.txtThoiGianSuDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianSuDung.Name = "txtThoiGianSuDung";
            this.txtThoiGianSuDung.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianSuDung.Properties.Appearance.Options.UseFont = true;
            this.txtThoiGianSuDung.Size = new System.Drawing.Size(141, 28);
            this.txtThoiGianSuDung.TabIndex = 48;
            // 
            // tctThoiGianConLai
            // 
            this.tctThoiGianConLai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tctThoiGianConLai.Location = new System.Drawing.Point(216, 187);
            this.tctThoiGianConLai.Margin = new System.Windows.Forms.Padding(4);
            this.tctThoiGianConLai.Name = "tctThoiGianConLai";
            this.tctThoiGianConLai.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctThoiGianConLai.Properties.Appearance.Options.UseFont = true;
            this.tctThoiGianConLai.Size = new System.Drawing.Size(141, 28);
            this.tctThoiGianConLai.TabIndex = 49;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.ImageOptions.Image = global::Client.Properties.Resources.modify_key_icon__1_;
            this.btnDoiMatKhau.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(95, 355);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(178, 51);
            this.btnDoiMatKhau.TabIndex = 52;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // btnTinNhan
            // 
            this.btnTinNhan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinNhan.Appearance.Options.UseFont = true;
            this.btnTinNhan.ImageOptions.Image = global::Client.Properties.Resources.SMS_Message_icon__1_;
            this.btnTinNhan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTinNhan.Location = new System.Drawing.Point(30, 287);
            this.btnTinNhan.Name = "btnTinNhan";
            this.btnTinNhan.Size = new System.Drawing.Size(151, 51);
            this.btnTinNhan.TabIndex = 51;
            this.btnTinNhan.Text = "Tin nhắn";
            this.btnTinNhan.Click += new System.EventHandler(this.btnTinNhan_Click);
            // 
            // BtnDangXuat
            // 
            this.BtnDangXuat.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDangXuat.Appearance.Options.UseFont = true;
            this.BtnDangXuat.ImageOptions.Image = global::Client.Properties.Resources.logout_icon;
            this.BtnDangXuat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnDangXuat.Location = new System.Drawing.Point(206, 287);
            this.BtnDangXuat.Name = "BtnDangXuat";
            this.BtnDangXuat.Size = new System.Drawing.Size(151, 51);
            this.BtnDangXuat.TabIndex = 50;
            this.BtnDangXuat.Text = "Đăng xuất";
            this.BtnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 421);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnTinNhan);
            this.Controls.Add(this.BtnDangXuat);
            this.Controls.Add(this.tctThoiGianConLai);
            this.Controls.Add(this.txtThoiGianSuDung);
            this.Controls.Add(this.txtTongThoiGian);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblMaMay);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianSuDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctThoiGianConLai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblMaMay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTongThoiGian;
        private DevExpress.XtraEditors.TextEdit txtThoiGianSuDung;
        private DevExpress.XtraEditors.TextEdit tctThoiGianConLai;
        private DevExpress.XtraEditors.SimpleButton BtnDangXuat;
        private DevExpress.XtraEditors.SimpleButton btnTinNhan;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
    }
}

