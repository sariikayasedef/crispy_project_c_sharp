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


namespace Crispy_Project
{
    public partial class Main : Form
    {
        public bool sari_durum = false;
        public bool kirmizi_durum = false;
        public bool rgb_r_durum = false;
        public bool rgb_g_durum = false;
        public bool rgb_b_durum = false;
       
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            
            foreach (string portAdi in SerialPort.GetPortNames())
            {
                comboBox2.Items.Add(portAdi);
            }
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp= serialPort1.ReadExisting();
            byte[] read_bytes = Encoding.ASCII.GetBytes(temp);
            if(read_bytes.Length == 15)
            {                           
                if (read_bytes[0] == 0x7E && read_bytes[14] ==0xEE) { 
                    if(read_bytes[1] == 0x10)
                    {
                        richTextBox1.Text = ">Pot: \"" + Convert.ToString((read_bytes[1]<<8)|(read_bytes[2])) + "\"\n";
                    }
                    if (read_bytes[4] == 0x11)
                    {
                        richTextBox1.Text = ">Sıcaklık: \"" + Convert.ToString((read_bytes[4] << 8) | (read_bytes[5])) + "\"\n";
                    }
                    if (read_bytes[7] == 0x12)
                    {
                        richTextBox1.Text = ">Ldr: \"" + Convert.ToString((read_bytes[8] << 8) | (read_bytes[9])) + "\"\n";
                    }
                    if(read_bytes[10] == 0x01)
                    {                 
                        Btn_aktif.ForeColor = Color.Black;
                        Btn_aktif.BackColor = System.Drawing.SystemColors.Control;
                    }
                }
            }
        }
        private void btnLks_Click(object sender, EventArgs e)
        {
            if (!sari_durum)
            {
                byte[] val = new byte[1] { 0x00 };
                serialPort1.Write(val, 0, 1);
                sari_durum = true;
                btnLks.ForeColor = Color.White;
                btnLks.BackColor = Color.Yellow;
            }
            else
            {
                byte[] val = new byte[1] { 0x01 };
                serialPort1.Write(val, 0, 1);
                sari_durum = false;
                btnLks.ForeColor = Color.Black;
                btnLks.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnLkk_Click(object sender, EventArgs e)
        {
            if (!kirmizi_durum)
            {
                byte[] val = new byte[1] { 0x02 };
                serialPort1.Write(val, 0, 1);
                kirmizi_durum = true;
                btnLkk.ForeColor = Color.White;
                btnLkk.BackColor = Color.Red;
            }
            else
            {
                byte[] val = new byte[1] { 0x03 };
                serialPort1.Write(val, 0, 1);
                kirmizi_durum = false;
                btnLkk.ForeColor = Color.Black;
                btnLkk.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnRgbk_Click(object sender, EventArgs e)
        {
            if (!rgb_r_durum)
            {
                byte[] val = new byte[1] { 0x06 };
                serialPort1.Write(val, 0, 1);
                rgb_r_durum = true;
                btnRgbk.ForeColor = Color.White;
                btnRgbk.BackColor = Color.Green;
            }
            else
            {
                byte[] val = new byte[1] { 0x07 };
                serialPort1.Write(val, 0, 1);
                rgb_r_durum = false;
                btnRgbk.ForeColor = Color.Black;
                btnRgbk.BackColor = System.Drawing.SystemColors.Control;
            }
           

        }

        private void btnRgby_Click(object sender, EventArgs e)
        {
            if (!rgb_g_durum)
            {
                byte[] val = new byte[1] { 0x04 };
                serialPort1.Write(val, 0, 1);
                rgb_g_durum = true;
                btnRgby.ForeColor = Color.White;
                btnRgby.BackColor = Color.Red;
            }
            else
            {
                byte[] val = new byte[1] { 0x05 };
                serialPort1.Write(val, 0, 1);
                rgb_g_durum = false;
                btnRgby.ForeColor = Color.Black;
                btnRgby.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnRgbm_Click(object sender, EventArgs e)
        {
            if (!rgb_b_durum)
            {
                byte[] val = new byte[1] { 0x08 };
                serialPort1.Write(val, 0, 1);
                rgb_b_durum = true;
                btnRgbm.ForeColor = Color.White;
                btnRgbm.BackColor = Color.Blue;
            }
            else
            {
                byte[] val = new byte[1] { 0x09 };
                serialPort1.Write(val, 0, 1);
                rgb_b_durum = false;
                btnRgbm.ForeColor = Color.Black;
                btnRgbm.BackColor = System.Drawing.SystemColors.Control;
            }
        }
        private void btnBuzzer_Click(object sender, EventArgs e)
        {
            byte[] val = new byte[1] { 0x0A };
            serialPort1.Write(val, 0, 1);
            btnBuzzer.ForeColor = Color.White;
            btnBuzzer.BackColor = Color.DarkGray;
            System.Threading.Thread.Sleep(20);
            btnBuzzer.ForeColor = Color.Black;
            btnBuzzer.BackColor = System.Drawing.SystemColors.Control;

        }
        private void btnCon_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            serialPort1.PortName = comboBox2.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox1.Text);
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
            serialPort1.Open();
            
            MessageBox.Show("BAĞLANTI KURULDU");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen ==false)
            {
                serialPort1.Open();
            }
            serialPort1.Close();
            MessageBox.Show("BAĞLANTI KOPTU");
        }

        private void Btn_sicaklik_Click(object sender, EventArgs e)
        {
            byte[] val = new byte[1] { 0x0C };
            serialPort1.Write(val, 0, 1);
            Btn_sicaklik.ForeColor = Color.White;
            Btn_sicaklik.BackColor = Color.DarkGray;
        }

        private void Btn_pot_Click(object sender, EventArgs e)
        {
            byte[] val = new byte[1] { 0x0B };
            serialPort1.Write(val, 0, 1);
            Btn_pot.ForeColor = Color.White;
            Btn_pot.BackColor = Color.DarkGray;

        }

        private void Btn_ldr_Click(object sender, EventArgs e)
        {
            byte[] val = new byte[1] { 0x0D };
            serialPort1.Write(val, 0, 1);
            Btn_ldr.ForeColor = Color.White;
            Btn_ldr.BackColor = Color.DarkGray;
            
        }

        private void Btn_aktif_Click(object sender, EventArgs e)
        {
            byte[] val = new byte[1] { 0x0E };
            serialPort1.Write(val, 0, 1);
            Btn_aktif.ForeColor = Color.White;
            Btn_aktif.BackColor = Color.DarkGray;
        }
    }
}
