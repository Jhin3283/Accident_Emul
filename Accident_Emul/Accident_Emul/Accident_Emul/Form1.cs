using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
//using WatsonTcp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SuperSimpleTcp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Accident_Emul
{
    public partial class Form1 : Form
    {

        SimpleTcpClient m_Client;// = new SimpleTcpClient("192.168.219.146:7000");

        string port;
        public float m_HeelAngle, m_RollPeriod, m_RollAmplitudePort, m_RollAmplitudeStbd;

        /*static class ship_status
        {
            public double m_heel_Angle;  // degrees, "-" = port
            public double m_roll_period; // seconds
            public double m_RATP;  // Roll amplitude to port (degrees)
            public double m_RATS;  // Roll amplitude to starboard (degrees)
        }*/

        public class flood_status
        {
            string level_pos;  // UPPER Or LOWER
            bool flooded; // true면 1 False면 2
        }
        SimpleTcpServer m_Server;
        //WatsonTcpClient m_Client;

        public Form1()
        {
            InitializeComponent();
            InitNetwork();
            CheckForIllegalCrossThreadCalls = false;  //크로스 스레드 에러가 발생 해결

            
        }

        static void Connected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"*** Server {e.IpPort} connected");
        }

        static void Disconnected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"*** Server {e.IpPort} disconnected");
        }

        static void DataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine($"[{e.IpPort}] {Encoding.UTF8.GetString(e.Data)}");
        }

        void InitNetwork()
        {
            //m_Server = new SimpleTcpServer("112.218.175.109", 7000);
            m_Server = new SimpleTcpServer("127.0.0.1", 5000);
            m_Server.Events.ClientConnected += ClientConnected;
            m_Server.Events.ClientDisconnected += ClientDisconnected;
            m_Server.Events.DataReceived += ClientMessageReceived;
            m_Server.Start();
            tbServerStatus.Text = "Server Start!" ;

            Thread.Sleep(1000);

            //m_Client = new SimpleTcpClient("192.168.219.146:7000");
            //m_Client = new SimpleTcpClient("127.0.0.1:5000");

            //m_Client.Events.Connected += Connected;
            //m_Client.Events.Disconnected += Disconnected;
            //m_Client.Events.DataReceived += DataReceived;

            //m_Client.Connect();
        }
        void ClientConnected(object sender, ConnectionEventArgs args)
        {
            tbServerStatus.Text = "Client connected: " + args.IpPort;
            port = args.IpPort;

        }

        void ClientDisconnected(object sender, ConnectionEventArgs args)
        {
            tbServerStatus.Text = "Client disconnected: " + args.IpPort + ": " + args.Reason.ToString();
        }

        void ClientMessageReceived(object sender, DataReceivedEventArgs args)
        {
            if(chkHexa.Checked)
            {
                tbServerStatus.Text = BitConverter.ToString(args.Data);
            }
            else
            {
                tbServerStatus.Text = "Message from " + args.IpPort + ": \r\n" + Encoding.UTF8.GetString(args.Data);
            }
            
        }


        //void ServerMessageReceived(object sender, MessageReceivedEventArgs args)
        //{
        //    tbClientStatus.Text = "Message from " + args.IpPort + ": \r\n" + Encoding.UTF8.GetString(args.Data);
        //}

        ////void ServerConnected(object sender, ConnectionEventArgs args)
        ////{
        ////    tbClientStatus.Text = "Server " + args.IpPort + " connected";
        ////}

        //void ServerDisconnected(object sender, DisconnectionEventArgs args)
        //{
        //    tbServerStatus.Text = "Server " + args.IpPort + " disconnected";
        //}

        private void btnSendFloodData_Click(object sender, EventArgs e)
        {
            //if(timerSendFloodData.Enabled == false)
            //    timerSendFloodData.Enabled = true;
            //else
            //    timerSendFloodData.Enabled = false;
            //Random randomObj = new Random();


            //string token = string.Format("AccidentLevel, {0}\r\n", randomObj.Next(4));
            //m_Server.Send(port, token);

            m_Server.Send(port, "34.0559, 129.0559, 92.7, 10kts, 3.5km");

        }
        public string GetHRM()
        {
            //TimeSpan tz = new TimeSpan(0, 9, 0, 0);

            //curTime -= tz;

            //double 
            //TimeSpan tz = new TimeSpan(0, 9, 0, 0);

            //curTime -= tz;

            //double 
            //double HA = Math.Round(double.Parse(tbHa.Text),1);
            //double RP = Math.Round(double.Parse(tbRP.Text),1);
            //double RAP = Math.Round(double.Parse(tbRap.Text),1);
            //double RAS = Math.Round(double.Parse(tbRasb.Text),1);
            m_HeelAngle = float.Parse(tbHeelAngle.Text);
            m_RollPeriod = float.Parse(tbRollPeriod.Text);
            m_RollAmplitudePort = float.Parse(tbRollAmplitudePort.Text);
            m_RollAmplitudeStbd = float.Parse(tbRollAmplitudeStbd.Text);

            string SDV;
            //bool DV = DataValid.Checked;
            //string SDV = Convert.ToString(DV);
            //if (DV == true)
            //{
            //    SDV = 'A';

            //};

            if (DataValid.Checked == true)
                SDV = "A";
            else
            {
                SDV = "V";
            }

            string m_strICHRM = "{$ICHRM, 10.2,1.5,40.2,20.2,A*hh<CR><LF>}";

            m_strICHRM = String.Format("$ICHRM,{0:F1},{1:F1},{2:F1},{3:F1},{4}*hh<CR><LF>", m_HeelAngle, m_RollPeriod, m_RollAmplitudePort, m_RollAmplitudeStbd, SDV);

            //JObject jObject = JObject.Parse("{ICHRM: {m_strICHRM}}");
            //Console.WriteLine(jObject.ToString());
            //JObject json = JObject.Parse(m_strICHRM);
            //Console.Write(json);
            return AddCheckSum(m_strICHRM);
        }

        public string GetUpper()
        {
            string m_strPDIND = "{$PDIND,UPPER,1,1,1,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1}";

            m_strPDIND = String.Format("$PDIND,Upper,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},1,1,1,1,1,1,1,1,1,1", 
                                upper1.Checked ? "1" : "0",
                                upper2.Checked ? "1" : "0",
                                upper3.Checked ? "1" : "0",
                                upper4.Checked ? "1" : "0",
                                upper5.Checked ? "1" : "0",
                                upper6.Checked ? "1" : "0",
                                upper7.Checked ? "1" : "0",
                                upper8.Checked ? "1" : "0",
                                upper9.Checked ? "1" : "0",
                                upper10.Checked ? "1" : "0");

            //JObject jObject = JObject.Parse("{PDIND: {m_strPDIND}}");
            //Console.WriteLine(jObject.ToString());
            //JObject json = JObject.Parse(m_strICHRM);
            //Console.Write(json);
            return AddCheckSum(m_strPDIND);
        }
        public string GetLower()
        {
            string m_strPDIND = "{$PDIND,Lower,1,1,1,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1}";

            m_strPDIND = String.Format("$PDIND,Lower,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},1,1,1,1,1,1,1,1,1,1",
                                lower1.Checked ? "1" : "0",
                                lower2.Checked ? "1" : "0",
                                lower3.Checked ? "1" : "0",
                                lower4.Checked ? "1" : "0",
                                lower5.Checked ? "1" : "0",
                                lower6.Checked ? "1" : "0",
                                lower7.Checked ? "1" : "0",
                                lower8.Checked ? "1" : "0",
                                lower9.Checked ? "1" : "0",
                                lower10.Checked ? "1" : "0");

            //JObject jObject = JObject.Parse("{PDIND: {m_strPDIND}}");
            //Console.WriteLine(jObject.ToString());
            //JObject json = JObject.Parse(m_strICHRM);
            //Console.Write(json);
            return AddCheckSum(m_strPDIND);
        }

        byte GetCheckSum(string sentence)
        {
            byte checksum_value = 0;

            int string_length = sentence.Length;
            int index = 1; // Skip over the $ at the begining of the sentence

            while (index < string_length &&
                   sentence[index] != '*' &&
                   sentence[index] != '\r' &&
                   sentence[index] != '\n')
            {
                checksum_value ^= (byte)sentence[index];
                index++;
            }

            return checksum_value;
        }

        string AddCheckSum(string token)
        {
            byte checksum_value = GetCheckSum(token);

            string chksum;

            chksum = String.Format("*{0:X2}\r\n", checksum_value);
            token += chksum;

            return token;
        }


        /// <summary>
        /// /////////////

        // json 형식

        //{
        //	“Roll”:{
        // 		“Heel_Angle”:”21.9”,
        // 		“Roll_Period”:”21.9”,
        // 		“Roll_Amplitude_Port”:”21.9”,
        // 		“Roll_Amplitude_Stbd”:”21.9”
        //	},
        //	“Upper”:[
        //      “Upper1”:”0”,
        //      “Upper2”:”0”,
        //      “Upper3”:”0”,
        //      “Upper4”:”0”,
        //      “Upper5”:”1”,
        //      “Upper6”:”1”,
        //      “Upper7”:”1”,
        //      “Upper8”:”1”,
        //      “Upper9”:”1”,
        //      “Upper10”:”1”
        //  ],
        //	“Lower”:[
        //      "Lower1”:”0”,
        //      “Lower2”:”1”,
        //      “Lower3”:”1”,
        //      “Lower4”:”1”,
        //      “Lower5”:”0”,
        //      “Lower6”:”0”,
        //      “Lower7”:”0”,
        //      “Lower8”:”1”,
        //      “Lower9”:”1”,
        //      “Lower10”:”0”
        //  ]
        //}


        /// </summary>


        private void timerSendRollData_Tick(object sender, EventArgs e)
        {
            Random randomObj = new Random();

            string token = string.Format("{{\"Roll\":{{\"Heel_Angle\": \"{0:F1}\", " +
                "\"Roll_Period\":\"{1:F1}\", " +
                "\"Roll_Amplitude_Port\":\"{2:F1}\", " +
                "\"Roll_Amplitude_Stbd\":\"{3:F1}\"}}," +
                "\"Upper\":[\"Upper1\":\"{4}\"," +
                "\"Upper2\":\"{5}\",\"Upper3\":\"{6}\",\"Upper4\":\"{7}\",\"Upper5\":\"{8}\",\"Upper6\":\"{9}\",\"Upper7\":\"{10}\",\"Upper8\":\"{11}\",\"Upper9\":\"{12}\",\"Upper10\":\"{13}\"]," +
                "\"Lower\":[\"Lower1\":\"{14}\", " +
                "\"Lower2\":\"{15}\",\"Lower3\":\"{16}\",\"Lower4\":\"{17}\",\"Lower5\":\"{18}\",\"Lower6\":\"{19}\",\"Lower7\":\"{20}\",\"Lower8\":\"{21}\",\"Lower9\":\"{22}\",\"Lower10\":\"{23}\"]}}",
                                randomObj.NextDouble() * 30.0, randomObj.NextDouble() * 20.0,
                                randomObj.NextDouble() * 10.0, randomObj.NextDouble() * 10.0,
                                upper1.Checked ? "1" : "0",
                                upper2.Checked ? "1" : "0",
                                upper3.Checked ? "1" : "0",
                                upper4.Checked ? "1" : "0",
                                upper5.Checked ? "1" : "0",
                                upper6.Checked ? "1" : "0",
                                upper7.Checked ? "1" : "0",
                                upper8.Checked ? "1" : "0",
                                upper9.Checked ? "1" : "0",
                                upper10.Checked ? "1" : "0",
                                lower1.Checked ? "1" : "0",
                                lower2.Checked ? "1" : "0",
                                lower3.Checked ? "1" : "0",
                                lower4.Checked ? "1" : "0",
                                lower5.Checked ? "1" : "0",
                                lower6.Checked ? "1" : "0",
                                lower7.Checked ? "1" : "0",
                                lower8.Checked ? "1" : "0",
                                lower9.Checked ? "1" : "0",
                                lower10.Checked ? "1" : "0");

            m_Client.Send(token);
        }

        private void timerSendFloodData_Tick(object sender, EventArgs e)
        {
            string token = string.Format("Upper, {0}, {1}, {2}, {3},{4}, {5}, {6}, {7}, {8}, {9}\r\nLower, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}\r\n ",
                            upper1.Checked ? "1":"0",
                            upper2.Checked ? "1" : "0",
                            upper3.Checked ? "1" : "0",
                            upper4.Checked ? "1" : "0",
                            upper5.Checked ? "1" : "0",
                            upper6.Checked ? "1" : "0",
                            upper7.Checked ? "1" : "0",
                            upper8.Checked ? "1" : "0",
                            upper9.Checked ? "1" : "0",
                            upper10.Checked ? "1" : "0",
                            lower1.Checked ? "1" : "0",
                            lower2.Checked ? "1" : "0",
                            lower3.Checked ? "1" : "0",
                            lower4.Checked ? "1" : "0",
                            lower5.Checked ? "1" : "0",
                            lower6.Checked ? "1" : "0",
                            lower7.Checked ? "1" : "0",
                            lower8.Checked ? "1" : "0",
                            lower9.Checked ? "1" : "0",
                            lower10.Checked ? "1" : "0");
            
            m_Client.Send(token);
        }

        private void btnSendHeelData_Click(object sender, EventArgs e)
        {
            //float heel = float.Parse(tbHeelAngle.Text);
            string token = string.Format("{0}/\r\n{1}/\r\n{2}",
                            GetHRM(), GetUpper(),GetLower()
                            );
            //tbServerStatus.Text = token;
            string[] Text = token.Split('/');
            tbHRM.Text = Text[0].Trim();
            tbINDUpper.Text = Text[1].Trim();
            tbINDLower.Text = Text[2].Trim();
            m_Server.Send(port, token);

        }

        private void btnSendRollData_Click(object sender, EventArgs e)
        {
            if (timerSendRollData.Enabled == false)
            {
                timerSendRollData.Enabled = true;
                btnSendRollData.Text = "멈추기";
            }
                
            else
            {
                timerSendRollData.Enabled = false;
                btnSendRollData.Text = "데이타 보내기";
            }
                

            //timerSendRollData.Enabled = true;

           
        }
        
        private void btnConnectClient_Click(object sender, EventArgs e)  // 파일 전송으로 바꿔야함
        {
            //m_Client.Send("tttt");

            ////m_Client = new WatsonTcpClient("118.38.20.105", 7000);
            ////m_Client = new WatsonTcpClient("192.168.219.167", 7000);
            //m_Client = new WatsonTcpClient("192.168.219.146", 7000);
            //m_Client.Events.ServerConnected += ServerConnected;
            //m_Client.Events.ServerDisconnected += ServerDisconnected;
            //m_Client.Events.MessageReceived += ServerMessageReceived;
            //m_Client.Connect();
            //m_Client.Send(DateTime.Now.ToString());

            //SendFile();
            string token = string.Format("{0}", tbXML.Text);  // 맨 앞의 숫자 1은 XML 2는 2차충돌방지 메세지

            m_Server.Send(port, token);

        }

        private void btnSendNMEA_Click(object sender, EventArgs e)
        {
            m_Client.Send(tbHRM.Text + "\r\n" + tbINDUpper.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string token = "$ICHRM,-2.3,10.2,1.5,3.2,V*hh<CR><LF>*3D/\r\n $PDIND,Upper,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1*39/\r\n $PDIND,Lower,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1*38";
            string[] Text = token.Split('/');
            tbHRM.Text = Text[0].Trim();
            tbINDUpper.Text = Text[1].Trim();
            tbINDLower.Text = Text[2].Trim();
            m_Server.Send(port, token);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string token = "$ICHRM,3.9,12.2,1.8,3.5,V*hh<CR><LF>*13/\r\n $PDIND,Upper,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1*39/\r\n $PDIND,Lower,1,0,1,1,0,1,0,1,0,0,1,1,1,1,1,1,1,1,1,1*39";
            string[] Text = token.Split('/');
            tbHRM.Text = Text[0].Trim();
            tbINDUpper.Text = Text[1].Trim();
            tbINDLower.Text = Text[2].Trim();
            m_Server.Send(port, token);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string token = "$ICHRM,10.5,15.8,2.8,5.5,V*hh<CR><LF>*25/\r\n $PDIND,Upper,0,0,0,0,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1*38/\r\n $PDIND,Lower,1,0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1*38";
            string[] Text = token.Split('/');
            tbHRM.Text = Text[0].Trim();
            tbINDUpper.Text = Text[1].Trim();
            tbINDLower.Text = Text[2].Trim();
            m_Server.Send(port, token);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string token = "$ICHRM,20.5,15.5,2.5,5.0,V*hh<CR><LF>*23/\r\n $PDIND,Upper,1,0,0,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1*39/\r\n $PDIND,Lower,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1*38";
            string[] Text = token.Split('/');
            tbHRM.Text = Text[0].Trim();
            tbINDUpper.Text = Text[1].Trim();
            tbINDLower.Text = Text[2].Trim();
            m_Server.Send(port, token);
        }

        void SendFile()
        {
            string filePath = "d:\\1_log.txt";
            FileInfo fi = new FileInfo(filePath);
            byte[] fileNameSize = BitConverter.GetBytes(fi.Name.Length);                    //파일 이름의 사이즈
            byte[] fileName = Encoding.UTF8.GetBytes(fi.Name);                              //파일 이름
            byte[] fileSizeRealSize = File.ReadAllBytes(filePath);                          //파일 크기
            byte[] file = BitConverter.GetBytes(fileSizeRealSize.Length);                   //파일
            byte[] sendBuffer = new byte[fileName.Length + fileNameSize.Length + file.Length + fileSizeRealSize.Length];

            Buffer.BlockCopy(fileNameSize, 0, sendBuffer, 0, fileNameSize.Length);
            Buffer.BlockCopy(fileName, 0, sendBuffer, fileNameSize.Length, fileName.Length);
            Buffer.BlockCopy(file, 0, sendBuffer, fileNameSize.Length + fileName.Length, file.Length);
            Buffer.BlockCopy(fileSizeRealSize, 0, sendBuffer, fileNameSize.Length + fileName.Length + file.Length, fileSizeRealSize.Length);

            byte[] temp = new byte[30000];
            int fullCount = sendBuffer.Length / 30000;
            int count = 0;
            //label4.Text = "송신중";
            //label4.Update();
            //if (fullCount != 0)
            //{
            //    persent = (count * 100) / fullCount;
            //    label5.Text = persent + "%";
            //    label5.Update();
            //}
            //else
            //{
            //    label5.Text = 100 + "%";
            //    label5.Update();
            //}
            while (sendBuffer.Length > 30000) //크면 나눠서 전송
            {
                count++;
                //persent = (count * 100) / fullCount;
                //label5.Text = persent + "%";
                //label5.Update();
                Buffer.BlockCopy(sendBuffer, 0, temp, 0, temp.Length);
                sendBuffer = ByteMove(sendBuffer, temp.Length, sendBuffer.Length - temp.Length);
                m_Client.Send(temp);
            }


            m_Client.Send(sendBuffer);

            
            //label4.Text = "대기";
            //label4.Update();

        }

        private byte[] ByteMove(byte[] afterByte, int movePoint, int moveCount)
        {
            byte[] resultByte = new byte[moveCount];
            Buffer.BlockCopy(afterByte, movePoint, resultByte, 0, moveCount);
            return resultByte;
        }
    }
}