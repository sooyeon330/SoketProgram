using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoketProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnServer_Click(object sender, EventArgs e)
        {
            ShowServerChat();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            ShowClientChat();
        }

        private static void ShowClientChat()
        {
            ClientChat cf = new ClientChat();
            cf.Show();
        }

        private static void ShowServerChat()
        {
            ServerChat sf = new ServerChat();
            sf.Show();
        }

    }
}
