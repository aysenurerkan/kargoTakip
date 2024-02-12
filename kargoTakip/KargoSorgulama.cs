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
    public partial class KargoSorgulama : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        string subeAd,subeTarih,teslim,kBilgi,yazi,alan;

        private void KargoSorgulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void KargoSorgulama_Load(object sender, EventArgs e)
        {

        }

        public KargoSorgulama()
        {
            InitializeComponent();
        }

        private void ktgonder_Click(object sender, EventArgs e)
        {
            if (ktNoSorgu.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();

                string sorgu3 = "SELECT*FROM kargo WHERE ktakipNo=:ktTakipNo2 ";

                OracleCommand cmd3 = new OracleCommand(sorgu3, con);

                cmd3.Parameters.Add(new OracleParameter("ktTakipNo2", ktNoSorgu.Text));

                OracleDataReader dr3 = cmd3.ExecuteReader();

                if (dr3.Read())
                {


                    String bilgiler = "Gönderen: "+  dr3["kgonderenBilgi"].ToString() +
                       "\n\nAlıcı: " + dr3["kaliciisim"].ToString() + " " + dr3["kalicisoyisim"].ToString() +
                       " - Adres: " + dr3["kaliciadres"].ToString() + " " + dr3["kaliciilce"].ToString() +
                       " " + dr3["kalicisehir"].ToString() + " - Tel: " + dr3["kalicitel"].ToString() +
                       "\n\nİçerik: " + dr3["kicerik"].ToString();

                    label2.Text = bilgiler;

                    string sorgu33 = "SELECT*FROM kargoTakip WHERE ktTakipNo=:ktTakipNo22 ORDER BY  ktid  ASC";

                    OracleCommand cmd33 = new OracleCommand(sorgu33, con);

                    cmd33.Parameters.Add(new OracleParameter("ktTakipNo22", ktNoSorgu.Text));

                    OracleDataReader dr33 = cmd33.ExecuteReader();
                    int sayac = 1;
                    while (dr33.Read())
                    { 
                        subeAd = dr33["ktAraSubeler"].ToString();
                        subeTarih = dr33["ktAraSubelerTarih"].ToString();
                        teslim = dr33["ktTeslim"].ToString();
                        alan = dr33["alanKisi"].ToString();

                        if (teslim == "E")
                        {
                             yazi = "Teslim Edildi (Teslim Alan Kişi: "+ alan +")";
                        }
                        else if (teslim == "D")
                        {
                             yazi = "Dağıtıma Çıktı";
                        }
                        else
                        {
                             yazi = "Yola çıktı";
                        }

                        kBilgi =sayac + ". Şube -> " + subeAd + " -> Tarih: " + subeTarih+ " -> Durumu: " + yazi + "\n" ;

                        label3.Text += kBilgi;

                        sayac++;

                    }
 
                    }
                else
                {
                    MessageBox.Show("Böyle bir Takip Numarası Bulunamadı!\n", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                ktNoSorgu.Text = "";

                con.Close();

            }
        }
    }
}
