using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._20
{
    public partial class lblSonuc : Form
    {
        public lblSonuc()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToSingle(txtSayi1.Text);
            sayi2 = Convert.ToSingle(txtSayi2.Text);
            if (rbTopla.Checked)
            {
                sonuc = sayi1 + sayi2;

            }
            else if (rbCikar.Checked)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (rbCarp.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (rbBol.Checked)
            {
                sonuc = sayi1 / sayi2;
            }
            label3.Text = "Sonuc: " + sonuc.ToString();
        }
    }
}
