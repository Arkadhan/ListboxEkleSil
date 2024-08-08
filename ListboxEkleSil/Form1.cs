using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxEkleSil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnİsimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                lbSayiİsim.Items.Add(tbIsim.Text);
            }
            catch
            {
                MessageBox.Show("Bir isim giriniz", "Hata", MessageBoxButtons.OK);

            }
        }

        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                lbSayiİsim.Items.Add(tbSayi.Text);
            }
            catch
            {
                MessageBox.Show("Bir sayı giriniz", "Hata", MessageBoxButtons.OK);

            }
        }

        private void btnTumSil_Click(object sender, EventArgs e)
        {
            lbSayiİsim.Items.Clear();
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if(lbSayiİsim.SelectedIndex!=-1)
            {
                lbSayiİsim.Items.RemoveAt(lbSayiİsim.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Listede seçili öge yok", "Hata", MessageBoxButtons.OK);
            }
        }

        private void lbSayiİsim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblElemanSayisi.Text = Convert.ToString( lbSayiİsim.Items.Count);
        }
    }
}
