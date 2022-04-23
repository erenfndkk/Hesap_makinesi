using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        // en fazla 2 sayıyla işlem yapabilen hesap makinesi
        char _islem;
        bool _ekrantemizlenecekmi;
        int ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3 tuşu
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // esittir tusu
            int ikincisayi = Convert.ToInt32(label1_ekran.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            label1_ekran.Text=Convert.ToString(sonuc);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text=="0") label1_ekran.Text="";
            label1_ekran.Text += "1";
        }

        private void button2Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "2";
        }

        private void button4Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "4";
        }

        private void button5Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "5";
        }

        private void button6Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "6";
        }

        private void button7Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "7";
        }

        private void button8Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "8";
        }

        private void button9Rakam_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "9";
        }

        private void button10_clear_Click(object sender, EventArgs e)
        {
            label1_ekran.Text = "0";
        }

        private void button11_0_Rakamı_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1_ekran.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1_ekran.Text == "0") label1_ekran.Text = "";
            label1_ekran.Text += "0";
        }

        private void button13_toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            ilksayi = Convert.ToInt32(label1_ekran.Text);
            
        }

        private void button14_cikarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            ilksayi = Convert.ToInt32(label1_ekran.Text);
        }

        private void button15_carpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            ilksayi = Convert.ToInt32(label1_ekran.Text);
        }

        private void button16_bolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            ilksayi = Convert.ToInt32(label1_ekran.Text);
        }

        private void label1_ekran_Click(object sender, EventArgs e)
        {

        }
    }
}
