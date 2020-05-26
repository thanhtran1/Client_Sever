namespace Client
{
    partial class frm_TinNhan
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
            this.lvMess = new System.Windows.Forms.ListView();
            this.tbMessage = new DevExpress.XtraEditors.TextEdit();
            this.btnGui = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMess
            // 
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(67, 34);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(481, 241);
            this.lvMess.TabIndex = 0;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(67, 304);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Properties.Appearance.Options.UseFont = true;
            this.tbMessage.Size = new System.Drawing.Size(480, 34);
            this.tbMessage.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Appearance.Options.UseFont = true;
            this.btnGui.Location = new System.Drawing.Point(563, 300);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(105, 41);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Gửi ";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // frm_TinNhan
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 392);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lvMess);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_TinNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIN NHẮN";
            this.Load += new System.EventHandler(this.TinNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMessage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMess;
        private DevExpress.XtraEditors.TextEdit tbMessage;
        private DevExpress.XtraEditors.SimpleButton btnGui;
    }
}