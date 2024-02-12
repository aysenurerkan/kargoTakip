using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargoTakip
{
    public partial class MusteriKayit : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public MusteriKayit()
        {
            InitializeComponent();
        }

        private void kayit_Click(object sender, EventArgs e)
        {

            if (pisim.Text.Length == 0 || psoy.Text.Length == 0
                || ptc.Text.Length == 0 || pil.Text.Length == 0
                || pdogum.Text.Length == 0 || pilce.Text.Length == 0
                || ptel.Text.Length == 0 || padres.Text.Length == 0)
            {
 MessageBox.Show("Boş Alan Bırakmayınız!\nKayıt Yapılamadı!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();

  string sorgu = "INSERT INTO musteri(misim, msoyisim, mtcno, mdogumTarihi, madres, milce, msehir, mtel)" +
           " VALUES(:isim, :soyisim, :tcno, :dob, :adres, :ilce, :sehir, :tel)";
        

                OracleCommand cmd = new OracleCommand(sorgu, con);

                cmd.Parameters.Add(new OracleParameter("isim", pisim.Text));
                cmd.Parameters.Add(new OracleParameter("isim", psoy.Text));
                cmd.Parameters.Add(new OracleParameter("isim", ptc.Text));
                cmd.Parameters.Add(new OracleParameter("isim", pdogum.Text));
                cmd.Parameters.Add(new OracleParameter("isim", padres.Text));
                cmd.Parameters.Add(new OracleParameter("isim", pilce.Text));
                cmd.Parameters.Add(new OracleParameter("isim", pil.Text));
                cmd.Parameters.Add(new OracleParameter("isim", ptel.Text));

                cmd.ExecuteNonQuery();

 MessageBox.Show("Yeni Müşteri Kaydı Başarıyla Yapıldı...!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                pisim.Text = "";
                psoy.Text = "";
                ptc.Text = "";
                pdogum.Text = "";
                padres.Text = "";
                pilce.Text = "";
                pil.Text = "";
                ptel.Text = "";

                con.Close();
 
            }



             }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
