using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoketProgram
{
    public partial class ClientForm : Form
    {
        TcpClient clientSocket = new TcpClient(); // 소켓
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;
        Thread t_handler;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSendC_Click(object sender, EventArgs e) //메세지보내기
        {
            tbxChatInputC.Focus();
            byte[] buffer = Encoding.Unicode.GetBytes(tbxChatInputC.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            tbxChatInputC.Text = "";

        }
        private void GetMessage() // 메세지 받기
        {
            while (true)
            {
                try
                {
                    stream = clientSocket.GetStream();
                    int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                    byte[] buffer = new byte[BUFFERSIZE];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                    DisplayText(message);
                }
                catch
                {

                }
            }
        }

        private void DisplayText(string text) // Server에 메세지 출력
        {
            if (tbxChatHsC.InvokeRequired)
            {
                tbxChatHsC.BeginInvoke(new MethodInvoker(delegate
                {
                    tbxChatHsC.AppendText(text + Environment.NewLine);
                }));
            }
            else
                try
                {
                    tbxChatHsC.AppendText(text + Environment.NewLine);
                }
                catch
                {

                }
        }
               
        private void tbxChatInputC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터키 눌렀을 때
                BtnSendC_Click(this, e);
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            String ip;
            int port;            

            try
            {
                ip = tbxIpC.Text;
                port = Int32.Parse(tbxPortC.Text);

                
                if (this.tbxnicname.Text == "")
                {
                    MsgBoxHelper.Error("이름을 정해주세요");
                    this.tbxnicname.Focus();
                    return;
                }
                

                clientSocket.Connect(ip, port); // 접속 IP 및 포트
                stream = clientSocket.GetStream();
            }
            catch(FormatException e1)
            {
                MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");

            }
            catch (Exception e2)
            {
                MsgBoxHelper.Error( "서버가 실행중이 아닙니다.");
                Application.Exit();
            }

            

            message = "채팅 서버에 연결 되었습니다.";
            DisplayText(message);           

            byte[] buffer = Encoding.Unicode.GetBytes(this.tbxnicname.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;
            t_handler.Start();
    
        }

        private void TbxPortC_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExitC_Click(object sender, EventArgs e) //나가기버튼 클릭
        {
            byte[] buffer = Encoding.Unicode.GetBytes(tbxnicname.Text + "님이 나갔습니다. $");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            stream.Close();
            //DisplayText("exit");
            clientSocket.Close();
            Close();

        }
    }
}
