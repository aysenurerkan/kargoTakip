using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.OleDb;

namespace kargoTakip
{
    public partial class AdminPaneli : Form
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        OracleDataAdapter mda;

        DataSet ds;

        int s_id;

        int g_id;

        int k_id;

        string ktnumarasi;



        public AdminPaneli()
        {
            InitializeComponent();
        }

        public void sube_listele()
        {

            con.Open();

            string cek = "SELECT*FROM subeler ORDER BY sisim ASC";

            mda = new OracleDataAdapter(cek,con);
 
            ds = new DataSet();

            mda.Fill(ds, "subeler");

            dataGridView1.DataSource = ds.Tables[0];
             
            con.Close();
 
        }

        public void kargo_listele()
        {

            con.Open();

            string cek22 = "SELECT*FROM kargo ORDER BY kid DESC";

            mda = new OracleDataAdapter(cek22, con);

            ds = new DataSet();

            mda.Fill(ds, "kargo");

            dataGridView3.DataSource = ds.Tables[0];

            con.Close();

        }


        public void personel_listele()
        {

            con.Open();

            string cek = "SELECT*FROM admin ORDER BY aisim ASC";

            mda = new OracleDataAdapter(cek, con);

            ds = new DataSet();

            mda.Fill(ds, "admin");

            dataGridView2.DataSource = ds.Tables[0];

            con.Close();

        }



        public void sube_combo()
        {

            con.Open();

            string sorgu = "SELECT * FROM subeler ";

            OracleCommand cmd = new OracleCommand(sorgu, con);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                comboBox1.Items.Add(dr["sisim"]);
                comboBox2.Items.Add(dr["sisim"]);

            }
            con.Close();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
             
            kargo_listele();
            sube_listele();
            sube_combo();
            dataGridView1.Columns[0].HeaderText = "Şube No";//sütun ismi değiştirme
            dataGridView1.Columns[1].HeaderText = "Şube Adı";
            dataGridView1.Columns[0].Width = 80; // sütun genişliği ayarlama
            dataGridView1.Columns[1].Width = 320;

            personel_listele();

            dataGridView2.Columns[0].Width = 50; // sütun genişliği ayarlama
            dataGridView2.Columns[0].HeaderText = "Per. No";//sütun ismi değiştirme
            dataGridView2.Columns[1].HeaderText = "İsim";
            dataGridView2.Columns[2].HeaderText = "Soyisim";
            dataGridView2.Columns[3].HeaderText = "TC No";
            dataGridView2.Columns[4].HeaderText = "D. Tarihi";
            dataGridView2.Columns[5].HeaderText = "Maaş (TL)";
            dataGridView2.Columns[6].HeaderText = "Şube";
            dataGridView2.Columns[7].HeaderText = "Şifre";
            dataGridView2.Columns[8].HeaderText = "Telefon";


