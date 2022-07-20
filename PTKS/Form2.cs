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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

         
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SQGL39R\\SQL;Initial Catalog=PersonelTakipSistemi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet2.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet2.Tarih' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tarihTableAdapter1.Fill(this.personelTakipSistemiDataSet2.Tarih);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet2.Maas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maasTableAdapter2.Fill(this.personelTakipSistemiDataSet2.Maas);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet1.Maas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maasTableAdapter1.Fill(this.personelTakipSistemiDataSet1.Maas);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Kullanıcılar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcılarTableAdapter.Fill(this.personelTakipSistemiDataSet.Kullanıcılar);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Mesai' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesaiTableAdapter.Fill(this.personelTakipSistemiDataSet.Mesai);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Tarih' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tarihTableAdapter.Fill(this.personelTakipSistemiDataSet.Tarih);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Hareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hareketlerTableAdapter.Fill(this.personelTakipSistemiDataSet.Hareketler);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Kartlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kartlarTableAdapter.Fill(this.personelTakipSistemiDataSet.Kartlar);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Maas2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.KullanıcıListesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcıListesiTableAdapter.Fill(this.personelTakipSistemiDataSet.KullanıcıListesi);
            // TODO: Bu kod satırı 'personelTakipSistemiDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.personelTakipSistemiDataSet.Personel);
            this.Text = "Yönetici Girişi...";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

           // form açılırken if döngüsü ile yetkiye göre alanlar pasif olacak alanadı.enabled=false;
        }


        
        private void personelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personelTakipSistemiDataSet);


        }

        private void tabPersonel_Click(object sender, EventArgs e)
        {

        }

        private void tabHareket_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcılarBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.personelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personelTakipSistemiDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            komut.Connection = con;
           // komut.CommandText = "Insert into Personel(Ad,Soyad,TC,SicilNo,Telefon,E_mail,Unvan,DepID,İseGirisTarihi,KartID,MedeniDurumu,ÇocukSayısı,EsCalısmaDurumu values (10,'" + adTextBox.Text + "','" + soyadTextBox.Text + "','" + TCTextBox.Text + "','" + sicilNoTextBox.Text + "','" + telefonTextBox.Text + "','" + e_mailTextBox.Text + "',,'" + unvanTextBox.Text + "',,'" + depIDNumericUpDown.Text + "',,'" + İseGirisTarihiDateTimePicker.Text + "',,'" + kartIDNumericUpDown1.Text + "',,'" + medeniDurumuComboBox.Text + "',,'" + çocukSayısıComboBox.Text + "',,'" + esCalısmaDurumuComboBox.Text + "', )";
            //komut.CommandText = "Insert into Kullanıcılar(Ad,Soyad,KullanıcıAdı,Yetki,Sifre) values (10,'" + adTextBox3.Text + "','" + soyadTextBox3.Text + "','" + kullanıcıAdıTextBox.Text + "','" + yetkiComboBox.Text + "','" + sifreTextBox.Text + "')";
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
