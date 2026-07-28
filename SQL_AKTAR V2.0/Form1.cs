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
        SerialPort sp;




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
            string qr0 = baslik;
            string qr3 = "8001097623";
            string qr2 = "257509 00";
            string qr1 = System.DateTime.Today.ToString("d");

            string kelime = $@"05
SIZE 24.10 mm, 15 mm
DIRECTION 0,0
REFERENCE 0,0
OFFSET 0 mm
SET PEEL OFF
SET CUTTER OFF
SET PARTIAL_CUTTER OFF
SET TEAR ON
CLS
QRCODE 101,95,L,2,A,270,M2,S7,""{qr0}""
CODEPAGE 1254
TEXT 70,105,""ROMAN.TTF"",270,1,7,""{qr3}""
TEXT 44,105,""ROMAN.TTF"",270,1,7,""{qr2}""
TEXT 19,105,""ROMAN.TTF"",270,1,7,""{qr1}""
PRINT 1,1
04
";

            byte[] bytes = Encoding.ASCII.GetBytes(kelime);
            sp.Write(bytes, 0, bytes.Length);
            sp.WriteLine("");
        }














        #endregion







        #region PLC ADRESLERİ




        public static string id_adress = "DB79.DBD18";                                                 //%DB122.106.0
        public static string Sag_305_X_Adres = "DB79.DBD0";                                            //%DB122.DBD0
        public static string Sol_305_1_X_Adres = "DB79.DBD4";                                          //%DB122.DBD4
        public static string Sag_kol_boy_290_Y_Adres = "DB79.DBD8";                                    //%DB122.DBD8
        public static string Sol_kol_boy_290_1_Y_Adres = "DB79.DBD12";                                  //%DB122.DBD12
        public static string Sonuc_Ok_Adres = "DB79.DBX16.0";                                         //%DB122.104.0
        public static string Sonuc_Nok_Adres = "DB79.DBX16.1";                                        //%DB122.104.1
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
        public static string degerler_okundu_adress = "DB79.DBX22.0";                              // DOKUNMA BUNA
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
        public static string plc_ip = "169.254.37.171";
        public static string sonuc_durum = "";
        public static string Tarih = Tarih = DateTime.Now.ToString("d");
        public static string Saat = DateTime.Now.ToString("T");
        public static string Aranan_Tarih;

        public static bool plc_durum = false;
        public static int rapor_secim = 0;
        public int plc_dinleme_suresi = 500;
        public bool olcum_tamam_bit = false;
        public static Int32 olcum_adet=0;
        public const string BaseSelectColumns = "Id, Sag_305_X, Sol_305_1_X, Sag_kol_boy_290_Y, Sol_kol_boy_290_1_Y, Sonuc, Tarih, Saat";
        public const string ExtraSelectColumns = "Cevrim_Suresi, Tutkal_Sicaklik, Ortam_Nem, Ortam_Sicaklik";
        public const string KaciklikSelectColumns = "Kaciklik1, Kaciklik2, Kaciklik3, Kaciklik4, Kaciklik5, Kaciklik6, Kaciklik7, Kaciklik8, Kaciklik9, Kaciklik10";

        public static string Silme_Sorgusu = "Delete from urun_db where Id>=0";
        public static string Tum_Listele_Sorgusu = $"Select {BaseSelectColumns} From urun_db";
        public static string Tarihe_gore_Ok_Listele_Sorgusu = $"Select {BaseSelectColumns} From urun_db";
        public static string Tarihe_gore_NOk_Listele_Sorgusu = $"Select {BaseSelectColumns} From urun_db where Sonuc = 'NOK'";
        public static string id_Listele_Sorgusu = $"Select {BaseSelectColumns}, {ExtraSelectColumns} From urun_db where Id = ";
        public static string kaciklik_listele_sorgusu = $"Select {BaseSelectColumns}, {KaciklikSelectColumns} From urun_db";
        public static string standart_listele_sorgusu = $"Select {BaseSelectColumns} From urun_db Where Tarih LIKE '%{DateTime.Now.ToString("d")}%'";

        public static string sorgu = standart_listele_sorgusu;
        public static string veri_kaydet_cumlesi;


        public bool extra_goster = false;
        public bool T1T2=false;
        public bool kaciklik_kayit = false;


        public static int ıd_deger = 0;


        private void baglanti_kontrol_Tick_1(object sender, EventArgs e)
        {

            #region timer 2
            if (plc_durum == false)
            {
                plc_baglan();

                if (database_var)
                {
                    veri_listele(sorgu);
                }
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
                    sorgu = $"Select {BaseSelectColumns} From urun_db";
                    break;
                case 1:
                    // SEÇİLEN TARİHİ LİSTELE
                    Aranan_Tarih = dateTimePicker1.Value.ToString("d");
                    string sonuc_sorgusu = OK_NOK_BOX.SelectedItem.ToString();

                    if (sonuc_sorgusu != "TÜM") 
                    {
                        sorgu = $"Select {BaseSelectColumns} From urun_db Where Tarih LIKE '%{Aranan_Tarih}%' AND Sonuc = '{sonuc_sorgusu.Trim()}'";
                    }
                    else
                    {
                        sorgu = $"Select {BaseSelectColumns} From urun_db Where Tarih LIKE '%{Aranan_Tarih}%'";
                    }
                    break;
                case 2:
                    // İD LİSTELE
                    sorgu = $"Select {BaseSelectColumns}, {ExtraSelectColumns} From urun_db where Id = {ıd_deger}";
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
            DialogResult temizle = MessageBox.Show("Ölçüm verileri temizlensin mi? ", "Temizle", MessageBoxButtons.YesNo);
            if (temizle == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection baglanti = new SqlConnection(baglanti_cumlesi))
                    using (SqlCommand komutislet = new SqlCommand("Delete from urun_db where Id>=0", baglanti))
                    {
                        baglanti.Open();
                        komutislet.ExecuteNonQuery();
                        Database_lbl.Text = "BAŞARILI BAĞLANTI";
                        Database_lbl.ForeColor = Color.Green;
                        Database_durum_Elipse.NormalColor = Color.Green;
                        Database_durum_Elipse.NormalBorderColor = Color.Green;
                    }
                    MessageBox.Show("Ölçüm verileri Temizlendi");
                    veri_listele(kaciklik_listele_sorgusu);
                }
                catch (Exception hata)
                {
                    Database_lbl.Text = hata.Message;
                    Database_lbl.ForeColor = Color.Red;
                    Database_durum_Elipse.NormalColor = Color.Red;
                    Database_durum_Elipse.NormalBorderColor = Color.Red;
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + hata.Message);
                }
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













        #region config_tanımlama
        void config_dosyasi()
        {
            string dosya_yolu = Path.Combine(Application.StartupPath, "config.txt");
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("config.txt dosyası bulunamadı. Varsayılan ayarlar kullanılacak.");
                sp = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);
                s7_plc = new Plc(CpuType.S71200, plc_ip, 0, 1);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
                using (StreamReader sw = new StreamReader(fs))
                {
                    baglanti_cumlesi = sw.ReadLine()?.Trim();
                    
                    string line2 = sw.ReadLine();
                    if (!string.IsNullOrEmpty(line2)) plc_dinleme_suresi = Convert.ToInt32(line2.Trim());
                    
                    string line3 = sw.ReadLine();
                    if (!string.IsNullOrEmpty(line3)) T1T2 = Convert.ToBoolean(line3.Trim());
                    
                    string line4 = sw.ReadLine();
                    if (!string.IsNullOrEmpty(line4)) extra_goster = Convert.ToBoolean(line4.Trim());
                    
                    string line5 = sw.ReadLine();
                    bool yonetim_paneli = false;
                    if (!string.IsNullOrEmpty(line5)) yonetim_paneli = Convert.ToBoolean(line5.Trim());
                    
                    string line6 = sw.ReadLine();
                    if (!string.IsNullOrEmpty(line6)) kaciklik_kayit = Convert.ToBoolean(line6.Trim());
                    
                    string line7 = sw.ReadLine();
                    if (!string.IsNullOrEmpty(line7)) database_var = Convert.ToBoolean(line7.Trim());
                    databox.Checked = database_var;

                    veriyaz_btn.Visible = yonetim_paneli;
                    metroSetButton2.Visible = yonetim_paneli;

                    // Line 8 - Alternative database connection string (ignored but read)
                    sw.ReadLine();

                    // Line 9 - PLC IP
                    string line9 = sw.ReadLine();
                    if (!string.IsNullOrEmpty(line9))
                    {
                        plc_ip = line9.Trim();
                    }
                    else
                    {
                        plc_ip = "192.168.1.110";
                    }

                    // Line 10 - COM Port
                    string line10 = sw.ReadLine();
                    string com_port = "COM7";
                    if (!string.IsNullOrEmpty(line10))
                    {
                        com_port = line10.Trim();
                    }
                    
                    sp = new SerialPort(com_port, 9600, Parity.None, 8, StopBits.One);
                    s7_plc = new Plc(CpuType.S71200, plc_ip, 0, 1);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Konfigürasyon dosyası okunurken hata oluştu: " + hata.Message);
                if (sp == null)
                {
                    sp = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);
                }
                if (s7_plc == null)
                {
                    s7_plc = new Plc(CpuType.S71200, plc_ip, 0, 1);
                }
            }
        }

        #endregion
















        #region VERİ TABANI TANIMLAMALARI
        public void veri_listele(string SQL_SORGU)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglanti_cumlesi))
                using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_SORGU, baglanti))
                {
                    DataSet dset = new DataSet();
                    baglanti.Open();
                    adapter.Fill(dset, "info");
                    dataGridView1.DataSource = dset.Tables[0];
                    BeautifyGrid(dataGridView1);
                    Database_lbl.Text = "BAŞARILI BAĞLANTI";
                    Database_lbl.ForeColor = Color.Green;
                    Database_durum_Elipse.NormalColor = Color.Green;
                    Database_durum_Elipse.NormalBorderColor = Color.Green;
                }
            }
            catch (Exception hata)
            {
                Database_lbl.Text = hata.Message;
                Database_durum_Elipse.NormalColor = Color.Red;
                Database_durum_Elipse.NormalBorderColor = Color.Red;
                Database_lbl.ForeColor = Color.Red;
            }
        }

        private void BeautifyGrid(DataGridView dgv)
        {
            try
            {
                // Temel stil ayarları
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.GridColor = Color.FromArgb(224, 224, 224);
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.MultiSelect = false;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ReadOnly = true;

                // Satır yüksekliği ve yazı tipi
                dgv.RowTemplate.Height = 35;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254);
                dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 103, 210);

                // Çift satır renklendirme (Zebra)
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

                // Başlık stili
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersHeight = 40;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59); // Koyu Lacivert / Slate
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Hücre hizalamaları
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Kolon başlıklarını Türkçe ve düzgün yapalım
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    switch (col.Name)
                    {
                        case "Id": col.HeaderText = "ID"; col.Width = 60; break;
                        case "Sag_305_X": col.HeaderText = "Sağ 305 X"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Sol_305_1_X": col.HeaderText = "Sol 305 X"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Sag_kol_boy_290_Y": col.HeaderText = "Sağ Kol Y"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Sol_kol_boy_290_1_Y": col.HeaderText = "Sol Kol Y"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Sonuc": col.HeaderText = "Sonuç"; col.Width = 80; break;
                        case "Cevrim_Suresi": col.HeaderText = "Çevrim Sn."; break;
                        case "Tutkal_Sicaklik": col.HeaderText = "Tutkal °C"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Ortam_Nem": col.HeaderText = "Nem %"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Ortam_Sicaklik": col.HeaderText = "Ortam °C"; col.DefaultCellStyle.Format = "N3"; break;
                        case "Tarih": col.HeaderText = "Tarih"; col.Width = 150; break;
                        case "Saat": col.HeaderText = "Saat"; col.Width = 100; break;
                        case "Kod": col.HeaderText = "Alarm Kodu"; col.Width = 100; break;
                        case "Mesaj": col.HeaderText = "Hata Mesajı"; break;
                        case "Durum": col.HeaderText = "Durum"; col.Width = 120; break;
                        default:
                            if (col.Name.StartsWith("Kaciklik"))
                            {
                                col.HeaderText = "Kaçıklık " + col.Name.Replace("Kaciklik", "");
                                col.DefaultCellStyle.Format = "N3";
                            }
                            break;
                    }
                }

                // Kolonları dolduracak şekilde ayarla
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Sonuc" && e.Value != null)
                {
                    string val = e.Value.ToString().Trim();
                    if (val == "OK")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    }
                    else if (val == "NOK")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    }
                }
            }
            catch { }
        }

        private void YukleAlarmVerileri()
        {
            try
            {
                // Alt kontrol paneli oluştur
                Panel bottomPanel = new Panel();
                bottomPanel.Dock = DockStyle.Bottom;
                bottomPanel.Height = 60;
                bottomPanel.BackColor = Color.White;
                metroSetSetTabPage2.Controls.Add(bottomPanel);

                // Grid oluştur ve fill yap
                DataGridView alarmGrid = new DataGridView();
                alarmGrid.Name = "alarmGrid";
                alarmGrid.Dock = DockStyle.Fill;
                metroSetSetTabPage2.Controls.Add(alarmGrid);

                // Temizleme Butonu oluştur
                MetroSet_UI.Controls.MetroSetButton clearAlarmsBtn = new MetroSet_UI.Controls.MetroSetButton();
                clearAlarmsBtn.Text = "ALARMLARI TEMİZLE";
                clearAlarmsBtn.Size = new Size(180, 35);
                clearAlarmsBtn.Location = new Point(10, 12);
                clearAlarmsBtn.Style = MetroSet_UI.Enums.Style.Light;
                clearAlarmsBtn.ThemeName = "MetroLite";
                bottomPanel.Controls.Add(clearAlarmsBtn);

                // Temizleme olayı
                clearAlarmsBtn.Click += (s, ev) =>
                {
                    DialogResult temizle = MessageBox.Show("Tüm alarm kayıtları temizlensin mi?", "Alarmları Temizle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (temizle == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection baglanti = new SqlConnection(baglanti_cumlesi))
                            using (SqlCommand komutislet = new SqlCommand("Delete from alarm_db", baglanti))
                            {
                                baglanti.Open();
                                komutislet.ExecuteNonQuery();
                            }
                            MessageBox.Show("Alarm kayıtları başarıyla temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Grid'i yenile
                            if (database_var)
                            {
                                using (SqlConnection baglanti = new SqlConnection(baglanti_cumlesi))
                                using (SqlDataAdapter adapter = new SqlDataAdapter("Select Tarih, Kod, Mesaj, Durum From alarm_db Order By Id Desc", baglanti))
                                {
                                    DataSet dset = new DataSet();
                                    baglanti.Open();
                                    adapter.Fill(dset, "alarms");
                                    alarmGrid.DataSource = dset.Tables[0];
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };

                if (database_var)
                {
                    using (SqlConnection baglanti = new SqlConnection(baglanti_cumlesi))
                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select Tarih, Kod, Mesaj, Durum From alarm_db Order By Id Desc", baglanti))
                    {
                        DataSet dset = new DataSet();
                        baglanti.Open();
                        adapter.Fill(dset, "alarms");
                        alarmGrid.DataSource = dset.Tables[0];
                    }
                }
                
                // Grid'i güzelleştir
                BeautifyGrid(alarmGrid);
                
                // Alarm grid için özel renklendirme olayı
                alarmGrid.CellFormatting += (s, e) =>
                {
                    try
                    {
                        if (alarmGrid.Columns[e.ColumnIndex].Name == "Durum" && e.Value != null)
                        {
                            string val = e.Value.ToString().Trim();
                            if (val == "Aktif")
                            {
                                e.CellStyle.ForeColor = Color.Red;
                                e.CellStyle.Font = new Font(alarmGrid.Font, FontStyle.Bold);
                            }
                            else if (val == "Temizlendi")
                            {
                                e.CellStyle.ForeColor = Color.Green;
                                e.CellStyle.Font = new Font(alarmGrid.Font, FontStyle.Regular);
                            }
                        }
                    }
                    catch { }
                };
            }
            catch { }
        }

        public void veri_kaydet()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglanti_cumlesi))
                {
                    string sql;
                    if (kaciklik_kayit)
                    {
                        sql = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih,Saat,Kaciklik1,Kaciklik2,Kaciklik3,Kaciklik4,Kaciklik5,Kaciklik6,Kaciklik7,Kaciklik8,Kaciklik9,Kaciklik10) " +
                              "Values (@Id,@Sag_305_X,@Sol_305_1_X,@Sag_kol_boy_290_Y,@Sol_kol_boy_290_1_Y,@Sonuc,@Cevrim_Suresi,@Tutkal_Sicaklik,@Ortam_Nem,@Ortam_Sicaklik,@Tarih,@Saat,@Kaciklik1,@Kaciklik2,@Kaciklik3,@Kaciklik4,@Kaciklik5,@Kaciklik6,@Kaciklik7,@Kaciklik8,@Kaciklik9,@Kaciklik10)";
                    }
                    else
                    {
                        sql = "insert into urun_db(Id,Sag_305_X,Sol_305_1_X,Sag_kol_boy_290_Y,Sol_kol_boy_290_1_Y,Sonuc,Cevrim_Suresi,Tutkal_Sicaklik,Ortam_Nem,Ortam_Sicaklik,Tarih,Saat) " +
                              "Values (@Id,@Sag_305_X,@Sol_305_1_X,@Sag_kol_boy_290_Y,@Sol_kol_boy_290_1_Y,@Sonuc,@Cevrim_Suresi,@Tutkal_Sicaklik,@Ortam_Nem,@Ortam_Sicaklik,@Tarih,@Saat)";
                    }

                    using (SqlCommand komutislet = new SqlCommand(sql, baglanti))
                    {
                        komutislet.Parameters.AddWithValue("@Id", id);
                        komutislet.Parameters.AddWithValue("@Sag_305_X", Sag_305_X);
                        komutislet.Parameters.AddWithValue("@Sol_305_1_X", Sol_305_1_X);
                        komutislet.Parameters.AddWithValue("@Sag_kol_boy_290_Y", Sag_kol_boy_290_Y);
                        komutislet.Parameters.AddWithValue("@Sol_kol_boy_290_1_Y", Sol_kol_boy_290_1_Y);
                        komutislet.Parameters.AddWithValue("@Sonuc", sonuc_durum ?? "");
                        komutislet.Parameters.AddWithValue("@Cevrim_Suresi", Cevrim_Suresi ?? "");
                        komutislet.Parameters.AddWithValue("@Tutkal_Sicaklik", Tutkal_Sicaklik);
                        komutislet.Parameters.AddWithValue("@Ortam_Nem", Ortam_Nem);
                        komutislet.Parameters.AddWithValue("@Ortam_Sicaklik", Ortam_Sicaklik);
                        komutislet.Parameters.AddWithValue("@Tarih", Tarih ?? "");
                        komutislet.Parameters.AddWithValue("@Saat", Saat ?? "");

                        if (kaciklik_kayit)
                        {
                            komutislet.Parameters.AddWithValue("@Kaciklik1", Kaciklik1);
                            komutislet.Parameters.AddWithValue("@Kaciklik2", Kaciklik2);
                            komutislet.Parameters.AddWithValue("@Kaciklik3", Kaciklik3);
                            komutislet.Parameters.AddWithValue("@Kaciklik4", Kaciklik4);
                            komutislet.Parameters.AddWithValue("@Kaciklik5", Kaciklik5);
                            komutislet.Parameters.AddWithValue("@Kaciklik6", Kaciklik6);
                            komutislet.Parameters.AddWithValue("@Kaciklik7", Kaciklik7);
                            komutislet.Parameters.AddWithValue("@Kaciklik8", Kaciklik8);
                            komutislet.Parameters.AddWithValue("@Kaciklik9", Kaciklik9);
                            komutislet.Parameters.AddWithValue("@Kaciklik10", Kaciklik10);
                        }

                        baglanti.Open();
                        komutislet.ExecuteNonQuery();

                        Database_lbl.Text = "BAŞARILI BAĞLANTI";
                        Database_lbl.ForeColor = Color.Green;
                        Database_durum_Elipse.NormalColor = Color.Green;
                        Database_durum_Elipse.NormalBorderColor = Color.Green;
                    }
                }
            }
            catch (Exception hata)
            {
                Database_lbl.Text = hata.Message;
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
        public Plc s7_plc;




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
                    // Kaciklik1 = ((uint)s7_plc.Read(Kaciklik1_Adres)).ConvertToDouble();
                    // Kaciklik2 = ((uint)s7_plc.Read(Kaciklik2_Adres)).ConvertToDouble();
                    // Kaciklik3 = ((uint)s7_plc.Read(Kaciklik3_Adres)).ConvertToDouble();
                    // Kaciklik4 = ((uint)s7_plc.Read(Kaciklik4_Adres)).ConvertToDouble();
                    // Kaciklik5 = ((uint)s7_plc.Read(Kaciklik5_Adres)).ConvertToDouble();
                    // Kaciklik6 = ((uint)s7_plc.Read(Kaciklik6_Adres)).ConvertToDouble();
                    // Kaciklik7 = ((uint)s7_plc.Read(Kaciklik7_Adres)).ConvertToDouble();
                    // Kaciklik8 = ((uint)s7_plc.Read(Kaciklik8_Adres)).ConvertToDouble();
                    // Kaciklik9 = ((uint)s7_plc.Read(Kaciklik9_Adres)).ConvertToDouble();
                    // Kaciklik10 = ((uint)s7_plc.Read(Kaciklik10_Adres)).ConvertToDouble();

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
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
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
                YukleAlarmVerileri();
                


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

                // barkod_cikar(baslik1);

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
