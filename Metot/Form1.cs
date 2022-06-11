using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nisan_1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class hesap
        {
            public int topla(int s1, int s2)
            {
                int tp;

                tp = s1 + s2;

                return tp;

            }

            public int cıkar(int s1, int s2)
            {
                int cıkar;

                cıkar = s1 - s2;

                return cıkar;

            }

            public int carpma(int s1, int s2)
            {
                int carpma;

                carpma = s1 * s2;

                return carpma;

            }

            public int bolme(int s1, int s2)
            {
                int bolme;

                bolme = s1 / s2;

                return bolme;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            hesap hesapla = new hesap();

            label5.Text = hesapla.topla(12, 3).ToString();
            label6.Text = hesapla.cıkar(12, 3).ToString();
            label7.Text = hesapla.carpma(12, 3).ToString();
            label8.Text = hesapla.bolme(12, 3).ToString();

            Class1 hp = new Class1();

            label9.Text = hp.ort(80, 50).ToString();
        
        }
    }
}
