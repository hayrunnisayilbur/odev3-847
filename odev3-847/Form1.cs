using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1, cevap2;
            secim = listBox1.SelectedItems.ToString();
            cevap1 = rb1.Checked;
            cevap2 = rb2.Checked;
            if(cevap1 == true && ( secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("cevabınız doğru");
            }
            if(cevap1 == false && (secim == "MP4" || secim  == "MOV"))
            {
                MessageBox.Show("cevabınız yanlış");
            }
            if(cevap2 == true && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("cevabınız doğru");
            }
            if(cevap2 == false && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("cevabınız yanlış");
            }
        }
    }
}
