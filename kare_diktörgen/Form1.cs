using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kare_diktörgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //KARE'nin ALANINI ve ÇEVRESİNİ HESAPLAMA
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; //KareHesaplama Alanı Gösterir.
            panel2.Visible = false; //DikdörtgenHesaplama Alanı Gizler.
        }

        private void karehesaplama_Click(object sender, EventArgs e)
        {
            int birkenar;
            int karealanı, karecevresi;

            birkenar = Convert.ToInt32(textBox1.Text);

            //hesaplama bölümü
            karealanı = birkenar * birkenar;
            karecevresi = birkenar * 4;

            textBox2.Text = karealanı.ToString();
            textBox3.Text = karecevresi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible= true; //DikdörtgenHesaplama Alanı Gösterir.
            panel1.Visible = false; //KareHesaplama Alanı Gizle.
        }
        //DİKDÖRTGEN'in ALANINI ve ÇEVRESİNİ HESAPLAMA
        private void dikdörtgenhesaplama_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar;
            int dikalanı, dikcevresi;

            kısakenar = Convert.ToInt32(textBox4.Text);
            uzunkenar = Convert.ToInt32(textBox7.Text);

            //hesaplama bölümü
            dikalanı = kısakenar*uzunkenar;
            dikcevresi=(2*kısakenar)+(2*uzunkenar);

            textBox6.Text = dikalanı.ToString();
            textBox5.Text = dikcevresi.ToString();
        }
    }
}
