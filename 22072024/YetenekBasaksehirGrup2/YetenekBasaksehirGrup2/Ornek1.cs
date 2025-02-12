using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YetenekBasaksehirGrup2
{
    public partial class Ornek1 : Form
    {
        public Ornek1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string productName = txtUrunAdi.Text;

            //ctrl + k + d ile kod görünümünü düzeltebiliriz.

            //Tür Dönüşümleri:
            //string to int
            int productQuantity = Convert.ToInt32(txtUrunAdedi.Text);
            double unitPrice = Convert.ToDouble(txtUrunFiyati.Text);
            
            double kdvliFiyat = productQuantity * unitPrice * 1.20;

            //double to string
            // lblMesaj.Text = kdvliFiyat.ToString();
            //lblMesaj.Text = productName + "adlı ürünün yeni fiyatı: " + kdvliFiyat;
            lblMesaj.Text = $"{productName} adlı ürünün yeni fiyatı: {kdvliFiyat}";

        }
    }
}
