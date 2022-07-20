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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SQGL39R\\SQL;Initial Catalog=PersonelTakipSistemi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            komut.Connection = con;
            komut.CommandText = "Insert into Kullanıcılar(KullanıcıYetkiID,Ad,Soyad,KullanıcıAdı,Yetki,Sifre) values (10,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = " Kullanıcı Ekleme ";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
