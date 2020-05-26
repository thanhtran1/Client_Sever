using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue"; //Giao diện hiển thị đầu tiên
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            skins();
            System.Drawing.Rectangle workingRectangle =
        Screen.PrimaryScreen.WorkingArea;
            Console.WriteLine(workingRectangle.Width);
            Point p = new Point();
            
            p.X = workingRectangle.Width - this.Width;
            p.Y = 0;
            this.Location = p;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            Form frm_TinNhan = new frm_TinNhan();
            frm_TinNhan.ShowDialog();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
