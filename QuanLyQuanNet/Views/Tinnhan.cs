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

namespace Quanlyquannet.Views
{
    public partial class frm_Tinnhan : DevExpress.XtraEditors.XtraForm
    {
        public frm_Tinnhan()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint ipe;
        Socket client;
        TcpListener tcplisten;

        private void Tinnhan_Load(object sender, EventArgs e)
        {

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            Send(client);
        }
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Any, 9999);

            tcplisten = new TcpListener(ipe);
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    tcplisten.Start();
                    client = tcplisten.AcceptSocket();
                    Thread rec = new Thread(Receive);
                    rec.IsBackground = true;
                    rec.Start(client);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        void Send(Socket client)
        {   //chuyền chuỗi dữ liệu sang kiểu byte
            byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
            client.Send(data);
            Addmessage(tbMessage.Text);
        }
        void Receive(Object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
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