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
using System.Configuration;

namespace PTKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

         public SqlConnection con = new SqlConnection("Data Source=DESKTOP-SQGL39R\\SQL;Initial Catalog=PersonelTakipSistemi;Integrated Security=True");
      

        public static string Bilgiler;
       
        private void btnGrs_Click(object sender, EventArgs e)
        {

            string yetki="0";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Yetki From Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "' and Sifre = '" + txtSifre.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                yetki  = dr["Yetki"].ToString();
                
            }
            if (yetki == "admin     ")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else if (yetki == "hr        ")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else if (yetki == "personel  ")
            {
                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }

            else

            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
            con.Close();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " Personel Takip Sistemi ";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
           








            /*    string KullanıcıAdı = txtKullanıcıAdı.Text;
                string Yetki = txtYetki.Text;
                string Sifre = txtSifre.Text;
                veritabanı islem = new veritabanı();
                islem.giris(KullanıcıAdı, Yetki, Sifre, this);



               */
        





        /*
        baglanti.Open();

        SqlCommand sorgu = new SqlCommand("select * from Kullanıcılar", baglanti);

        SqlDataReader kayıtokuma = sorgu.ExecuteReader();
        kayıtokuma.Read();



            drmkontrol = true;

            if (txtYetki.Text == "admin" && txtKullanıcıAdı.Text == kayıtokuma.GetValue(3).ToString()
                && txtSifre.Text == kayıtokuma.GetValue(5).ToString())
            {

                Form2 ac = new Form2();
                ac.Show();
                this.Hide();

            }

            baglanti.Close(); */

        /*




            */



        /*

        if (kayıtokuma["KullanıcıAdı"].ToString() == txtKullanıcıAdı.Text && kayıtokuma["Yetki"].ToString() == txtYetki.Text && kayıtokuma["Sifre"] == txtSifre.Text && kayıtokuma["Yetki"].ToString() == "hr")

        {
            //baglanti.Open();
            drmkontrol = true;
            KullanıcıAdı = kayıtokuma.GetValue(3).ToString();
            Yetki = kayıtokuma.GetValue(4).ToString();
            Sifre = kayıtokuma.GetValue(5).ToString();
            Form2 ac = new Form2();
            ac.Show();
            this.Hide();

        }

        if (kayıtokuma["KullanıcıAdı"].ToString() == txtKullanıcıAdı.Text && kayıtokuma["Yetki"].ToString() == txtYetki.Text && kayıtokuma["Sifre"] == txtSifre.Text && kayıtokuma["Yetki"].ToString() == "personel")

        {
            //baglanti.Open();
            drmkontrol = true;
            KullanıcıAdı = kayıtokuma.GetValue(3).ToString();
            Yetki = kayıtokuma.GetValue(4).ToString();
            Sifre = kayıtokuma.GetValue(5).ToString();
            Form2 ac = new Form2();
            ac.Show();
            this.Hide();

        }

        else if (drmkontrol == false)
        {
            MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı...");
        }

    baglanti.Close();
        */




        /*            if (txtKullanıcıAdı.Text == "aozer" && txtYetki.Text == "admin" && txtSifre.Text == "1453*")
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();

                    }

                       if (txtYetki.Text == "hr" && txtSifre.Text == "9665+")
                    {

                        Form2 frm2 = new Form2();
                        frm2.Show();

                        this.Hide();
                    }

                    if (txtYetki.Text == "personel" && txtSifre.Text == "4523-") 
                    {
                        Form4 frm4 = new Form4();
                        frm4.Show();
                        this.Hide();

                    }


                    baglanti.Close();*/







