using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace congcom
{
    public partial class Form1 : Form
    {
        // bo xung/
        // So le hien thi /
        const int LED_1 = 0;
        const int LED_2 = 1;
        const int LED_3 = 2;
        const int LED_MAX = 3;

        // trang thai hien thi cua led /
        const int LED_OFF   = 0;
        const int LED_HS50  = 1;
        const int LED_HS75  = 2;
        const int LED_HS100 = 3;
        const int LED_HSMAX = 4;

        //Tong so cong com /
        int g_nLenghPort = 0; 

        //Mang nhan data tu kit gui cho PC/
        int[] g_nArrLed = new int[LED_MAX];

        //Mang chua image de hien thi led/
        Image[] g_Img = new Image[LED_HSMAX];

        // Khi chuong trinh khoi dong thi goi ham nay/
        public Form1()
        {
            //Ham nay se khoi tao cac control tren form/
            InitializeComponent();

            //Kiem tra cac image co trong thu muc chay ung ko?/
            if (!File.Exists("OFF.png") || 
                !File.Exists("ON50.png") || 
                !File.Exists("ON75.png") || 
                !File.Exists("ON100.png")
                )
            {
                //Truong hop ko tim thay image thi no se lam cac viec ben duoi/

                string message = "Not found image. Please coppy image into folder of congcom.exe\n ";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Hien thi cai thong cho nguoi dung biet la image ko ton tai/
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Neu user nhan vao nut Yes thi se close application/
                    this.Close();
                }
            }
            else 
            {
                //Khoi tao viec load cac image vao mang g_Img[]/
                g_Img[LED_OFF] = Image.FromFile("OFF.png");
                g_Img[LED_HS50] = Image.FromFile("ON50.png");
                g_Img[LED_HS75] = Image.FromFile("ON75.png");
                g_Img[LED_HS100] = Image.FromFile("ON100.png");
            }
        }

        // Ham nay lam timer de tu dong cap nhat cong COM/
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Lay tat ca cac cong COM/
            string[] strPorts = SerialPort.GetPortNames();
            //Lay tat ca cac cong COM/
            //strPorts.Length la so port tim thay/
            if (g_nLenghPort != strPorts.Length)
            {
                g_nLenghPort = strPorts.Length;
                cbb_Select_Com.Items.Clear();
                for (int j = 0; j < g_nLenghPort; j++)
                {
                    //Add tung Port de hien thi/
                    cbb_Select_Com.Items.Add(strPorts[j]);
                }
            }
        }

        //ham nhan connect/
        private void bt_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_Status.Text == "Disconnect")
                {
                    Com.PortName = cbb_Select_Com.Text;
                    Com.Open();
                    lb_Status.Text = "Connect";
                    bt_Connect.Text = "Disconnect";
                }
                else
                {
                    Com.Close();
                    lb_Status.Text = "Disconnect";
                    bt_Connect.Text = "Connect";

                    // Xu ly xoa image cua LED 1 /
                    LED1.Image.Dispose();
                    LED1.Image = null;

                    // Xu ly xoa image cua LED 2 /
                    LED2.Image.Dispose();
                    LED2.Image = null;

                    // Xu ly xoa image cua LED 3 /
                    LED3.Image.Dispose();
                    LED3.Image = null;

                }
            }
            catch
            {
                //Truong hop ko co chon bat ky cong COM nao/
                string message = "Please selecct COM";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //Hien thi thong bao chua chon cong COM/
                result = MessageBox.Show(message, caption, buttons);
            }

        }

        private void OnCom(object sender, SerialDataReceivedEventArgs e)
        {
            //Khoi tao bien sReData/
            string sReData = "0000";

            //Doc tat ca du lieu trong buff com/
            sReData = Com.ReadExisting();
            
            //Call ham hien thi LED/
            Display(sReData);
        }

        private delegate void DlDisplay(string sReceiveData);

        // ---------- Receive Data ---------------/
        private void Display(string sReceiveData)
        {

            if (txt_Receive_Data.InvokeRequired)
            {
                DlDisplay sd = new DlDisplay(Display);
                txt_Receive_Data.Invoke(sd, new object[] { sReceiveData });

            }
            else
            {
                //------- Print data from kit------/
                txt_Receive_Data.Text = sReceiveData;

                //------- Kiem tra do dai chuoi nhan duoc------/ 
                if (sReceiveData.Length != LED_MAX)
                {
                    return;
                }

                //------- Convert data of KIT to data array ------/ 
                for (int i = LED_1; i < LED_MAX; i++)
                {
                    g_nArrLed[i] = Int32.Parse(sReceiveData.Substring(i /*Position start*/, 1 /* so ky tu cat */));
                }

                //----- Hien thi LED 1 ----/
                switch (g_nArrLed[LED_1])
                {
                    case LED_OFF:
                        LED1.Image = g_Img[LED_OFF];
                        break;
                    case LED_HS50:
                        LED1.Image = g_Img[LED_HS50];
                        break;
                    case LED_HS75:
                        LED1.Image = g_Img[LED_HS75];
                        break;
                    case LED_HS100:
                        LED1.Image = g_Img[LED_HS100];
                        break;
                    default:
                        // Xu ly xoa image cua LED 1 /
                        LED1.Image.Dispose();
                        LED1.Image = null;
                        break;
                }

                //----- Hien thi LED 2 ----/
                switch (g_nArrLed[LED_2])
                {
                    case LED_OFF:
                        LED2.Image = g_Img[LED_OFF];
                        break;
                    case LED_HS50:
                        LED2.Image = g_Img[LED_HS50];
                        break;
                    case LED_HS75:
                        LED2.Image = g_Img[LED_HS75];
                        break;
                    case LED_HS100:
                        LED2.Image = g_Img[LED_HS100];
                        break;
                    default:
                        // Xu ly xoa image cua LED 2 /
                        LED2.Image.Dispose();
                        LED2.Image = null;
                        break;

                }

                //----- Hien thi LED 3 ----/
                switch (g_nArrLed[LED_3])
                {
                    case LED_OFF:
                        LED3.Image = g_Img[LED_OFF];
                        break;
                    case LED_HS50:
                        LED3.Image = g_Img[LED_HS50];
                        break;
                    case LED_HS75:
                        LED3.Image = g_Img[LED_HS75];
                        break;
                    case LED_HS100:
                        LED3.Image = g_Img[LED_HS100];
                        break;
                    default:
                        // Xu ly xoa image cua LED 3 /
                        LED3.Image.Dispose();
                        LED3.Image = null;
                        break;

                }
            }
        }
    }
}
