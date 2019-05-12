using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTimePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            txtCiphertexti.Text = Enkripto(txtPlaintexti.Text, "QWERTY");
        }

        public string Enkripto(string plaintexti, string celesi)
        {
            StringBuilder objRes = new StringBuilder(plaintexti);
            for(int i=0;i<plaintexti.Length;i++)
            {
                objRes[i] = (char)(plaintexti[i] ^ celesi[i]);
            }

            return objRes.ToString();
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            txtTextiDekriptuar.Text = Enkripto(txtCiphertexti.Text, "QWERTY");
        }
    }
}
