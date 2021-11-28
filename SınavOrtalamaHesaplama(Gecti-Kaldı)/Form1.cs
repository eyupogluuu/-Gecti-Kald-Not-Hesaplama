using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavOrtalamaHesaplama_Gecti_Kaldı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, proje,ortalama;

            s1 = Convert.ToInt32(texts1.Text);
            s2 = Convert.ToInt32(texts2.Text);
            s3 = Convert.ToInt32(texts3.Text);
            proje = Convert.ToInt32(texts4.Text);
            ortalama = (s1 + s2 + s3 + proje) / 4;

            labelortalama.Text = ortalama.ToString();

            if (ortalama>50)
            {
                labeldurum.Text = "Geçtiniz";
            }
            else
            {
                labeldurum.Text = "Kaldınız";
            }
        }
    }
}
