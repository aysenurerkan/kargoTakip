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
    public partial class GelisBildirimi : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public int knumara;
        public string kSube;
        public string kIsim;
        public string ksoyIsim;

        public GelisBildirimi()
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

                    if (dr3["kgonderenSube"].ToString() == kSube)
                    {
                        MessageBox.Show("Bu kargo Bu Şubede zaten Ekli!\nEkleme Yapılamadı", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        DialogResult secenek = MessageBox.Show(ktNoSorgu.Text + " no'lu Kargoyu\n Şubenize Eklemek İstiyor musunuz?", "Kargo Ekleme Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (secenek == DialogResult.Yes)
                        {
                            DateTime dt2 = DateTime.Now;

                            string tarihbilgi2 = dt2.ToString("dd/MM/yyy HH:mm:ss");

                            string sorgu5 = "INSERT INTO kargoTakip(ktAraSubelerTarih," +
                                "ktTakipNo,ktTeslim,ktAraSubeler)" +
                                " VALUES(:tarih,:ktnn,:ktt,:sube) ";

                            OracleCommand cmd5 = new OracleCommand(sorgu5, con);

                             
                            cmd5.Parameters.Add(new OracleParameter("tarih", tarihbilgi2));
                            cmd5.Parameters.Add(new OracleParameter("ktnn", ktNoSorgu.Text));

                            if (normal.Checked == true) {

                                cmd5.Parameters.Add(new OracleParameter("ktt", "H"));
                                cmd5.Parameters.Add(new OracleParameter("sube", kSube));

                            }
                            else
                            {
                                cmd5.Parameters.Add(new OracleParameter("ktt", "D"));
                                cmd5.Parameters.Add(new OracleParameter("sube", "Dağıtım Şubesi"));
                            }

                           

                            cmd5.ExecuteNonQuery();

                            if (normal.Checked == true)
                            {

             MessageBox.Show("Kargo Şube Üzerine Başarıyla Geçti!", "Ekleme Başarılı... : ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            else
                            {
        MessageBox.Show("Kargo Şube Üzerine Başarıyla Geçti!\nDağıtım Mesajı Müşteriye Gönderildi!!!", "Ekleme Başarılı... : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }


                            ktNoSorgu.Text = "";

                        }

                        else if (secenek == DialogResult.No)
                        {

                        }

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

        private void GelisBildirimi_Load(object sender, EventArgs e)
        {
            label12.Text = "Hoşgeldiniz Sayın " + kIsim + " " + ksoyIsim;
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciPaneli kp = new KullaniciPaneli();
            kp.knumara = knumara;
            kp.kSube = kSube;
            kp.kIsim = kIsim;
            kp.ksoyIsim = ksoyIsim;
            kp.Show();
            this.Hide();
        }

        private void gelişBildirimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teslimatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teslimat tes = new Teslimat();
            tes.knumara = knumara;
            tes.kSube = kSube;
            tes.kIsim = kIsim;
            tes.ksoyIsim = ksoyIsim;


            tes.Show();
            this.Hide();
        }

        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir siff = new SifreDegistir();
            siff.knumara = knumara;
            siff.kSube = kSube;
            siff.kIsim = kIsim;
            siff.ksoyIsim = ksoyIsim;


            siff.Show();
            
        }

        private void GelisBildirimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
