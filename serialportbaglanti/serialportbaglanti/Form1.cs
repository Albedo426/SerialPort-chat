using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serialportbaglanti
{
    public partial class Form1 : Form
    {
        byte[] rx_buffer = new byte[256];
        int rx_buffer_counter = 0;
        public SerialPort sp1 = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public String byteConvert(SerialPort s)
        {
            int bytes = s.BytesToRead;//gelen byte boyutu
            byte[] buffer = new byte[bytes];//byte dizisi oluştur
            s.Read(buffer, 0, bytes);//veri oku yaz
            MessageBox.Show(buffer[0]+"");
            MessageBox.Show(buffer[1]+"");
            MessageBox.Show(buffer[2]+"");
            byte[] bufferstr = new byte[Convert.ToInt32(buffer[2])-3];//data olan kısım için byte dizisi//
            int j=0;
            for (int i=3;i< Convert.ToInt32(buffer[2])-1; i++) {
                bufferstr[j] = buffer[i];//data olan kısmı yeni byte dizisine atıyoruz
                j++;
            }
            if ((buffer[2]- buffer[buffer[2]-1])/ 13 != 0) {//bozulma olup olmadığı kontrolü//ikide verinin tamamı var tüm boyut sağ kısım da en sonda kalan crc
                MessageBox.Show("veride bozulma var");
            }
            return Encoding.ASCII.GetString(bufferstr);//data return
        }
        private void com1connet(object sender, EventArgs e)
        {
            connet("1");
        }
        public void connet(String s) {
       
            sp1.PortName = "COM"+s;
            sp1.BaudRate = 19200;//ne kadar az olursa veri okadar yavaşlar dalga boyu gibi düşün 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200
            sp1.DataBits = 8;//göndereceğimiz bilginin kaç bitten oluşacağını bildiriyoruz 8,7
            sp1.Parity = Parity.Mark;// alınan verinin doğruluğpu için
            /*
                None =kontrol yok
                Odd = bit sayısını tek bir yapar
                Even = bit sayısını çift bir yapar
            */
            sp1.StopBits = StopBits.One;//bitiş bit'i genelde 1 bit yapılıyor 
            Console.WriteLine("bağlantı com"+s);
            sp1.Open();
            sp1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived1);//listener
        }
        private void com2connet(object sender, EventArgs e)
        {
            connet("2");
        }
        private void sp_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {

           int bytes = sp1.BytesToRead;//gelen byte boyutu
            sp1.Read(rx_buffer, rx_buffer_counter, bytes);//veri oku yaz
                                                          /*int bytes = s.BytesToRead;//gelen byte boyutu
                                                          byte[] buffer = new byte[bytes];//byte dizisi oluştur
                                                          s.Read(buffer, 0, bytes);//veri oku yaz*/


            rx_buffer_counter += bytes;

        }

        private void send_message(object sender, EventArgs e)
        {
            byte[] bytes = crativepacket();
            sp1.Write(bytes, 0, bytes.Length);
        }
        private byte[] crativepacket() {
            byte[] bytes = new byte[textBox1.Text.Length+4];
            bytes[0] = 1;
            bytes[1] = 2;
            bytes[2] = Convert.ToByte(textBox1.Text.Length+4);
            String str = textBox1.Text;

            for(int i=0;i< textBox1.Text.Length;i++)
                bytes[i+3]= (byte)str[i];


            int top=0;
            for (int i = 0; i < textBox1.Text.Length + 3; i++) {
                top += bytes[i];
            }
            bytes[textBox1.Text.Length+3] = Convert.ToByte(top % 127);
            
            return bytes;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rx_buffer_counter > 3 )
            {
                if (rx_buffer_counter >= Convert.ToInt32(rx_buffer[2]))//paket geldi
                {
                    int top = 0;
                    for (int i = 0; i < rx_buffer[2] - 1; i++)
                    {
                        top += rx_buffer[i];
                    }
                    if ((top - rx_buffer[rx_buffer[2] - 1]) % 127 == 0)
                    {
                        byte[] bufferstr = new byte[Convert.ToInt32(rx_buffer[2]) - 4];//data olan kısım için byte dizisi//
                        for (int i = 0; i < Convert.ToInt32(rx_buffer[2]) - 4; i++)
                        {
                            bufferstr[i] = rx_buffer[i + 3];//data olan kısmı yeni byte dizisine atıyoruz
                        }
                        richTextBox1.Text += Encoding.ASCII.GetString(bufferstr) + "\n";
                    }
                    else {
                        MessageBox.Show("hatalı veri geldi");
                    }
                    rx_buffer_counter = 0;

                }



                //byte[] bufferstr = new byte[Convert.ToInt32(rx_buffer[2]) - 3];//data olan kısım için byte dizisi//
                //int j = 0;
                //for (int i = 3; i < Convert.ToInt32(rx_buffer[2]) - 1; i++)
                //{
                //    bufferstr[j] = rx_buffer[i];//data olan kısmı yeni byte dizisine atıyoruz
                //    j++;
                //}
                ///*if ((rx_buffer[2] - rx_buffer[rx_buffer[2] - 1]) % 13 != 0)
                //{//bozulma olup olmadığı kontrolü//ikide verinin tamamı var tüm boyut sağ kısım da en sonda kalan crc
                //    MessageBox.Show("veride bozulma var");
                //}*/
                //richTextBox1.Text += Encoding.ASCII.GetString(bufferstr) + "\n";
                //rx_buffer_counter = 0;
                ///*
                //    richTextBox1.Text += byteConvert(sp1) + "\n";
                //}*/
            }
        }
    }
}
