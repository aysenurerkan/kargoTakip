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
    public partial class SifreDegistir : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public int knumara;
        public string kSube;
        public string kIsim;
        public string ksoyIsim;
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void ktgonder_Click(object sender, EventArgs e)
        {
            if (eski.Text.Length == 0 || yeni.Text.Length == 0 || yeni2.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (yeni.Text.Length <= 4)
            {
                MessageBox.Show("Yeni Şifre En az 4 Haneli Olmalı!\n", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (yeni.Text!= yeni2.Text)
            {
                MessageBox.Show("Yeni Şifreler Uyuşmuyor!\n", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();

                string sorgu3 = "SELECT*FROM admin WHERE asifre=:eskisif AND aid=:anumara ";

                OracleCommand cmd3 = new OracleCommand(sorgu3, con);

                cmd3.Parameters.Add(new OracleParameter("eskisif", eski.Text));
                cmd3.Parameters.Add(new OracleParameter("anumara", knumara));

                OracleDataReader dr3 = cmd3.ExecuteReader();

                if (dr3.Read())
                {

                        string sorgu5 = "UPDATE admin SET asifre=:yenisifree" +
                            " VALUES aid=ano ";

                        OracleCommand cmd5 = new OracleCommand(sorgu5, con);
                     
                        cmd5.Parameters.Add(new OracleParameter("yenisifree", yeni.Text));
                        cmd5.Parameters.Add(new OracleParameter("ano", knumara));
                         

                        cmd5.ExecuteNonQuery();

                        MessageBox.Show("Şifre Başarıyla Değiştirildi!\n" +
                            "Yeni Şifre: "+ yeni.Text, "Şifre Değişikliği Başarılı... : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        eski.Text = "";
                        yeni.Text = "";
                        yeni2.Text = "";
 
                }

                else
                {
                    MessageBox.Show("Eski Şifre Hatalı!!!", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                eski.Text = "";

                con.Close();



            }
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            label12.Text = "Hoşgeldiniz Sayın " + kIsim + " " + ksoyIsim;
        }
    }
}
