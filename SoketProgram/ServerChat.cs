

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SoketProgram
{
    public partial class ServerForm : Form
    {
        TcpListener server = null; // 서버
        TcpClient clientSocket = null; // 소켓
        static int counter = 0; // 사용자 수
       // string date; // 날짜 
        // 각 클라이언트 마다 리스트에 추가
        public  Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();
        int port;
        IPAddress thisAddress;
        public ServerForm()
        {
            InitializeComponent();            
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, port); // 서버 접속 IP, 포트
            clientSocket = default(TcpClient); // 소켓 설정
            server.Start(); // 서버 시작

            DisplayText(">> Server Started");
            //DisplayText(IPAddress.Any.ToString());

            while (true)
            {

                try
                {
                    counter++; // Client 수 증가
                    clientSocket = server.AcceptTcpClient(); // client 소켓 접속 허용       
                    

                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024]; // 버퍼
                    int bytes = stream.Read(buffer, 0, buffer.Length);

                    string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                    user_name = user_name.Substring(0, user_name.IndexOf("$")); // client 사용자 명

                    DisplayText(">> " +user_name+"님이 접속하였습니다");
                    clientList.Add(clientSocket, user_name); // cleint 리스트에 추가

                    SendMessageAll(user_name + " 님이 입장하셨습니다.", "", false); // 모든 client에게 메세지 전송
   
                    handleClient h_client = new handleClient(); // 클라이언트 추가
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                    h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
                    h_client.startClient(clientSocket, clientList);

                }

                catch (SocketException se) { break; }
                catch (Exception ex) { break; }

            }
            if(clientSocket != null) clientSocket.Close(); // client 소켓 닫기
            DisplayText(">>Server End");
            server.Stop(); // 서버 종료

        }

        void h_client_OnDisconnected(TcpClient clientSocket) // cleint 접속 해제 핸들러
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }

        
        private void OnReceived(string message, string user_name) // cleint로 부터 받은 데이터
        {
            if (message.Equals("exit"))
            {
                string displayMessage = "exit user : " + user_name;
                DisplayText(displayMessage);
                SendMessageAll("exit", user_name, true);
            }
            else
            {
                string displayMessage = "From client : " + user_name + " : " + message;
                DisplayText(displayMessage); // Server단에 출력
                SendMessageAll(message, user_name, true); // 모든 Client에게 전송
            }

        }
               
        public void SendMessageAll(string message, string user_name, bool flag)
        {
            foreach (var pair in clientList) //접속한 클라이언트 받아오기
            {
                              
                TcpClient client = pair.Key as TcpClient; 
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                        buffer = Encoding.Unicode.GetBytes(user_name + " : " + message);
                                    }
                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }
                stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                stream.Flush();

            }

        }

        private void DisplayText(string text) // Server 화면에 출력
        {
            if (tbxChatHsS.InvokeRequired)
            {
                tbxChatHsS.BeginInvoke(new MethodInvoker(delegate
                {
                    tbxChatHsS.AppendText(text + Environment.NewLine);
                }));

            }
            else
                tbxChatHsS.AppendText(text + Environment.NewLine);

        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            // 처음으로 발견되는 ipv4 주소를 사용한다.
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }

            // 주소가 없다면..
            if (thisAddress == null)
                // 로컬호스트 주소를 사용한다.
                thisAddress = IPAddress.Loopback;
            tbxIpS.Text = thisAddress.ToString();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxPortS.Text, out port))
            {
                MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                tbxPortS.Focus();
                tbxPortS.SelectAll();
                return;
            }
            port = Int32.Parse( tbxPortS.Text);
            
            // 쓰레드 생성
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();

        }  

        private void BtnEnd_Click(object sender, EventArgs e)
        {

            server.Stop();
        }

    }

}
