namespace Quanlyquannet.Views
{
    partial class frm_Tinnhan
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
            this.btnGui = new DevExpress.XtraEditors.SimpleButton();
            this.tbMessage = new DevExpress.XtraEditors.TextEdit();
            this.lvMess = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Appearance.Options.UseFont = true;
            this.btnGui.Location = new System.Drawing.Point(586, 315);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(105, 41);
            this.btnGui.TabIndex = 5;
            this.btnGui.Text = "Gửi ";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(90, 319);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Properties.Appearance.Options.UseFont = true;
            this.tbMessage.Size = new System.Drawing.Size(480, 34);
            this.tbMessage.TabIndex = 4;
            // 
            // lvMess
            // 
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(90, 49);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(481, 241);
            this.lvMess.TabIndex = 3;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            // 
            // frm_Tinnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 418);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lvMess);
            this.Name = "frm_Tinnhan";
            this.Text = "TIN NHẮN";
            this.Load += new System.EventHandler(this.Tinnhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMessage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGui;
        private DevExpress.XtraEditors.TextEdit tbMessage;
        private System.Windows.Forms.ListView lvMess;
    }
}