using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char neislemiyapacak;
        bool ekranitemizleyecekmi;
        int sayi1;
        
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }
            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text=="0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text = "9";
        }

        private void Btnbol_Click(object sender, EventArgs e)
        {
            neislemiyapacak = '/';
            ekranitemizleyecekmi = true;
            sayi1 = Convert.ToInt32(Lblsonuc.Text);
        }

        private void Btncarp_Click(object sender, EventArgs e)
        {
            neislemiyapacak = '*';
            ekranitemizleyecekmi = true;
            sayi1 = Convert.ToInt32(Lblsonuc.Text);
        }

        private void Btnfark_Click(object sender, EventArgs e)
        {
            neislemiyapacak = '-';
            ekranitemizleyecekmi = true;
            sayi1 = Convert.ToInt32(Lblsonuc.Text);
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            Lblsonuc.Text = "0";
        }

        private void Btntopla_Click(object sender, EventArgs e)
        {
            neislemiyapacak = '+';
            ekranitemizleyecekmi = true;
            sayi1 = Convert.ToInt32(Lblsonuc.Text);
            
        }

        private void Btnsonuc_Click_1(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(Lblsonuc.Text);
            int sonuc;

            switch (neislemiyapacak)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            Lblsonuc.Text = sonuc.ToString();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (ekranitemizleyecekmi)
            {
                Lblsonuc.Text = "";
                ekranitemizleyecekmi = false;
            }

            if (Lblsonuc.Text == "0")
            {
                Lblsonuc.Text = "";
            }
            Lblsonuc.Text += "0";
        }

        //kullanım: butonlara basarak 1.sayiyi girin sonra yapmak istediginiz islem icin islemin sembolune basın ardından 2.sayiyi girip = butonuna basınız. :)
    }
}
