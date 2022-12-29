using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPReceive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient(new IPEndPoint(IPAddress.Any, 7788));//端口要与发送端相同
            Thread thread = new Thread(receiveUdpMsg);//用线程接收，避免UI卡住
            thread.IsBackground = true;
            thread.Start(client);
        }

        void receiveUdpMsg(object obj)
        {
            UdpClient client = obj as UdpClient;
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {

                var bs = client.Receive(ref endpoint);

                var msg = Encoding.ASCII.GetString(bs);
                UpdateMsg(msg);
            }
        }

        void UpdateMsg(string msg)
        {
            BeginInvoke(new Action(() =>
            {
                this.textBox1.Text = msg;
            }));

        }
    }
}
