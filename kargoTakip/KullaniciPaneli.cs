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
    public partial class KullaniciPaneli : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public  int knumara;
        public string kSube;
        public string kIsim;
        public string ksoyIsim;
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

 


        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            label12.Text = "Hoşgeldiniz Sayın " + kIsim + " "+ ksoyIsim;
        }

        private void msorgula_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "SELECT * FROM musteri WHERE mtcno=:tc  ";

            OracleCommand cmd = new OracleCommand(sorgu, con);

            cmd.Parameters.Add(new OracleParameter("tc", mtcno.Text));

            OracleDataReader dr = cmd.ExecuteReader();
 
            if (dr.Read())
            {

                DialogResult secenek = MessageBox.Show("Kullanıcı Sistemde Kayıtlı!\n\n Bilgileri getirilsin mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    m_id.Text = dr["mid"].ToString();
                    pisim.Text = dr["misim"].ToString();
                    psoy.Text = dr["msoyisim"].ToString();
                    ptc.Text = dr["mtcno"].ToString();
                    pdogum.Text = dr["mdogumTarihi"].ToString();
                    padres.Text = dr["madres"].ToString();
                    pilce.Text = dr["milce"].ToString();
                    pil.Text = dr["msehir"].ToString();
                    ptel.Text = dr["mtel"].ToString();
 
                }

                else if (secenek == DialogResult.No)
                {

                }
 

            }
            else
            {


                DialogResult secenek = MessageBox.Show("Kullanıcı Bulunamadı!!!\nLütfen Bu Müşteriyi Kaydedin...", "Müşteri Kaydı YOK!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    MusteriKayit mk = new MusteriKayit();
                    mk.Show();



                }

                else if (secenek == DialogResult.No)
                {

                }


            }

            con.Close();
        }

        private void musduz_Click(object sender, EventArgs e)
        {
            if (pisim.Text.Length == 0 || psoy.Text.Length == 0
               || ptc.Text.Length == 0 || pil.Text.Length == 0
               || pdogum.Text.Length == 0 || pilce.Text.Length == 0
               || ptel.Text.Length == 0 || padres.Text.Length == 0 )
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\nDüzenleme Yapılamadı!!!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();

       string sorgu22 = "UPDATE musteri SET misim=:isim, msoyisim=:soyisim, mtcno=:tcno," +
                    " mdogumTarihi=:dob, madres=:adres, milce=:ilce, msehir=:sehir, mtel=:tel " +
                         " WHERE mid=:m_id2";


                OracleCommand cmd22 = new OracleCommand(sorgu22, con);

                cmd22.Parameters.Add(new OracleParameter("isim", pisim.Text));
                cmd22.Parameters.Add(new OracleParameter("soyisim", psoy.Text));
                cmd22.Parameters.Add(new OracleParameter("tcno", ptc.Text));
                cmd22.Parameters.Add(new OracleParameter("dob", pdogum.Text));
                cmd22.Parameters.Add(new OracleParameter("adres", padres.Text));
                cmd22.Parameters.Add(new OracleParameter("ilce", pilce.Text));
                cmd22.Parameters.Add(new OracleParameter("sehir", pil.Text));
                cmd22.Parameters.Add(new OracleParameter("tel", ptel.Text));
                cmd22.Parameters.Add(new OracleParameter("m_id2", m_id.Text));

                cmd22.ExecuteNonQuery();

                MessageBox.Show("Müşteri Düzenleme Başarıyla Yapıldı...!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                con.Close();

            }


        }

        private void yenile_Click(object sender, EventArgs e)
        {
            pisim.Text = "";
            psoy.Text = "";
            ptc.Text = "";
            pdogum.Text = "";
            padres.Text = "";
            pilce.Text = "";
            pil.Text = "";
            ptel.Text = "";
        }

        private void kekle_Click(object sender, EventArgs e)
        {

            if (pisim.Text.Length == 0 || psoy.Text.Length == 0
              || ptc.Text.Length == 0 || pil.Text.Length == 0
              || pdogum.Text.Length == 0 || pilce.Text.Length == 0
              || ptel.Text.Length == 0 || padres.Text.Length == 0 ||
              ais.Text.Length == 0 || aso.Text.Length == 0
              || atc.Text.Length == 0 || ase.Text.Length == 0
              || aka.Text.Length == 0 || ail.Text.Length == 0
              || ate.Text.Length == 0 || aad.Text.Length == 0 || ucret.Text.Length == 0
              )
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\nKargo Eklenemedi!!!", "Ekleme YAPILAMADI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();


                string gonderen_bilgi = pisim.Text + " " + psoy.Text + " - Adres: " + padres.Text
                    + " " + pilce.Text + " " + pil.Text + " - Tel: " + ptel.Text;

                DateTime dt = DateTime.Now;
                
                //takip no: KTN-kullanici ID-yil-ay-gün-saat-dakika-saniye
                string ktNo = "KTN"+ knumara + dt.ToString("dd") + dt.ToString("MM") + dt.ToString("yyyy")+
                    dt.ToString("HH") + dt.ToString("mm") + dt.ToString("ss");
                
                //sms no: saat-dakika-saniye
                string smsNo = dt.ToString("HH") + dt.ToString("mm") + dt.ToString("ss");

                string tarihbilgi = dt.ToString("dd/MM/yyy HH:mm:ss");

  string sorgu222 = "INSERT INTO kargo(kaliciisim, kalicisoyisim, kalicitcno, kgonderentcno," +
                    " kgonderenBilgi, kaliciadres, kaliciilce, kalicisehir," +
                    "kalicitel,kicerik,ktakipNo,ktarih,kgonderenSube,kucret,sms)" +
                    " VALUES(:isim, :soyisim, :tcno,:gtcno, :gonderenbilgi, :adres," +
                    " :ilce, :sehir, :tel,:icerik,:ktn,:ktar,:kSubeGonderen,:ucretk,:smsAl)";


                OracleCommand cmd222 = new OracleCommand(sorgu222, con);

                cmd222.Parameters.Add(new OracleParameter("isim", ais.Text));
                cmd222.Parameters.Add(new OracleParameter("soyisim", aso.Text));
                cmd222.Parameters.Add(new OracleParameter("tcno", atc.Text));
                cmd222.Parameters.Add(new OracleParameter("gtcno", ptc.Text));
                cmd222.Parameters.Add(new OracleParameter("gonderenbilgi", gonderen_bilgi));
                cmd222.Parameters.Add(new OracleParameter("adres", aad.Text));
                cmd222.Parameters.Add(new OracleParameter("ilce", ail.Text));
                cmd222.Parameters.Add(new OracleParameter("sehir", ase.Text));
                cmd222.Parameters.Add(new OracleParameter("tel", ate.Text));
                cmd222.Parameters.Add(new OracleParameter("icerik", aka.Text));
                cmd222.Parameters.Add(new OracleParameter("ktn", ktNo));
                cmd222.Parameters.Add(new OracleParameter("ktar", tarihbilgi));
                cmd222.Parameters.Add(new OracleParameter("kSubeGonderen", kSube));
                cmd222.Parameters.Add(new OracleParameter("ucretk", ucret.Text));
                cmd222.Parameters.Add(new OracleParameter("smsAl", smsNo));

                cmd222.ExecuteNonQuery();

                MessageBox.Show("Kargo Başarıyla Eklendi...!\nKargo Takip No: " + ktNo 
                    +"\nSMS No: "+smsNo, "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                pisim.Text = "";
                psoy.Text = "";
                ptc.Text = "";
                pdogum.Text = "";
                padres.Text = "";
                pilce.Text = "";
                pil.Text = "";
                ptel.Text = "";

                ais.Text = "";
                aso.Text = "";
                atc.Text = "";
                aad.Text = "";
                ail.Text = "";
                ase.Text = "";
                ate.Text = "";
                aka.Text = "";
                ucret.Text = "";

            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
 

        private void aliciGetir_Click(object sender, EventArgs e)
        {

            con.Open();

            string sorgu = "SELECT * FROM kargo WHERE kalicitcno=:tc  ";

            OracleCommand cmd = new OracleCommand(sorgu, con);

            cmd.Parameters.Add(new OracleParameter("tc", aliciTcNo.Text));

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                DialogResult secenek = MessageBox.Show("Kullanıcı Sistemde Kayıtlı!\n\n Bilgileri getirilsin mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                     
                    ais.Text = dr["kaliciisim"].ToString();
                    aso.Text = dr["kalicisoyisim"].ToString();
                    atc.Text = dr["kalicitcno"].ToString();
                   
                    aad.Text = dr["kaliciadres"].ToString();
                    ail.Text = dr["kaliciilce"].ToString();
                    ase.Text = dr["kalicisehir"].ToString();
                    ate.Text = dr["kalicitel"].ToString();
                   // aka.Text = dr["kicerik"].ToString();
                  
                    ucret.Text = dr["kucret"].ToString();

                }

                else if (secenek == DialogResult.No)
                {

                }


            }
            else
            {

MessageBox.Show("Sistemde Böyle bir ALICI Bulunamadı!\nLütfen, bilgilerini elinizle giriniz...", "UYARI!!! : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            con.Close();

        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
            Teslimat tes =new Teslimat();
            
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

        private void KullaniciPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
