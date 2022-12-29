using nsname;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient(new IPEndPoint(IPAddress.Any, 0));

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Broadcast, 7788);//默认向全世界所有主机发送即可，路由器自动给你过滤，只发给局域网主机

            var bs = Encoding.ASCII.GetBytes("i am zhangxuan 1107");
            client.Send(bs, bs.Length, endpoint);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wcf_THREE_CODE_COMPARISON wcf_THREE_CODE = new Wcf_THREE_CODE_COMPARISON();
            var result=wcf_THREE_CODE.ThreeCodeComparisonTest("");
        }
    }
}
