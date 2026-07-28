using S7.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;

namespace SQL_AKTAR_V2._0
{
    public partial class Form1 : MetroSet_UI.Forms.MetroSetForm
    {








        #region serial_port
        SerialPort sp = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);




        void baglanti_ac()
        {

                
            try
            {
                sp.Open();


                if (sp.IsOpen)
                {
                    MessageBox.Show("başarılı bağlantı");
                }



            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());

            }



        }



        public void barkod_cikar(string baslik)
        {

            string kelime;


            string param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17;
            string qr0 = baslik;
            string qr3 = "8001097623";
            string qr2 = "257509 00";
            string qr1 = System.DateTime.Today.ToString("d");

            param1 = "05\n";
            param2 = "SIZE 24.10 mm, 15 mm\n";
            param3 = "DIRECTION 0,0\n";
            param4 = "REFERENCE 0,0\n";
            param5 = "OFFSET 0 mm\n";
            param6 = "SET PEEL OFF\n";
            param7 = "SET CUTTER OFF\n";
            param8 = "SET PARTIAL_CUTTER OFF\n";
            param9 = "SET TEAR ON\n";
            param10 = "CLS\n";
            param11 = "QRCODE 101,95,L,2,A,270,M2,S7,\"" + qr0.ToString() + "\"\n";
            param12 = "CODEPAGE 1254\n";
            param13 = "TEXT 70,105,\"ROMAN.TTF\",270,1,7,\"" + qr3.ToString() + "\"\n";
            param14 = "TEXT 44,105,\"ROMAN.TTF\",270,1,7,\"" + qr2.ToString() + "\"\n";
            param15 = "TEXT 19,105,\"ROMAN.TTF\",270,1,7,\"" + qr1.ToString() + "\"\n";
            param16 = "PRINT 1,1\n";
            param17 = "04\n";

            kelime = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16 + param17;


            byte[] bytes = Encoding.ASCII.GetBytes(kelime);







            sp.Write(bytes, 0, bytes.Length); // test kodu            
            sp.WriteLine("");







        }














        #endregion







        #region PLC ADRESLERİ




        public static string id_adress = "DB47.DBD98";                                                 //%DB122.106.0
        public static string Sag_305_X_Adres = "DB79.DBD140";                                          //%DB122.DBD0
        public static string Sol_305_1_X_Adres = "DB79.DBD144";                                        //%DB122.DBD4
        public static string Sag_kol_boy_290_Y_Adres = "DB79.DBD148";                                  //%DB122.DBD8
        public static string Sol_kol_boy_290_1_Y_Adres = "DB79.DBD152";                                //%DB122.DBD12
        public static string Sonuc_Ok_Adres = "DB79.DBX156.0";                                         //%DB122.104.0
        public static string Sonuc_Nok_Adres = "DB79.DBX156.1";                                        //%DB122.104.1
        public static string Kaciklik1_Adres = "DB79.DBD162";                                          //%DB122.DBD16
        public static string Kaciklik2_Adres = "DB79.DBD166";                                          //%DB122.DBD20
        public static string Kaciklik3_Adres = "DB79.DBD170";                                          //%DB122.DBD24
        public static string Kaciklik4_Adres = "DB79.DBD174";                                          //%DB122.DBD28
        public static string Kaciklik5_Adres = "DB79.DBD178";                                         //%DB122.DBD32
        public static string Kaciklik6_Adres = "DB79.DBD182";                                         //%DB122.DBD36
        public static string Kaciklik7_Adres = "DB79.DBD186";                                        //%DB122.DBD40
        public static string Kaciklik8_Adres = "DB79.DBD190";                                        //%DB122.DBD44
        public static string Kaciklik9_Adres = "DB79.DBD194";                                        //%DB122.DBD48
        public static string Kaciklik10_Adres = "DB79.DBD198";                                       //%DB122.DBD52
        public static string degerler_okundu_adress = "DB47.DBX102.0";                              // DOKUNMA BUNA
        public static string Yedek1_Adres = "";                                                     //%DB122.76
        public static string Yedek2_Adres = "";                                                     //%DB122.80
        public static string Yedek3_Adres = "";                                                     //%DB122.84
        public static string Yedek4_Adres = "";                                                    //%DB122.88
        public static string ortam_sicaklik_adress="";                                            //%DB122.92             
        public static string ortam_nem_adress="";                                                 //%DB122.96        
        public static string tutkal_sicaklik_adress="";                                           //%DB122.100                                                               //
        public static string cevrim_suresi_adress="";                                             //%DB122.110









        public static string Tutkal_Sicaklik_Adres = "";
        public static string Ortam_Nem_Adres = "";
        public static string Ortam_Sicaklik_Adres = "";




        #endregion



        #region PLC OLCUM DEGISKENLERI

        public double Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y;
        public double Kaciklik1, Kaciklik2, Kaciklik3, Kaciklik4, Kaciklik5, Kaciklik6, Kaciklik7, Kaciklik8, Kaciklik9, Kaciklik10;
        public double Tutkal_Sicaklik, Ortam_Nem, Ortam_Sicaklik, Yedek_1, Yedek_2, Yedek_3, Yedek_4;
        public bool database_var = false;
        public int id;
        string Cevrim_Suresi = "";
        public bool Sonuc_Ok, Sonuc_Nok;
        public static string baglanti_cumlesi;
        public static string plc_ip = "192.168.1.110";
        public static string sonuc_durum = "";
        public static string Tarih = Tarih = DateTime.Now.ToString("d");
        public static string Saat = DateTime.Now.ToString("T");
        public static string Aranan_Tarih;

        public static bool plc_durum = false;
        public static int rapor_secim = 0;
        public int plc_dinleme_suresi = 500;
        public bool olcum_tamam_bit = false;
        public static Int32 olcum_adet=0;
        
        public static string Silme_Sorgusu = "Delete from  urun_db where Id>=0";
        public static string Tum_Listele_Sorgusu = "Select * From urun_db";
        public static string Tarihe_gore_Ok_Listele_Sorgusu = "Select * From urun_db";
        public static string Tarihe_gore_NOk_Listele_Sorgusu = "Select * From urun_db where Sonuc =NOK";
        public static string id_Listele_Sorgusu = "Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Cevrim_Suresi, Tutkal_Sicaklik, Ortam_Nem, Ortam_Sicaklik, Tarih  From urun_db where Id = ";
        public static string kaciklik_listele_sorgusu = "Select Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Tarih,Sonuc,Kaciklik1,Kaciklik2,Kaciklik3,Kaciklik4,Kaciklik5,Kaciklik6,Kaciklik7,Kaciklik8,Kaciklik9,Kaciklik10 From urun_db  ";
        //public static string standart_listele_sorgusu = "Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Tarih,Saat  From urun_db";
        public static string standart_listele_sorgusu = "Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Tarih,Saat From urun_db Where Tarih LIKE'%" + DateTime.Now.ToString("d")+ "%'";

        public static string sorgu = standart_listele_sorgusu;

        public static string veri_kaydet_cumlesi;


        public bool extra_goster = false;
        public bool T1T2=false;
        public bool kaciklik_kayit = false;


        public static int ıd_deger = 0;


        private void baglanti_kontrol_Tick_1(object sender, EventArgs e)
        {

            #region timer 2
            CheckForIllegalCrossThreadCalls = false;
            if (plc_durum == false)
            {
                plc_baglan();




                veri_listele(sorgu);



            }





            #endregion



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

     
        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

             if (Rapor_Secim_box.SelectedIndex == 0)
            {

                tarih_box.Visible = false;
                ID_box.Visible = false;
            }
            else  if ( Rapor_Secim_box.SelectedIndex == 1)
            {
                tarih_box.Visible = true;
                ID_box.Visible = false;


            }
            else if ( Rapor_Secim_box.SelectedIndex == 2)
            {
                tarih_box.Visible = false;
                ID_box.Visible = true;
            }
         
            else
            {
                tarih_box.Visible = false;
                ID_box.Visible = false;
            }

            Id_lbl.Visible = ID_box.Visible;
            rapor_secim = Rapor_Secim_box.SelectedIndex;

        }

        private void metroSetLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroSetSetTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void databox_CheckedChanged(object sender, EventArgs e)
        {
            if (databox.Checked==true)
            {
                database_var = true;
            }
            else
            {
                database_var = false;
            }

        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }

        
        public bool ortam_sicaklik_olcumu = false;

        private void metroSetButton1_Click(object sender, EventArgs e)
        {







            if (ID_box.Visible == true)
            {


                try
                {

                    if (ID_box.Text != "")
                    {

                        ıd_deger = Convert.ToInt32(ID_box.Text);

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("GİRİLEN DEĞER HATALI");
                    ıd_deger = 0;
                }

            }


           

                      switch (rapor_secim)
            {
                case 0:
                    //TÜMÜNÜ LİSTELE
                    sorgu ="Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Tarih,Saat  From urun_db";

                    break;
                case 1:
                    // SEÇİLEN TARİHİ LİSTELE
                    Aranan_Tarih = dateTimePicker1.Value.ToString("d");
                    string sonuc_sorgusu;
                    sonuc_sorgusu = OK_NOK_BOX.SelectedItem.ToString();


                    if (sonuc_sorgusu != "TÜM") {
                        sorgu = "Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Tarih,Saat From urun_db Where Tarih LIKE'%" + Aranan_Tarih + "%'" + "AND Sonuc= '" + sonuc_sorgusu.Trim() + "'";

                    }
                    else
                    {
                        sorgu = "Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Tarih,Saat From urun_db Where Tarih LIKE'%" + Aranan_Tarih + "%'";

                    }


                    break;
                case 2:
                    // İD LİSTELE
                    sorgu = "Select Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Cevrim_Suresi, Tutkal_Sicaklik, Ortam_Nem, Ortam_Sicaklik, Tarih,Saat  From urun_db where Id = "+ıd_deger;
                    break;
                default:
                    sorgu = standart_listele_sorgusu; 
                    break;


            }

            
           
         

            veri_listele(sorgu);


            int sayi = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)//DataGridView'ımızın satır sayısı kadar döngümüzün çalışmasını istiyoruz.
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)//DataGridView'ımızın her bir satırındaki 1.cı Cell'in value bilgisinin null olup olmadığını kontrol ediyoruz. (Sizin Kullanımınızdaki B isimli kolon)
                {
                    //Eğer null değilse, kayıt var demektir. Bu durumda Empty kontrolü yapabilirsiniz. Örn. if(string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    sayi++;
                }
            }
            if (sayi>0)
            {
                MessageBox.Show(sayi.ToString() + " ADET KAYIT LİSTELENDİ");

            }
            else
            {
                MessageBox.Show("KAYIT BULUNAMADI");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_kaydet();
        }

     
      

        private void Plc_hata_lbl_Click(object sender, EventArgs e)
        {
            Plc_hata_lbl.Text = "-";
            Plc_hata_lbl.ForeColor = metroSetLabel1.ForeColor;
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
           

            SqlConnection baglanti = new SqlConnection(@"" + baglanti_cumlesi);


            DialogResult temizle = new DialogResult();
            temizle = MessageBox.Show("Ölçüm verileri temizlensin mi? ","Temizle", MessageBoxButtons.YesNo);
            if (temizle == DialogResult.Yes)
            {
                
            try
            {
                baglanti.Open();

                string sql = "Delete from  urun_db where Id>=0";
                // string sql = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih) Values ('" + id + "','" + Sag_305_X.ToString("N4").Replace(',', '.') + "', '" + Sol_305_1_X.ToString("N4").Replace(',', '.') + "' , '" + Sag_kol_boy_290_Y.ToString("N4").Replace(',', '.') + "' , '" + Sol_kol_boy_290_1_Y.ToString("N4").Replace(',', '.') + "', '" + sonuc_durum + "', '" + Cevrim_Suresi.ToString() + "','" + Tutkal_Sicaklik.ToString() + "', '" + Ortam_Nem.ToString() + "', '" + Ortam_Sicaklik.ToString() + "','" + Tarih.ToString() + "')";

                SqlCommand komutislet = new SqlCommand(sql, baglanti);
                komutislet.ExecuteNonQuery();
                Database_lbl.Text = "BAŞARILI BAĞLANTI";
                Database_lbl.ForeColor = Color.Green;
                Database_durum_Elipse.NormalColor = Color.Green;
                Database_durum_Elipse.NormalBorderColor = Color.Green;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                Database_lbl.Text = hata.Message.ToString();
                Database_lbl.ForeColor = Color.Red;
                Database_durum_Elipse.NormalColor = Color.Red;
                Database_durum_Elipse.NormalBorderColor = Color.Red;
            }


                MessageBox.Show("Ölçüm verileri Temizlendi");
                veri_listele(kaciklik_listele_sorgusu);

            }
            else
            {

                MessageBox.Show("temizlenmedi");

            }







        }


        public bool ortam_nem_olcumu = false;


        public bool cevrim_suresi_olcumu = false;


        public bool Rezerve = false;
        #endregion




        /*
        *********************************************************************************************************************************************************************************         ******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        */













        #region config_tanımlama
        void config_dosyasi()
        {
            string dosya_yolu = Application.StartupPath + @"\config.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            try
            {

                baglanti_cumlesi = sw.ReadLine().Trim();
                plc_dinleme_suresi = Convert.ToInt32(sw.ReadLine().Trim());
                T1T2 = Convert.ToBoolean(sw.ReadLine().Trim());
                extra_goster = Convert.ToBoolean(sw.ReadLine().Trim());
                bool  yonetim_paneli= Convert.ToBoolean(sw.ReadLine().Trim());
                kaciklik_kayit = Convert.ToBoolean(sw.ReadLine().Trim());
                database_var = Convert.ToBoolean(sw.ReadLine().Trim());

                veriyaz_btn.Visible = yonetim_paneli;
                metroSetButton2.Visible = yonetim_paneli;
                //MessageBox.Show("baglanti cumlesi "+baglanti_cumlesi.ToString());
                //MessageBox.Show("plc ip adresi "+plc_ip.ToString());
                //MessageBox.Show("plc dinleme suresi " + plc_dinleme_suresi.ToString());
                //MessageBox.Show("tutkal olcum durumu "+tutkal_olcumu.ToString());
                //MessageBox.Show("ortam sıcaklığı olcum durumu " + ortam_sicaklik_olcumu.ToString());
                //MessageBox.Show("ortam nem olcum durumu "+ortam_nem_olcumu.ToString());
                //MessageBox.Show("cevrim suresi olcum durumu  "+cevrim_suresi_olcumu.ToString());
                //MessageBox.Show("menu vısıble durumu  " + menu.ToString());


                sw.Close();
                fs.Close();

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message.ToString());
            }


            // 1 SQL BAĞLANTI CÜMLESİ
            // 2 PLC DİNLEME SÜRESİ
            // 3 TİMER ON OFF
            // 4 EXTRA GÖSTER TXT
            // 5 YONETİM PANELİ
            // 6 Kaciklik_kayit
            // 7 








        }

        #endregion
















        /*
         *********************************************************************************************************************************************************************************         ******************************************************************************************************************************************************************************
         *******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
         *******************************************************************************************************************************************************************************
         *******************************************************************************************************************************************************************************
         ******************************************************************************************************************************************************************************
         ******************************************************************************************************************************************************************************
         */










        #region VERİ TABANI TANIMLAMALARI
        // SqlConnection baglanti = new SqlConnection(@""+baglanti_cumlesi);
        public void veri_listele(string SQL_SORGU)
        {
            SqlConnection baglanti = new SqlConnection(@"" + baglanti_cumlesi);
            //SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-F9FE5QL2;Initial Catalog=PC_DATA;Persist Security Info=True;User ID=erhan;Password=brc");
            try
            {

                //   SqlDataAdapter adapter = new SqlDataAdapter("Select * From urun_db", baglanti);
                // SqlDataAdapter adapter = new SqlDataAdapter("Select Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih  From urun_db  ", baglanti);
              //  SqlDataAdapter adapter = new SqlDataAdapter("Select Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Tarih,Sonuc,Kaciklik1,Kaciklik2,Kaciklik3,Kaciklik4,Kaciklik5,Kaciklik6,Kaciklik7,Kaciklik8,Kaciklik9,Kaciklik10 From urun_db  ", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(SQL_SORGU, baglanti);

                DataSet dset = new DataSet();
                baglanti.Open();
                adapter.Fill(dset, "info");
                dataGridView1.DataSource = dset.Tables[0];
                Database_lbl.Text = "BAŞARILI BAĞLANTI";
                Database_lbl.ForeColor = Color.Green;
                Database_durum_Elipse.NormalColor = Color.Green;
                Database_durum_Elipse.NormalBorderColor = Color.Green;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                Database_lbl.Text = hata.Message.ToString();
                Database_durum_Elipse.NormalColor = Color.Red;
                Database_durum_Elipse.NormalBorderColor = Color.Red;
                Database_lbl.ForeColor = Color.Red;


            }


        }

        public void veri_kaydet()
        {
            SqlConnection baglanti = new SqlConnection(@"" + baglanti_cumlesi);

            try
            {
                baglanti.Open();

                if (kaciklik_kayit)
                {
               veri_kaydet_cumlesi = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih,Saat,Kaciklik1,Kaciklik2,Kaciklik3,Kaciklik4,Kaciklik5,Kaciklik6,Kaciklik7,Kaciklik8,Kaciklik9,Kaciklik10) Values ('" + id + "','" + Sag_305_X.ToString("N4").Replace(',', '.') + "', '" + Sol_305_1_X.ToString("N4").Replace(',', '.') + "' , '" + Sag_kol_boy_290_Y.ToString("N4").Replace(',', '.') + "' , '" + Sol_kol_boy_290_1_Y.ToString("N4").Replace(',', '.') + "', '" + sonuc_durum + "', '" + Cevrim_Suresi.ToString() + "','" + Tutkal_Sicaklik.ToString() + "', '" + Ortam_Nem.ToString() + "', '" + Ortam_Sicaklik.ToString() + "','" + Tarih.ToString() + "', '" + Saat.ToString() + "', '" + Kaciklik1.ToString("N4").Replace(',', '.') + "', '" + Kaciklik2.ToString("N4").Replace(',', '.') + "', '" + Kaciklik3.ToString("N4").Replace(',', '.') + "', '" + Kaciklik4.ToString("N4").Replace(',', '.') + "', '" + Kaciklik5.ToString("N4").Replace(',', '.') + "', '" + Kaciklik6.ToString("N4").Replace(',', '.') + "', '" + Kaciklik7.ToString("N4").Replace(',', '.') + "', '" + Kaciklik8.ToString("N4").Replace(',', '.') + "', '" + Kaciklik9.ToString("N4").Replace(',', '.') + "', '" + Kaciklik10.ToString("N4").Replace(',', '.') + "')";

                    // string sql = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih,Saat,Kaciklik1,Kaciklik2,Kaciklik3,Kaciklik4,Kaciklik5,Kaciklik6,Kaciklik7,Kaciklik8,Kaciklik9,Kaciklik10) Values ('" + id + "','" + Sag_305_X.ToString("N4").Replace(',', '.') + "', '" + Sol_305_1_X.ToString("N4").Replace(',', '.') + "' , '" + Sag_kol_boy_290_Y.ToString("N4").Replace(',', '.') + "' , '" + Sol_kol_boy_290_1_Y.ToString("N4").Replace(',', '.') + "', '" + sonuc_durum + "', '" + Cevrim_Suresi.ToString() + "','" + Tutkal_Sicaklik.ToString() + "', '" + Ortam_Nem.ToString() + "', '" + Ortam_Sicaklik.ToString() + "','" + Tarih.ToString() + "', '"+Saat.ToString()+"', '" + Kaciklik1.ToString("N4").Replace(',', '.') + "', '" + Kaciklik2.ToString("N4").Replace(',', '.') + "', '" + Kaciklik3.ToString("N4").Replace(',', '.') + "', '" + Kaciklik4.ToString("N4").Replace(',', '.') + "', '" + Kaciklik5.ToString("N4").Replace(',', '.') + "', '" + Kaciklik6.ToString("N4").Replace(',', '.') + "', '" + Kaciklik7.ToString("N4").Replace(',', '.') + "', '" + Kaciklik8.ToString("N4").Replace(',', '.') + "', '" + Kaciklik9.ToString("N4").Replace(',', '.') + "', '" + Kaciklik10.ToString("N4").Replace(',', '.') + "')";

                }
                else
                {
                 veri_kaydet_cumlesi = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih,Saat) Values ('" + id + "','" + Sag_305_X.ToString("N4").Replace(',', '.') + "', '" + Sol_305_1_X.ToString("N4").Replace(',', '.') + "' , '" + Sag_kol_boy_290_Y.ToString("N4").Replace(',', '.') + "' , '" + Sol_kol_boy_290_1_Y.ToString("N4").Replace(',', '.') + "', '" + sonuc_durum + "', '" + Cevrim_Suresi.ToString() + "','" + Tutkal_Sicaklik.ToString() + "', '" + Ortam_Nem.ToString() + "', '" + Ortam_Sicaklik.ToString() + "','" + Tarih.ToString() + Saat.ToString() + "')";

                    // string sql = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih,Saat) Values ('" + id + "','" + Sag_305_X.ToString("N4").Replace(',', '.') + "', '" + Sol_305_1_X.ToString("N4").Replace(',', '.') + "' , '" + Sag_kol_boy_290_Y.ToString("N4").Replace(',', '.') + "' , '" + Sol_kol_boy_290_1_Y.ToString("N4").Replace(',', '.') + "', '" + sonuc_durum + "', '" + Cevrim_Suresi.ToString() + "','" + Tutkal_Sicaklik.ToString() + "', '" + Ortam_Nem.ToString() + "', '" + Ortam_Sicaklik.ToString() + "','" + Tarih.ToString() + Saat.ToString() + "')";

                }
                string sql = veri_kaydet_cumlesi;
                SqlCommand komutislet = new SqlCommand(sql, baglanti);
                komutislet.ExecuteNonQuery();
                Database_lbl.Text = "BAŞARILI BAĞLANTI";
                Database_lbl.ForeColor = Color.Green;
                Database_durum_Elipse.NormalColor = Color.Green;
                Database_durum_Elipse.NormalBorderColor = Color.Green;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                baglanti.Close();
                Database_lbl.Text = hata.Message.ToString();
                Database_lbl.ForeColor = Color.Red;
                Database_durum_Elipse.NormalColor = Color.Red;
                Database_durum_Elipse.NormalBorderColor = Color.Red;
            }





        }


        #endregion













        /*
        *********************************************************************************************************************************************************************************         ******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        */











        #region PLC TANIMLAMALARI
        public Plc s7_plc = new Plc(CpuType.S71200, plc_ip, 0, 1);




        void plc_baglan()
        {

            #region plc baglantı  açma

            try
            {
                if (s7_plc.IsAvailable && s7_plc.IsConnected == false)
                {
                    s7_plc.Open();
                    if (s7_plc.IsConnected == true)
                    {
                       // Plc_hata_lbl.Text = "BAŞARILI BAĞLANTI";
                        // MessageBox.Show("BAŞARILI BAĞLANTI");
                        Plc_durum_elipse.NormalColor = Color.Green;
                        Plc_durum_elipse.NormalBorderColor = Color.Green;
                        Plc_lbl.Text = "BAŞARILI BAĞLANTI";
                        Plc_lbl.ForeColor = Color.Green;
                        plc_durum = true;




                        timer1.Enabled = true;
                        timer1.Interval = plc_dinleme_suresi;
                        timer1.Start();






                    }

                }
                else
                {
                    s7_plc.Close();
                    Plc_hata_lbl.Text = "PLC BULUNAMADI YADA MEŞGUL";
                    Plc_hata_lbl.ForeColor = Color.Red;
                    // MessageBox.Show("PLC BULUNAMADI YADA MEŞGUL");
                    Plc_lbl.Text = "BAŞARISIZ BAĞLANTI";
                    Plc_durum_elipse.NormalColor = Color.Red;
                    Plc_durum_elipse.NormalBorderColor = Color.Red;
                    Plc_lbl.ForeColor = Color.Red;

                    timer1.Stop();
                    timer1.Enabled = false;
                    plc_durum = false;

                }


            }
            catch (Exception hata)
            {
                s7_plc.Close();
                Plc_hata_lbl.Text = "baglanamadi" + hata.Message.ToString();
                // MessageBox.Show("baglanamadi" + hata.Message.ToString());
                Plc_lbl.Text = "BAŞARISIZ BAĞLANTI";
                Plc_durum_elipse.NormalColor = Color.Red;
                Plc_durum_elipse.NormalBorderColor = Color.Red;
                Plc_lbl.ForeColor = Color.Red;

                timer1.Stop();
                timer1.Enabled = false;
                plc_durum = false;
            }



            #endregion

        }



        void plc_kaydet_FLAG()
        {





            if (s7_plc.IsConnected)
            {
                try
                {

                    olcum_tamam_bit = ((bool)s7_plc.Read("M2006.6"));
                    plc_durum = true;


                }
                catch (Exception hata)
                {
                    s7_plc.Close();
                    Plc_hata_lbl.Text = hata.Message.ToString();
                    // MessageBox.Show(hata.ToString());
                    Plc_lbl.Text = "BAŞARISIZ BAĞLANTI";
                    Plc_durum_elipse.NormalColor = Color.Red;
                    Plc_durum_elipse.NormalBorderColor = Color.Red;
                    Plc_lbl.ForeColor = Color.Red;

                    timer1.Enabled = false;
                    timer1.Stop();
                    plc_durum = false;

                }



            }


        }               // KAYDET FLAG

        private void baglanti_kontrol_Tick(object sender, EventArgs e)
        {


            if (plc_durum == false)
             {

               plc_baglan();

            }


        }



        void plc_standart_olcum_veri()
        {
            if (s7_plc.IsConnected)
            {
                try
                {
                    id = ((uint)s7_plc.Read(id_adress)).ConvertToInt();
                    Sag_305_X = ((uint)s7_plc.Read(Sag_305_X_Adres)).ConvertToDouble();
                    Sol_305_1_X = ((uint)s7_plc.Read(Sol_305_1_X_Adres)).ConvertToDouble();
                    Sag_kol_boy_290_Y = ((uint)s7_plc.Read(Sag_kol_boy_290_Y_Adres)).ConvertToDouble();
                    Sol_kol_boy_290_1_Y = ((uint)s7_plc.Read(Sol_kol_boy_290_1_Y_Adres)).ConvertToDouble();
                    Kaciklik1 = ((uint)s7_plc.Read(Kaciklik1_Adres)).ConvertToDouble();
                    Kaciklik2 = ((uint)s7_plc.Read(Kaciklik2_Adres)).ConvertToDouble();
                    Kaciklik3 = ((uint)s7_plc.Read(Kaciklik3_Adres)).ConvertToDouble();
                    Kaciklik4 = ((uint)s7_plc.Read(Kaciklik4_Adres)).ConvertToDouble();
                    Kaciklik5 = ((uint)s7_plc.Read(Kaciklik5_Adres)).ConvertToDouble();
                    Kaciklik6 = ((uint)s7_plc.Read(Kaciklik6_Adres)).ConvertToDouble();
                    Kaciklik7 = ((uint)s7_plc.Read(Kaciklik7_Adres)).ConvertToDouble();
                    Kaciklik8 = ((uint)s7_plc.Read(Kaciklik8_Adres)).ConvertToDouble();
                    Kaciklik9 = ((uint)s7_plc.Read(Kaciklik9_Adres)).ConvertToDouble();
                    Kaciklik10 = ((uint)s7_plc.Read(Kaciklik10_Adres)).ConvertToDouble();

                    Sonuc_Ok = ((bool)s7_plc.Read(Sonuc_Ok_Adres));
                    Sonuc_Nok = (bool)s7_plc.Read(Sonuc_Nok_Adres);









                    Sag_305_X_txt.Text = Sag_305_X.ToString("N4");
                    Sol_305_1_X_txt.Text = Sol_305_1_X.ToString("N4");
                    Sag_kol_boy_290_Y_txt.Text = Sag_kol_boy_290_Y.ToString("N4");
                    Sol_kol_boy_290_1_Y_txt.Text = Sol_kol_boy_290_1_Y.ToString("N4");
                    //Sonuc_Ok_txt.Text = Sonuc_Ok.ToString();
                    //Sonuc_Nok_txt.Text = Sonuc_Nok.ToString();

                    if (Sonuc_Ok)
                    {
                        sonuc_durum = "OK";
                        Sonuc_lbl.ForeColor = Color.Green;
                        sonuc_elipse.NormalBorderColor = Color.Green;
                        sonuc_elipse.NormalColor = Color.Green;


                    }
                    else
                    {
                        sonuc_durum = "NOK";
                        Sonuc_lbl.ForeColor = Color.Red;
                        sonuc_elipse.NormalBorderColor = Color.Red;
                        sonuc_elipse.NormalColor = Color.Red;
                    }

                    plc_durum = true;


                }
                catch (Exception hata)
                {
                    s7_plc.Close();

                    MessageBox.Show(hata.ToString());
                    timer1.Enabled = false;
                    timer1.Stop();

                    Plc_lbl.ForeColor = Color.Red;
                    Plc_lbl.Text = "BAŞARISIZ BAĞLANTI";
                    plc_durum = false;

                }



            }

        }







        #endregion


        /*
        *********************************************************************************************************************************************************************************         ******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
       ******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
        *******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        ******************************************************************************************************************************************************************************
        */






































        public Form1()
        {
            InitializeComponent();
        }



























        private void Form1_Load(object sender, EventArgs e)
        {

            if (System.Diagnostics.Process.GetProcessesByName("SQL_AKTAR V2.0").Length > 1)
            {
                MessageBox.Show("Program zaten açık.");
                Application.Exit();
            }


         






            #region ilk acılışta çalışsın
            try
            {

                config_dosyasi();

                Rapor_Secim_box.SelectedIndex = 0;
                OK_NOK_BOX.SelectedIndex = 0;
                Id_lbl.Visible = false;

                baglanti_ac();
                


                //metroSetLabel10.Visible = extra_goster;//TUTKAL SICAKLIK :
                //metroSetLabel14.Visible = extra_goster;//TUTKAL SICAKLIK txt :

                //metroSetLabel11.Visible = extra_goster;//ORTAM NEM :
                //metroSetLabel15.Visible = extra_goster;//ORTAM NEM txt :

                //metroSetLabel12.Visible = extra_goster;//ORTAM SICAKLIK :
                //metroSetLabel16.Visible = extra_goster;//ORTAM SICAKLIK  txt:






            }
            catch (Exception hata)
            {
               Database_hata_lbl.Text = hata.Message.ToString();

                MessageBox.Show(hata.Message.ToString());
            }



            if (database_var)
            {
                veri_listele(sorgu);

            }

            if (T1T2)
            {
                plc_baglan();

                baglanti_kontrol.Start();



                if (s7_plc.IsConnected)
                {
                    timer1.Enabled = true;
                    timer1.Interval = plc_dinleme_suresi;
                    timer1.Start();


                }


            }









            #endregion

            //   Rapor_box.Visible = false;

            ID_box.Visible = false;
            tarih_box.Visible = false;
        }








        #region timer 1 yapılacaklar

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            #region timer1 


            CheckForIllegalCrossThreadCalls = false;



            bool onceki_durum = olcum_tamam_bit;


            plc_kaydet_FLAG();

            if (onceki_durum != olcum_tamam_bit && olcum_tamam_bit == true)
            {

                plc_standart_olcum_veri();

                if (database_var)
                {
                     veri_kaydet();
                      veri_listele(sorgu);
                }
               






                s7_plc.Write(degerler_okundu_adress, 1);


                olcum_adet++;
                string baslik1 = "  " + Tarih_lbl.Text.ToString() + "\n  SAG_305_X  " + Sag_305_X.ToString("N4") + "\n  SOL305X  " + Sol_305_1_X.ToString("N4") + "\n  SOL290Y1  " + Sol_kol_boy_290_1_Y.ToString("N4") + "\n  SAG290Y  " + Sag_kol_boy_290_Y.ToString("N4") + "\n  M58  ";

                barkod_cikar(baslik1);

            }
            if (!olcum_tamam_bit)
            {
                s7_plc.Write(degerler_okundu_adress, 0);



            }

            //olcum_tamam_lbl.Text = olcum_tamam_bit.ToString();





            Tarih = DateTime.Now.ToString("d");
            Saat = DateTime.Now.ToString("T");

            Tarih_lbl.Text = Tarih + "  " + Saat;
            Sonuc_lbl.Text = sonuc_durum;
            olcum_sayac.Text = olcum_adet.ToString() + " ADET URUN OLCULDU ";

            #endregion







        }


        #endregion












    }
}
