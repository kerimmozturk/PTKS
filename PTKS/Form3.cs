using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTKS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SQGL39R\\SQL;Initial Catalog=PersonelTakipSistemi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet2.Maas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maasTableAdapter.Fill(this.personelTakipSistemiDataSet2.Maas);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Mesai' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesaiTableAdapter.Fill(this.personelTakipSistemiDataSet.Mesai);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Hareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hareketlerTableAdapter.Fill(this.personelTakipSistemiDataSet.Hareketler);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Kartlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kartlarTableAdapter.Fill(this.personelTakipSistemiDataSet.Kartlar);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Maas2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Kullanıcılar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcılarTableAdapter.Fill(this.personelTakipSistemiDataSet.Kullanıcılar);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.personelTakipSistemiDataSet.Personel);
            this.Text = " HR Girişi...";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void personelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personelTakipSistemiDataSet);

        }

        private void tabMaas_Click(object sender, EventArgs e)
        {

        }
    }
}