            dataGridView3.Columns[0].Width = 50; // sütun genişliği ayarlama
            dataGridView3.Columns[0].HeaderText = "Kargo ID"; 
            dataGridView3.Columns[1].HeaderText = "Alıcı İsim";
            dataGridView3.Columns[2].HeaderText = "Alıcı Soyisim";
            dataGridView3.Columns[3].HeaderText = "Alıcı TC No";
            dataGridView3.Columns[4].HeaderText = "Gönderen TC No";
            dataGridView3.Columns[5].HeaderText = "Gönderen Bilgi";
            dataGridView3.Columns[6].HeaderText = "Alıcı Adres";
            dataGridView3.Columns[7].HeaderText = "Alıcı İlçe";
            dataGridView3.Columns[8].HeaderText = "Alıcı şehir";
            dataGridView3.Columns[9].HeaderText = "Alıcı Tel";
            dataGridView3.Columns[10].HeaderText = "Kargo İçerik";
            dataGridView3.Columns[11].HeaderText = "Kargo Takip No";
            dataGridView3.Columns[12].HeaderText = "Tarih";
            dataGridView3.Columns[13].HeaderText = "Gönderen Şube";
            dataGridView3.Columns[14].HeaderText = "Ücret";


        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (sisim.Text.Length == 0)
            {

  MessageBox.Show("Boş Bırakmayınız!\nTekrar Deneyin...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

            con.Open();
         
            string sorgu = "INSERT INTO subeler(sisim) VALUES(:isim) ";

            OracleCommand cmd = new OracleCommand(sorgu, con);

            cmd.Parameters.Add(new OracleParameter("isim", sisim.Text));

            cmd.ExecuteNonQuery();
 MessageBox.Show("Şube Kayıt İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

            sisim.Text = "";

            con.Close();

            sube_listele();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isDuz.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //[1] sütun numarası
            s_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void duzenle_Click(object sender, EventArgs e)
        {


            if (isDuz.Text.Length == 0)
            {
         MessageBox.Show("Boş Bırakmayınız!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                con.Open();

                string sorgu = "UPDATE subeler SET sisim=:isim WHERE sid=:id ";

                OracleCommand cmd = new OracleCommand(sorgu, con);

                cmd.Parameters.Add(new OracleParameter("isim", isDuz.Text));
                cmd.Parameters.Add(new OracleParameter("id", s_id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Şube Güncelleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isDuz.Text = "";
 
                con.Close();

                sube_listele();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (s_id <= 0)
            {
                MessageBox.Show("Seçmeden Silemezsiniz!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                DialogResult secenek = MessageBox.Show( isDuz.Text + " Şubesini silmek istiyor musunuz?", "İş Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    con.Open();

                    string sorgu = "DELETE FROM subeler  WHERE sid=:id ";

                    OracleCommand cmd = new OracleCommand(sorgu, con);

                    cmd.Parameters.Add(new OracleParameter("id", s_id));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Şube Silme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                    
                    con.Close();

                    sube_listele();
                }
                
                  else if (secenek == DialogResult.No)
                {

                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void p_ekle_Click(object sender, EventArgs e)
        {
            

            if (pisim.Text.Length == 0 || psoy.Text.Length == 0
                || ptc.Text.Length == 0 || pmaas.Text.Length == 0
                || pdogum.Text.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Boş Alanları Doldurunuz!\nPersonel Ekleme Yapılamadı!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
            {
                 
                con.Open();

                string sorgu = "INSERT INTO admin(aisim,asoyisim,atcno,adogumTarihi,amaas,asube,asifre,atel) " +
                    " VALUES(:isim,:soy,:tc,:dogum,:maas,:sube,:sifre,:tel) ";

                OracleCommand cmd = new OracleCommand(sorgu, con);

                cmd.Parameters.Add(new OracleParameter("isim", pisim.Text));
                cmd.Parameters.Add(new OracleParameter("soy", psoy.Text));
                cmd.Parameters.Add(new OracleParameter("tc", ptc.Text));
                cmd.Parameters.Add(new OracleParameter("dogum", pdogum.Text));
                cmd.Parameters.Add(new OracleParameter("maas", pmaas.Text));
                cmd.Parameters.Add(new OracleParameter("sube", comboBox1.Text));
                cmd.Parameters.Add(new OracleParameter("sifre", psif.Text));
                cmd.Parameters.Add(new OracleParameter("tel", ptel.Text));
                

                cmd.ExecuteNonQuery();

                MessageBox.Show("Yeni Personel Başarıya Kaydedildi...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pisim.Text = "";
                psoy.Text = "";
                ptc.Text = "";
                pmaas.Text = "";
                psif.Text = "";
                ptel.Text = "";

                con.Close();

                personel_listele();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            g_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
           idu.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
             sdu.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
              tdu.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
              ddu.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
              mdu.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
              comboBox2.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
              sidu.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
              tedu.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            



        }

        private void pduz_Click(object sender, EventArgs e)
        {
             if (idu.Text.Length==0 ||          sdu.Text.Length == 0 ||
            tdu.Text.Length == 0 ||            mdu.Text.Length == 0 ||
            sidu.Text.Length == 0 ||           ddu.Text.Length == 0 ||
            tedu.Text.Length == 0 ||           comboBox2.Text.Length == 0 )
            {
                MessageBox.Show("Boş Bırakmayınız!\nGüncelleme Yapılamadı...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                con.Open();

                // Start a local transaction
                //OracleTransaction transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                

                string sorgu2 = "UPDATE admin SET " +
            "aisim=:isim2,asoyisim=:soy2,atcno=:tc2,adogumTarihi=:dogum2,amaas=:maas2," +
            "asube=:sube2,asifre=:sifre2,atel=:tel2" +
      " WHERE aid=:id2";
                 
                OracleCommand cmd2 = new OracleCommand(sorgu2, con);

                // Assign transaction object for a pending local transaction
               // cmd2.Transaction = transaction;

             
                cmd2.Parameters.Add(new OracleParameter("isim2", idu.Text));
                cmd2.Parameters.Add(new OracleParameter("soy2", sdu.Text));
                cmd2.Parameters.Add(new OracleParameter("tc2", tdu.Text));
                cmd2.Parameters.Add(new OracleParameter("dogum2", ddu.Text));
                cmd2.Parameters.Add(new OracleParameter("maas2", mdu.Text));
                cmd2.Parameters.Add(new OracleParameter("sube2", comboBox2.Text));
                cmd2.Parameters.Add(new OracleParameter("sifre2", sidu.Text));
                cmd2.Parameters.Add(new OracleParameter("tel2", tedu.Text));
                cmd2.Parameters.Add(new OracleParameter("id2", g_id));


                cmd2.ExecuteNonQuery();

                //commit ekle
               // transaction.Commit();

                con.Close();

                MessageBox.Show("Personel Başarıya Güncellendi...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                idu.Text = "";
                sdu.Text = "";
                tdu.Text = "";
                ddu.Text = "";
                mdu.Text = "";
                sidu.Text = "";
                tedu.Text = "";
                comboBox2.Text = "";

                personel_listele();
            }
        }

        private void psil_Click(object sender, EventArgs e)
        {

            if (g_id <= 0)
            {
                MessageBox.Show("Seçmeden Silemezsiniz!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                DialogResult secenek = MessageBox.Show(idu.Text + " " + sdu.Text + " personelini silmek istiyor musunuz?", "İş Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    con.Open();

                    string sorgu = "DELETE FROM admin  WHERE aid=:id ";

                    OracleCommand cmd = new OracleCommand(sorgu, con);

                    cmd.Parameters.Add(new OracleParameter("id", g_id));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Personel Silme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                    personel_listele();
                }

                else if (secenek == DialogResult.No)
                {

                }
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            k_id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            ais.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            aso.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            atc.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            gtc.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            gbil.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            aad.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            ail.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
            ase.Text = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            ate.Text = dataGridView3.CurrentRow.Cells[9].Value.ToString();
            aka.Text = dataGridView3.CurrentRow.Cells[10].Value.ToString();
            ktnumarasi = dataGridView3.CurrentRow.Cells[11].Value.ToString();
            knoYaz.Text = "Kargo Takip No: " + ktnumarasi;
            ucret.Text = dataGridView3.CurrentRow.Cells[14].Value.ToString();



        }

        private void kguncelle_Click(object sender, EventArgs e)
        {

            if (ais.Text.Length == 0 || aso.Text.Length == 0
              || atc.Text.Length == 0 || ase.Text.Length == 0
              || aka.Text.Length == 0 || ail.Text.Length == 0
              || ate.Text.Length == 0 || aad.Text.Length == 0 || ucret.Text.Length == 0
              || gtc.Text.Length == 0 || gbil.Text.Length == 0)
            {
                MessageBox.Show("Boş Bırakmayınız!\nGüncelleme Yapılamadı...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                con.Open();

              
                string sorgu222 = "UPDATE kargo SET " +
            "kaliciisim=:isim, kalicisoyisim=:soyisim, kalicitcno=:tcno, kgonderentcno=:gtcno," +
                    " kgonderenBilgi=:gonderenbilgi, kaliciadres=:adres, kaliciilce=:ilce," +
                    " kalicisehir=:sehir," +
                    "kalicitel=:tel,kicerik=:icerik,kucret=:ucretk" +
                    " WHERE kid=:id222";

                OracleCommand cmd222 = new OracleCommand(sorgu222, con);

                cmd222.Parameters.Add(new OracleParameter("isim", ais.Text));
                cmd222.Parameters.Add(new OracleParameter("soyisim", aso.Text));
                cmd222.Parameters.Add(new OracleParameter("tcno", atc.Text));
                cmd222.Parameters.Add(new OracleParameter("gtcno", gtc.Text));
                cmd222.Parameters.Add(new OracleParameter("gonderenbilgi", gbil.Text));
                cmd222.Parameters.Add(new OracleParameter("adres", aad.Text));
                cmd222.Parameters.Add(new OracleParameter("ilce", ail.Text));
                cmd222.Parameters.Add(new OracleParameter("sehir", ase.Text));
                cmd222.Parameters.Add(new OracleParameter("tel", ate.Text));
                cmd222.Parameters.Add(new OracleParameter("icerik", aka.Text));
                //cmd222.Parameters.Add(new OracleParameter("ktn", ktNo));
               // cmd222.Parameters.Add(new OracleParameter("ktar", tarihbilgi));
               // cmd222.Parameters.Add(new OracleParameter("kSubeGonderen", kSube));
                cmd222.Parameters.Add(new OracleParameter("ucretk", ucret.Text));
                cmd222.Parameters.Add(new OracleParameter("id222", k_id));

                cmd222.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Kargo Başarıya Güncellendi...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ais.Text = "";
                aso.Text = "";
                atc.Text = "";
                gtc.Text = "";
                gbil.Text = "";
                aad.Text = "";
                ail.Text = "";
                ase.Text = "";
                ate.Text = "";
                aka.Text = "";
                ucret.Text = "";
                knoYaz.Text = "";

                kargo_listele();
            }

        }

        private void ksil_Click(object sender, EventArgs e)
        {

            if (k_id <= 0)
            {
                MessageBox.Show("Seçmeden Silemezsiniz!\nSilme İşlemi Başarısız Oldu...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                DialogResult secenek = MessageBox.Show(idu.Text + " " + sdu.Text + " Kargoyu silmek istiyor musunuz?", "İş Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    con.Open();

                    string sorgu = "DELETE FROM kargo  WHERE kid=:id ";

                    OracleCommand cmd = new OracleCommand(sorgu, con);

                    cmd.Parameters.Add(new OracleParameter("id", k_id));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kargo Silme İşlemi Başarıyla Gerçekleşti!...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();

                    ais.Text = "";
                    aso.Text = "";
                    atc.Text = "";
                    gtc.Text = "";
                    gbil.Text = "";
                    aad.Text = "";
                    ail.Text = "";
                    ase.Text = "";
                    ate.Text = "";
                    aka.Text = "";
                    ucret.Text = "";
                    knoYaz.Text = "";

                    kargo_listele();
                }

                else if (secenek == DialogResult.No)
                {

                }
            }

        }

        private void ktara_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "SELECT * FROM kargo WHERE ktakipNo=:ktn ";

            OracleCommand cmd = new OracleCommand(sorgu, con);

            cmd.Parameters.Add(new OracleParameter("ktn", ktn.Text));
            

            OracleDataReader dr = cmd.ExecuteReader();



            if (dr.Read())
            {

                k_id = Convert.ToInt32(dr["kid"].ToString());
                ais.Text = dr["kaliciisim"].ToString();
                aso.Text = dr["kalicisoyisim"].ToString();
                atc.Text = dr["kalicitcno"].ToString();
                gtc.Text = dr["kgonderentcno"].ToString();
                gbil.Text = dr["kgonderenBilgi"].ToString();
                aad.Text = dr["kaliciadres"].ToString();
                ail.Text = dr["kaliciilce"].ToString();
                ase.Text = dr["kalicisehir"].ToString();
                ate.Text = dr["kalicitel"].ToString();
                aka.Text = dr["kicerik"].ToString();
                knoYaz.Text = dr["ktakipNo"].ToString();
                ucret.Text = dr["kucret"].ToString();
 
            }
            else
            {

   MessageBox.Show("Sonuç Bulunamadı!\nTekrar Deneyiniz...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            con.Close();
        }

        private void getir_Click(object sender, EventArgs e)
        {

            con.Open();

            string cek22 = "SELECT*FROM kargo WHERE kalicitcno=:kal  OR kgonderentcno=:kgo";

            OracleCommand cmd = new OracleCommand(cek22, con);

            cmd.Parameters.Add(new OracleParameter("kal", altc.Text));
            cmd.Parameters.Add(new OracleParameter("kgo", gotc.Text));

            mda = new OracleDataAdapter(cmd);

            ds = new DataSet();

            mda.Fill(ds, "kargo");

            dataGridView3.DataSource = ds.Tables[0];

            con.Close();

        }

        private void AdminPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
