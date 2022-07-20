using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTKS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet2.Maas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maasTableAdapter1.Fill(this.personelTakipSistemiDataSet2.Maas);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet2.Maas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maasTableAdapter1.Fill(this.personelTakipSistemiDataSet2.Maas);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Mesai' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesaiTableAdapter.Fill(this.personelTakipSistemiDataSet.Mesai);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Mesai' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesaiTableAdapter.Fill(this.personelTakipSistemiDataSet.Mesai);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Hareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hareketlerTableAdapter.Fill(this.personelTakipSistemiDataSet.Hareketler);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Hareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hareketlerTableAdapter.Fill(this.personelTakipSistemiDataSet.Hareketler);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Maas2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Maas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maasTableAdapter.Fill(this.personelTakipSistemiDataSet.Maas);
            this.Text = " Personel Girişi...";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void maasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personelTakipSistemiDataSet);

        }

        private void tabMaas_Click(object sender, EventArgs e)
        {

        }
    }
}
