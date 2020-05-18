using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comportChat
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            string[] portlar = SerialPort.GetPortNames(); // Bağlı seri portları diziye aktardık
            foreach (string portAdi in portlar)
            {
                crativeport(portAdi);
            }
        }
        SerialPort sp1 = new SerialPort();
        SerialPort sp2 = new SerialPort();
        int n = 0;
        public void crativeport(String a){
            if (n == 0)
            {
                sp1.PortName = a;
                sp1.BaudRate = 19200;
                sp1.DataBits = 8;
                sp1.Parity = Parity.None;
                sp1.StopBits = StopBits.One;
                Console.WriteLine("bağlantı " + a);
                n++;
            }
            else {

                sp2.PortName = a;
                sp2.BaudRate = 19200;
                sp2.DataBits = 8;
                sp2.Parity = Parity.None;
                sp2.StopBits = StopBits.One;
                Console.WriteLine("bağlantı " + a);
                n--;
            }
           
        }
        public String byteConvert(SerialPort s) {

            int bytes = s.BytesToRead;
            byte[] buffer = new byte[bytes];
            s.Read(buffer, 0, bytes);
            return Encoding.ASCII.GetString(buffer);
        }
        private void com1connet_Click(object sender, EventArgs e)
        {      
            getcom1data();
        }
        public void getcom1data()
        {
            sp1.Open();
            sp1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived1);
        }
        private void sp_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            if (com1radioButton.Checked)
            {
                recivercom1.Text += sp1.ReadExisting() + "\n";
            }
            else
            {
                recivercom1.Text += byteConvert(sp1) + "\n";
            }
        }
       
        private void com2connet_Click(object sender, EventArgs e)
        {

            getcom2data();
        }
        public void getcom2data()
        {
            sp2.Open();
            sp2.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived2);
        }
        private void sp_DataReceived2(object sender, SerialDataReceivedEventArgs e)
        {
            if (com1radioButton.Checked)
            {
                recivercom2.Text += sp2.ReadExisting() + "\n"; 
            }
            else {
                recivercom2.Text += byteConvert(sp2) + "\n";
            }
            

        }

        private void com1sendmessage_Click(object sender, EventArgs e)
        {

            if (com1radioButton.Checked)
            {
                sp1.Write(com1text.Text);
            }
            else {
                byte[] bytes = Encoding.ASCII.GetBytes(com1text.Text);
                sp1.Write(bytes, 0, bytes.Length);
            }
        }

        private void com2sendmessage_Click(object sender, EventArgs e)
        {

            if (com1radioButton.Checked)
            {
                sp2.Write(com2text.Text);
            }
            else
            {
                byte[] bytes = Encoding.ASCII.GetBytes(com2text.Text);
                sp2.Write(bytes, 0, bytes.Length);
            }
        }

       
    }
}
