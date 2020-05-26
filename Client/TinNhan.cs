using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Client
{
    public partial class frm_TinNhan : DevExpress.XtraEditors.XtraForm
    {
        public frm_TinNhan()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint ipe;
        TcpClient tcpclient;
        Stream stream;
        private void TinNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            Send();
        }
        void Connect()
        {
            //IPEndPoint : lớp chứa đựng cả IPAddress và số hiệu cổng

            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            tcpclient = new TcpClient();
            tcpclient.Connect(ipe);
            stream = tcpclient.GetStream();
            Thread recv = new Thread(Receive);
            recv.IsBackground = true;
            recv.Start();
        }
        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
            stream.Write(data, 0, data.Length);
            Addmessage(tbMessage.Text);
        }
        void Receive()
        {
            while (true)
            {

                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage(s);
            }
        }
        void Addmessage(string mess)
        {
            lvMess.Items.Add(mess);
        }
    }
}