using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
 




namespace kargoTakip
{
    public partial class giris : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public giris()
        {
            InitializeComponent();
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
           
            string tcnoAl = tcno.Text;
            string sifreAl = sifre.Text;

            if (tcnoAl.Length == 0 || sifreAl.Length == 0)
            {
  MessageBox.Show("Alanları Boş Bırakmayınız!\nGiriş Başarısız Oldu...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else {

                con.Open();

                string sorgu = "SELECT * FROM admin WHERE atcno=:tc AND asifre=:sif ";

                OracleCommand cmd = new OracleCommand(sorgu,con);
                
                cmd.Parameters.Add(new OracleParameter("tc", tcno.Text));
                cmd.Parameters.Add(new OracleParameter("sif", sifre.Text));
                
                OracleDataReader dr = cmd.ExecuteReader();

               
                
                if(dr.Read())
                { 

                    if (dr["aid"].ToString() == "1")
                    {
                        AdminPaneli adpan = new AdminPaneli();
                        adpan.Show();

                       this.Hide();
                    }
                    else
                    {
                        KullaniciPaneli kupan = new KullaniciPaneli();
                        kupan.knumara = Convert.ToInt32(dr["aid"].ToString());
                        kupan.kSube = dr["asube"].ToString();
                        kupan.kIsim = dr["aisim"].ToString();
                        kupan.ksoyIsim = dr["asoyisim"].ToString();
 
                        kupan.Show();
                        this.Hide();
                    }

                  

               }
                else
                {
MessageBox.Show("Bilgileriniz Hatalı!\nTekrar Deneyin...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                con.Close();

            }

 

             
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KargoSorgulama ks = new KargoSorgulama();
            ks.Show();
            this.Hide();
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
