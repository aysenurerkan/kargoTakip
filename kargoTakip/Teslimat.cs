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
    public partial class Teslimat : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public int knumara;
        public string kSube;
        public string kIsim;
        public string ksoyIsim;

        public Teslimat()
        {
            InitializeComponent();
        }

        private void Teslimat_Load(object sender, EventArgs e)
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
            GelisBildirimi gb = new GelisBildirimi();

            gb.knumara = knumara;
            gb.kSube = kSube;
            gb.kIsim = kIsim;
            gb.ksoyIsim = ksoyIsim;
            gb.Show();
            this.Hide();
        }

        private void teslimatToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

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

        private void ktgonder_Click(object sender, EventArgs e)
        {
            if (ktNoSorgu.Text.Length == 0 || smsNo.Text.Length == 0 || kim.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();

                string sorgu3 = "SELECT*FROM kargo WHERE ktakipNo=:ktTakipNo2 AND sms=:smsNo2 ";

                OracleCommand cmd3 = new OracleCommand(sorgu3, con);

                cmd3.Parameters.Add(new OracleParameter("ktTakipNo2", ktNoSorgu.Text));
                cmd3.Parameters.Add(new OracleParameter("smsNo2", smsNo.Text));

                OracleDataReader dr3 = cmd3.ExecuteReader();

                if (dr3.Read())
                {


                    DialogResult secenek = MessageBox.Show(ktNoSorgu.Text + " no'lu Kargoyu\n Teslim Etmek İstiyor musunuz?", "Kargo Teslim Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (secenek == DialogResult.Yes)
                    {
                        DateTime dt2 = DateTime.Now;

                        string tarihbilgi2 = dt2.ToString("dd/MM/yyy HH:mm:ss");

                        string sorgu5 = "INSERT INTO kargoTakip(ktAraSubeler,ktAraSubelerTarih," +
                            "ktTakipNo,ktTeslim,alanKisi)" +
                            " VALUES(:sube,:tarih,:ktnn,:ktt,:alan) ";

                        OracleCommand cmd5 = new OracleCommand(sorgu5, con);

                        cmd5.Parameters.Add(new OracleParameter("sube", kSube));
                        cmd5.Parameters.Add(new OracleParameter("tarih", tarihbilgi2));
                        cmd5.Parameters.Add(new OracleParameter("ktnn", ktNoSorgu.Text));
                        cmd5.Parameters.Add(new OracleParameter("ktt", "E"));
                        cmd5.Parameters.Add(new OracleParameter("alan", kim.Text));

                        cmd5.ExecuteNonQuery();

                        MessageBox.Show("Kargo Başarıyla TEslim Edildi!", "Teslim Başarılı... : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ktNoSorgu.Text = "";
                        smsNo.Text = "";
                        kim.Text = "";

                    }

                    else if (secenek == DialogResult.No)
                    {

                    }

                }

                else
                {
                    MessageBox.Show("Kargo Takip No ya da!\n SMS No YANLIŞ!!!", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                ktNoSorgu.Text = "";

                con.Close();



            }
        }

        private void Teslimat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
