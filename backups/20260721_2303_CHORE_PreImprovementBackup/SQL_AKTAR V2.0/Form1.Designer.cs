
namespace SQL_AKTAR_V2._0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.baglanti_kontrol = new System.Windows.Forms.Timer(this.components);
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetSetTabPage3 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.databox = new System.Windows.Forms.CheckBox();
            this.sonuc_elipse = new MetroSet_UI.Controls.MetroSetEllipse();
            this.Database_durum_Elipse = new MetroSet_UI.Controls.MetroSetEllipse();
            this.Plc_durum_elipse = new MetroSet_UI.Controls.MetroSetEllipse();
            this.metroSetLabel26 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel25 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel23 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Database_hata_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel22 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Plc_hata_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel21 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Plc_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.olcum_sayac = new MetroSet_UI.Controls.MetroSetLabel();
            this.Tarih_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.Sonuc_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.Database_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel19 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel17 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Sol_kol_boy_290_1_Y_txt = new MetroSet_UI.Controls.MetroSetLabel();
            this.Sag_kol_boy_290_Y_txt = new MetroSet_UI.Controls.MetroSetLabel();
            this.Sol_305_1_X_txt = new MetroSet_UI.Controls.MetroSetLabel();
            this.Sag_305_X_txt = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Rapor_box = new System.Windows.Forms.GroupBox();
            this.Id_lbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.ID_box = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tarih_box = new System.Windows.Forms.GroupBox();
            this.OK_NOK_BOX = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Listele_btn = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Rapor_Secim_box = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetSetTabPage4 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.veriyaz_btn = new System.Windows.Forms.Button();
            this.metroSetControlBox2 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroSetTabControl1.SuspendLayout();
            this.metroSetSetTabPage3.SuspendLayout();
            this.metroSetSetTabPage1.SuspendLayout();
            this.Rapor_box.SuspendLayout();
            this.tarih_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroSetSetTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // baglanti_kontrol
            // 
            this.baglanti_kontrol.Interval = 5000;
            this.baglanti_kontrol.Tick += new System.EventHandler(this.baglanti_kontrol_Tick_1);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(521, 0);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(0, 0);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 2;
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLight";
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\eakop\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLight";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage3);
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage1);
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage2);
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage4);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(5, 175);
            this.metroSetTabControl1.Multiline = true;
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1908, 845);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 0;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLight";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // metroSetSetTabPage3
            // 
            this.metroSetSetTabPage3.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage3.Controls.Add(this.databox);
            this.metroSetSetTabPage3.Controls.Add(this.sonuc_elipse);
            this.metroSetSetTabPage3.Controls.Add(this.Database_durum_Elipse);
            this.metroSetSetTabPage3.Controls.Add(this.Plc_durum_elipse);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel26);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel25);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel23);
            this.metroSetSetTabPage3.Controls.Add(this.Database_hata_lbl);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel22);
            this.metroSetSetTabPage3.Controls.Add(this.Plc_hata_lbl);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel21);
            this.metroSetSetTabPage3.Controls.Add(this.Plc_lbl);
            this.metroSetSetTabPage3.Controls.Add(this.olcum_sayac);
            this.metroSetSetTabPage3.Controls.Add(this.Tarih_lbl);
            this.metroSetSetTabPage3.Controls.Add(this.Sonuc_lbl);
            this.metroSetSetTabPage3.Controls.Add(this.Database_lbl);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel19);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel17);
            this.metroSetSetTabPage3.Controls.Add(this.Sol_kol_boy_290_1_Y_txt);
            this.metroSetSetTabPage3.Controls.Add(this.Sag_kol_boy_290_Y_txt);
            this.metroSetSetTabPage3.Controls.Add(this.Sol_305_1_X_txt);
            this.metroSetSetTabPage3.Controls.Add(this.Sag_305_X_txt);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel4);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel3);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel2);
            this.metroSetSetTabPage3.Controls.Add(this.metroSetLabel1);
            this.metroSetSetTabPage3.Font = null;
            this.metroSetSetTabPage3.ImageIndex = 0;
            this.metroSetSetTabPage3.ImageKey = null;
            this.metroSetSetTabPage3.IsDerivedStyle = true;
            this.metroSetSetTabPage3.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage3.Name = "metroSetSetTabPage3";
            this.metroSetSetTabPage3.Size = new System.Drawing.Size(1900, 799);
            this.metroSetSetTabPage3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage3.StyleManager = this.styleManager1;
            this.metroSetSetTabPage3.TabIndex = 2;
            this.metroSetSetTabPage3.Text = "ANASAYFA";
            this.metroSetSetTabPage3.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage3.ThemeName = "MetroLite";
            this.metroSetSetTabPage3.ToolTipText = null;
            this.metroSetSetTabPage3.Click += new System.EventHandler(this.metroSetSetTabPage3_Click);
            // 
            // databox
            // 
            this.databox.AutoSize = true;
            this.databox.Location = new System.Drawing.Point(23, 530);
            this.databox.Name = "databox";
            this.databox.Size = new System.Drawing.Size(142, 21);
            this.databox.TabIndex = 76;
            this.databox.Text = "DATABASE AKTİF";
            this.databox.UseVisualStyleBackColor = true;
            this.databox.CheckedChanged += new System.EventHandler(this.databox_CheckedChanged);
            // 
            // sonuc_elipse
            // 
            this.sonuc_elipse.BorderThickness = 7;
            this.sonuc_elipse.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sonuc_elipse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.sonuc_elipse.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.sonuc_elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sonuc_elipse.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sonuc_elipse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sonuc_elipse.HoverTextColor = System.Drawing.Color.White;
            this.sonuc_elipse.Image = null;
            this.sonuc_elipse.ImageSize = new System.Drawing.Size(64, 64);
            this.sonuc_elipse.IsDerivedStyle = true;
            this.sonuc_elipse.Location = new System.Drawing.Point(307, 112);
            this.sonuc_elipse.Margin = new System.Windows.Forms.Padding(2);
            this.sonuc_elipse.Name = "sonuc_elipse";
            this.sonuc_elipse.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sonuc_elipse.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.sonuc_elipse.NormalTextColor = System.Drawing.Color.Black;
            this.sonuc_elipse.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sonuc_elipse.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sonuc_elipse.PressTextColor = System.Drawing.Color.White;
            this.sonuc_elipse.Size = new System.Drawing.Size(38, 39);
            this.sonuc_elipse.Style = MetroSet_UI.Enums.Style.Light;
            this.sonuc_elipse.StyleManager = this.styleManager1;
            this.sonuc_elipse.TabIndex = 75;
            this.sonuc_elipse.ThemeAuthor = "Narwin";
            this.sonuc_elipse.ThemeName = "MetroLight";
            // 
            // Database_durum_Elipse
            // 
            this.Database_durum_Elipse.BorderThickness = 7;
            this.Database_durum_Elipse.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Database_durum_Elipse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Database_durum_Elipse.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Database_durum_Elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Database_durum_Elipse.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Database_durum_Elipse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Database_durum_Elipse.HoverTextColor = System.Drawing.Color.White;
            this.Database_durum_Elipse.Image = null;
            this.Database_durum_Elipse.ImageSize = new System.Drawing.Size(64, 64);
            this.Database_durum_Elipse.IsDerivedStyle = true;
            this.Database_durum_Elipse.Location = new System.Drawing.Point(307, 228);
            this.Database_durum_Elipse.Margin = new System.Windows.Forms.Padding(2);
            this.Database_durum_Elipse.Name = "Database_durum_Elipse";
            this.Database_durum_Elipse.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Database_durum_Elipse.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Database_durum_Elipse.NormalTextColor = System.Drawing.Color.Black;
            this.Database_durum_Elipse.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Database_durum_Elipse.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Database_durum_Elipse.PressTextColor = System.Drawing.Color.White;
            this.Database_durum_Elipse.Size = new System.Drawing.Size(38, 39);
            this.Database_durum_Elipse.Style = MetroSet_UI.Enums.Style.Light;
            this.Database_durum_Elipse.StyleManager = this.styleManager1;
            this.Database_durum_Elipse.TabIndex = 74;
            this.Database_durum_Elipse.ThemeAuthor = "Narwin";
            this.Database_durum_Elipse.ThemeName = "MetroLight";
            // 
            // Plc_durum_elipse
            // 
            this.Plc_durum_elipse.BorderThickness = 7;
            this.Plc_durum_elipse.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Plc_durum_elipse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Plc_durum_elipse.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Plc_durum_elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Plc_durum_elipse.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Plc_durum_elipse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Plc_durum_elipse.HoverTextColor = System.Drawing.Color.White;
            this.Plc_durum_elipse.Image = null;
            this.Plc_durum_elipse.ImageSize = new System.Drawing.Size(64, 64);
            this.Plc_durum_elipse.IsDerivedStyle = true;
            this.Plc_durum_elipse.Location = new System.Drawing.Point(307, 164);
            this.Plc_durum_elipse.Margin = new System.Windows.Forms.Padding(2);
            this.Plc_durum_elipse.Name = "Plc_durum_elipse";
            this.Plc_durum_elipse.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Plc_durum_elipse.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Plc_durum_elipse.NormalTextColor = System.Drawing.Color.Black;
            this.Plc_durum_elipse.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Plc_durum_elipse.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Plc_durum_elipse.PressTextColor = System.Drawing.Color.White;
            this.Plc_durum_elipse.Size = new System.Drawing.Size(38, 39);
            this.Plc_durum_elipse.Style = MetroSet_UI.Enums.Style.Light;
            this.Plc_durum_elipse.StyleManager = this.styleManager1;
            this.Plc_durum_elipse.TabIndex = 73;
            this.Plc_durum_elipse.ThemeAuthor = "Narwin";
            this.Plc_durum_elipse.ThemeName = "MetroLight";
            // 
            // metroSetLabel26
            // 
            this.metroSetLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel26.IsDerivedStyle = true;
            this.metroSetLabel26.Location = new System.Drawing.Point(11, 115);
            this.metroSetLabel26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel26.Name = "metroSetLabel26";
            this.metroSetLabel26.Size = new System.Drawing.Size(154, 33);
            this.metroSetLabel26.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel26.StyleManager = this.styleManager1;
            this.metroSetLabel26.TabIndex = 72;
            this.metroSetLabel26.Text = "SONUC  : ";
            this.metroSetLabel26.ThemeAuthor = "Narwin";
            this.metroSetLabel26.ThemeName = "MetroLight";
            // 
            // metroSetLabel25
            // 
            this.metroSetLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel25.IsDerivedStyle = true;
            this.metroSetLabel25.Location = new System.Drawing.Point(8, 450);
            this.metroSetLabel25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel25.Name = "metroSetLabel25";
            this.metroSetLabel25.Size = new System.Drawing.Size(221, 33);
            this.metroSetLabel25.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel25.StyleManager = this.styleManager1;
            this.metroSetLabel25.TabIndex = 72;
            this.metroSetLabel25.Text = "OLCUM SAYAC :";
            this.metroSetLabel25.ThemeAuthor = "Narwin";
            this.metroSetLabel25.ThemeName = "MetroLight";
            // 
            // metroSetLabel23
            // 
            this.metroSetLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel23.IsDerivedStyle = true;
            this.metroSetLabel23.Location = new System.Drawing.Point(11, 394);
            this.metroSetLabel23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel23.Name = "metroSetLabel23";
            this.metroSetLabel23.Size = new System.Drawing.Size(285, 33);
            this.metroSetLabel23.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel23.StyleManager = this.styleManager1;
            this.metroSetLabel23.TabIndex = 72;
            this.metroSetLabel23.Text = "TARİH SAAT :";
            this.metroSetLabel23.ThemeAuthor = "Narwin";
            this.metroSetLabel23.ThemeName = "MetroLight";
            this.metroSetLabel23.Click += new System.EventHandler(this.metroSetLabel23_Click);
            // 
            // Database_hata_lbl
            // 
            this.Database_hata_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database_hata_lbl.IsDerivedStyle = true;
            this.Database_hata_lbl.Location = new System.Drawing.Point(400, 341);
            this.Database_hata_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Database_hata_lbl.Name = "Database_hata_lbl";
            this.Database_hata_lbl.Size = new System.Drawing.Size(516, 33);
            this.Database_hata_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Database_hata_lbl.StyleManager = this.styleManager1;
            this.Database_hata_lbl.TabIndex = 72;
            this.Database_hata_lbl.Text = "-";
            this.Database_hata_lbl.ThemeAuthor = "Narwin";
            this.Database_hata_lbl.ThemeName = "MetroLight";
            // 
            // metroSetLabel22
            // 
            this.metroSetLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel22.IsDerivedStyle = true;
            this.metroSetLabel22.Location = new System.Drawing.Point(11, 341);
            this.metroSetLabel22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel22.Name = "metroSetLabel22";
            this.metroSetLabel22.Size = new System.Drawing.Size(374, 33);
            this.metroSetLabel22.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel22.StyleManager = this.styleManager1;
            this.metroSetLabel22.TabIndex = 72;
            this.metroSetLabel22.Text = "DATABASE EROR CODE : ";
            this.metroSetLabel22.ThemeAuthor = "Narwin";
            this.metroSetLabel22.ThemeName = "MetroLight";
            // 
            // Plc_hata_lbl
            // 
            this.Plc_hata_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plc_hata_lbl.IsDerivedStyle = true;
            this.Plc_hata_lbl.Location = new System.Drawing.Point(400, 287);
            this.Plc_hata_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Plc_hata_lbl.Name = "Plc_hata_lbl";
            this.Plc_hata_lbl.Size = new System.Drawing.Size(516, 33);
            this.Plc_hata_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Plc_hata_lbl.StyleManager = this.styleManager1;
            this.Plc_hata_lbl.TabIndex = 72;
            this.Plc_hata_lbl.Text = "-";
            this.Plc_hata_lbl.ThemeAuthor = "Narwin";
            this.Plc_hata_lbl.ThemeName = "MetroLight";
            this.Plc_hata_lbl.Click += new System.EventHandler(this.Plc_hata_lbl_Click);
            // 
            // metroSetLabel21
            // 
            this.metroSetLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel21.IsDerivedStyle = true;
            this.metroSetLabel21.Location = new System.Drawing.Point(11, 287);
            this.metroSetLabel21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel21.Name = "metroSetLabel21";
            this.metroSetLabel21.Size = new System.Drawing.Size(276, 33);
            this.metroSetLabel21.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel21.StyleManager = this.styleManager1;
            this.metroSetLabel21.TabIndex = 72;
            this.metroSetLabel21.Text = "PLC EROR CODE : ";
            this.metroSetLabel21.ThemeAuthor = "Narwin";
            this.metroSetLabel21.ThemeName = "MetroLight";
            // 
            // Plc_lbl
            // 
            this.Plc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plc_lbl.IsDerivedStyle = true;
            this.Plc_lbl.Location = new System.Drawing.Point(400, 167);
            this.Plc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Plc_lbl.Name = "Plc_lbl";
            this.Plc_lbl.Size = new System.Drawing.Size(516, 33);
            this.Plc_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Plc_lbl.StyleManager = this.styleManager1;
            this.Plc_lbl.TabIndex = 72;
            this.Plc_lbl.Text = "--";
            this.Plc_lbl.ThemeAuthor = "Narwin";
            this.Plc_lbl.ThemeName = "MetroLight";
            // 
            // olcum_sayac
            // 
            this.olcum_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olcum_sayac.IsDerivedStyle = true;
            this.olcum_sayac.Location = new System.Drawing.Point(397, 450);
            this.olcum_sayac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.olcum_sayac.Name = "olcum_sayac";
            this.olcum_sayac.Size = new System.Drawing.Size(888, 33);
            this.olcum_sayac.Style = MetroSet_UI.Enums.Style.Light;
            this.olcum_sayac.StyleManager = this.styleManager1;
            this.olcum_sayac.TabIndex = 72;
            this.olcum_sayac.Text = "--";
            this.olcum_sayac.ThemeAuthor = "Narwin";
            this.olcum_sayac.ThemeName = "MetroLight";
            // 
            // Tarih_lbl
            // 
            this.Tarih_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarih_lbl.IsDerivedStyle = true;
            this.Tarih_lbl.Location = new System.Drawing.Point(400, 394);
            this.Tarih_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tarih_lbl.Name = "Tarih_lbl";
            this.Tarih_lbl.Size = new System.Drawing.Size(276, 33);
            this.Tarih_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Tarih_lbl.StyleManager = this.styleManager1;
            this.Tarih_lbl.TabIndex = 72;
            this.Tarih_lbl.Text = "----------";
            this.Tarih_lbl.ThemeAuthor = "Narwin";
            this.Tarih_lbl.ThemeName = "MetroLight";
            // 
            // Sonuc_lbl
            // 
            this.Sonuc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonuc_lbl.IsDerivedStyle = true;
            this.Sonuc_lbl.Location = new System.Drawing.Point(400, 115);
            this.Sonuc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sonuc_lbl.Name = "Sonuc_lbl";
            this.Sonuc_lbl.Size = new System.Drawing.Size(79, 33);
            this.Sonuc_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Sonuc_lbl.StyleManager = this.styleManager1;
            this.Sonuc_lbl.TabIndex = 72;
            this.Sonuc_lbl.Text = "----------";
            this.Sonuc_lbl.ThemeAuthor = "Narwin";
            this.Sonuc_lbl.ThemeName = "MetroLight";
            // 
            // Database_lbl
            // 
            this.Database_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database_lbl.IsDerivedStyle = true;
            this.Database_lbl.Location = new System.Drawing.Point(400, 231);
            this.Database_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Database_lbl.Name = "Database_lbl";
            this.Database_lbl.Size = new System.Drawing.Size(516, 33);
            this.Database_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Database_lbl.StyleManager = this.styleManager1;
            this.Database_lbl.TabIndex = 72;
            this.Database_lbl.Text = "--";
            this.Database_lbl.ThemeAuthor = "Narwin";
            this.Database_lbl.ThemeName = "MetroLight";
            // 
            // metroSetLabel19
            // 
            this.metroSetLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel19.IsDerivedStyle = true;
            this.metroSetLabel19.Location = new System.Drawing.Point(11, 231);
            this.metroSetLabel19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel19.Name = "metroSetLabel19";
            this.metroSetLabel19.Size = new System.Drawing.Size(276, 33);
            this.metroSetLabel19.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel19.StyleManager = this.styleManager1;
            this.metroSetLabel19.TabIndex = 72;
            this.metroSetLabel19.Text = "DATABASE DURUM : ";
            this.metroSetLabel19.ThemeAuthor = "Narwin";
            this.metroSetLabel19.ThemeName = "MetroLight";
            // 
            // metroSetLabel17
            // 
            this.metroSetLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel17.IsDerivedStyle = true;
            this.metroSetLabel17.Location = new System.Drawing.Point(7, 167);
            this.metroSetLabel17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel17.Name = "metroSetLabel17";
            this.metroSetLabel17.Size = new System.Drawing.Size(181, 33);
            this.metroSetLabel17.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel17.StyleManager = this.styleManager1;
            this.metroSetLabel17.TabIndex = 72;
            this.metroSetLabel17.Text = "PLC DURUM : ";
            this.metroSetLabel17.ThemeAuthor = "Narwin";
            this.metroSetLabel17.ThemeName = "MetroLight";
            // 
            // Sol_kol_boy_290_1_Y_txt
            // 
            this.Sol_kol_boy_290_1_Y_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sol_kol_boy_290_1_Y_txt.IsDerivedStyle = true;
            this.Sol_kol_boy_290_1_Y_txt.Location = new System.Drawing.Point(273, 71);
            this.Sol_kol_boy_290_1_Y_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sol_kol_boy_290_1_Y_txt.Name = "Sol_kol_boy_290_1_Y_txt";
            this.Sol_kol_boy_290_1_Y_txt.Size = new System.Drawing.Size(207, 24);
            this.Sol_kol_boy_290_1_Y_txt.Style = MetroSet_UI.Enums.Style.Light;
            this.Sol_kol_boy_290_1_Y_txt.StyleManager = this.styleManager1;
            this.Sol_kol_boy_290_1_Y_txt.TabIndex = 71;
            this.Sol_kol_boy_290_1_Y_txt.Text = "0";
            this.Sol_kol_boy_290_1_Y_txt.ThemeAuthor = "Narwin";
            this.Sol_kol_boy_290_1_Y_txt.ThemeName = "MetroLight";
            // 
            // Sag_kol_boy_290_Y_txt
            // 
            this.Sag_kol_boy_290_Y_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sag_kol_boy_290_Y_txt.IsDerivedStyle = true;
            this.Sag_kol_boy_290_Y_txt.Location = new System.Drawing.Point(836, 71);
            this.Sag_kol_boy_290_Y_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sag_kol_boy_290_Y_txt.Name = "Sag_kol_boy_290_Y_txt";
            this.Sag_kol_boy_290_Y_txt.Size = new System.Drawing.Size(170, 24);
            this.Sag_kol_boy_290_Y_txt.Style = MetroSet_UI.Enums.Style.Light;
            this.Sag_kol_boy_290_Y_txt.StyleManager = this.styleManager1;
            this.Sag_kol_boy_290_Y_txt.TabIndex = 71;
            this.Sag_kol_boy_290_Y_txt.Text = "0";
            this.Sag_kol_boy_290_Y_txt.ThemeAuthor = "Narwin";
            this.Sag_kol_boy_290_Y_txt.ThemeName = "MetroLight";
            // 
            // Sol_305_1_X_txt
            // 
            this.Sol_305_1_X_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sol_305_1_X_txt.IsDerivedStyle = true;
            this.Sol_305_1_X_txt.Location = new System.Drawing.Point(836, 25);
            this.Sol_305_1_X_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sol_305_1_X_txt.Name = "Sol_305_1_X_txt";
            this.Sol_305_1_X_txt.Size = new System.Drawing.Size(170, 24);
            this.Sol_305_1_X_txt.Style = MetroSet_UI.Enums.Style.Light;
            this.Sol_305_1_X_txt.StyleManager = this.styleManager1;
            this.Sol_305_1_X_txt.TabIndex = 70;
            this.Sol_305_1_X_txt.Text = "0";
            this.Sol_305_1_X_txt.ThemeAuthor = "Narwin";
            this.Sol_305_1_X_txt.ThemeName = "MetroLight";
            // 
            // Sag_305_X_txt
            // 
            this.Sag_305_X_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sag_305_X_txt.IsDerivedStyle = true;
            this.Sag_305_X_txt.Location = new System.Drawing.Point(273, 25);
            this.Sag_305_X_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sag_305_X_txt.Name = "Sag_305_X_txt";
            this.Sag_305_X_txt.Size = new System.Drawing.Size(189, 24);
            this.Sag_305_X_txt.Style = MetroSet_UI.Enums.Style.Light;
            this.Sag_305_X_txt.StyleManager = this.styleManager1;
            this.Sag_305_X_txt.TabIndex = 68;
            this.Sag_305_X_txt.Text = "0";
            this.Sag_305_X_txt.ThemeAuthor = "Narwin";
            this.Sag_305_X_txt.ThemeName = "MetroLight";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(11, 67);
            this.metroSetLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(239, 33);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = this.styleManager1;
            this.metroSetLabel4.TabIndex = 67;
            this.metroSetLabel4.Text = "SOL_KOL_BOY_290_Y_1 :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLight";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(584, 21);
            this.metroSetLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(190, 33);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = this.styleManager1;
            this.metroSetLabel3.TabIndex = 2;
            this.metroSetLabel3.Text = "SOL_305_X_1 :";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLight";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(575, 67);
            this.metroSetLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(234, 33);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "SAG_KOL_BOY_290_Y :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLight";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(8, 21);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(194, 33);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "SAG_305_X :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLight";
            this.metroSetLabel1.Click += new System.EventHandler(this.metroSetLabel1_Click);
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage1.Controls.Add(this.Rapor_box);
            this.metroSetSetTabPage1.Controls.Add(this.dataGridView1);
            this.metroSetSetTabPage1.Font = null;
            this.metroSetSetTabPage1.ImageIndex = 0;
            this.metroSetSetTabPage1.ImageKey = null;
            this.metroSetSetTabPage1.IsDerivedStyle = true;
            this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
            this.metroSetSetTabPage1.Size = new System.Drawing.Size(1900, 799);
            this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage1.StyleManager = this.styleManager1;
            this.metroSetSetTabPage1.TabIndex = 3;
            this.metroSetSetTabPage1.Text = "RAPORLAMA";
            this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage1.ThemeName = "MetroLite";
            this.metroSetSetTabPage1.ToolTipText = null;
            // 
            // Rapor_box
            // 
            this.Rapor_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rapor_box.BackColor = System.Drawing.Color.Transparent;
            this.Rapor_box.Controls.Add(this.Id_lbl);
            this.Rapor_box.Controls.Add(this.metroSetButton2);
            this.Rapor_box.Controls.Add(this.ID_box);
            this.Rapor_box.Controls.Add(this.tarih_box);
            this.Rapor_box.Controls.Add(this.Listele_btn);
            this.Rapor_box.Controls.Add(this.metroSetLabel7);
            this.Rapor_box.Controls.Add(this.Rapor_Secim_box);
            this.Rapor_box.ForeColor = System.Drawing.Color.Transparent;
            this.Rapor_box.Location = new System.Drawing.Point(0, 375);
            this.Rapor_box.Name = "Rapor_box";
            this.Rapor_box.Size = new System.Drawing.Size(1900, 212);
            this.Rapor_box.TabIndex = 82;
            this.Rapor_box.TabStop = false;
            // 
            // Id_lbl
            // 
            this.Id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Id_lbl.IsDerivedStyle = true;
            this.Id_lbl.Location = new System.Drawing.Point(533, 37);
            this.Id_lbl.Name = "Id_lbl";
            this.Id_lbl.Size = new System.Drawing.Size(37, 23);
            this.Id_lbl.Style = MetroSet_UI.Enums.Style.Light;
            this.Id_lbl.StyleManager = this.styleManager1;
            this.Id_lbl.TabIndex = 86;
            this.Id_lbl.Text = "İD :";
            this.Id_lbl.ThemeAuthor = "Narwin";
            this.Id_lbl.ThemeName = "MetroLight";
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.IsDerivedStyle = true;
            this.metroSetButton2.Location = new System.Drawing.Point(935, 78);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(143, 60);
            this.metroSetButton2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton2.StyleManager = this.styleManager1;
            this.metroSetButton2.TabIndex = 5;
            this.metroSetButton2.Text = "VERİLERİ TEMİZLE";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLight";
            this.metroSetButton2.Click += new System.EventHandler(this.metroSetButton2_Click);
            // 
            // ID_box
            // 
            this.ID_box.AutoCompleteCustomSource = null;
            this.ID_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ID_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ID_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ID_box.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID_box.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ID_box.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ID_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ID_box.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ID_box.Image = null;
            this.ID_box.IsDerivedStyle = true;
            this.ID_box.Lines = null;
            this.ID_box.Location = new System.Drawing.Point(586, 33);
            this.ID_box.MaxLength = 32767;
            this.ID_box.Multiline = false;
            this.ID_box.Name = "ID_box";
            this.ID_box.ReadOnly = false;
            this.ID_box.Size = new System.Drawing.Size(126, 30);
            this.ID_box.Style = MetroSet_UI.Enums.Style.Light;
            this.ID_box.StyleManager = this.styleManager1;
            this.ID_box.TabIndex = 85;
            this.ID_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ID_box.ThemeAuthor = "Narwin";
            this.ID_box.ThemeName = "MetroLight";
            this.ID_box.UseSystemPasswordChar = false;
            this.ID_box.WatermarkText = "";
            // 
            // tarih_box
            // 
            this.tarih_box.Controls.Add(this.OK_NOK_BOX);
            this.tarih_box.Controls.Add(this.metroSetLabel6);
            this.tarih_box.Controls.Add(this.dateTimePicker1);
            this.tarih_box.Location = new System.Drawing.Point(44, 69);
            this.tarih_box.Name = "tarih_box";
            this.tarih_box.Size = new System.Drawing.Size(736, 96);
            this.tarih_box.TabIndex = 84;
            this.tarih_box.TabStop = false;
            // 
            // OK_NOK_BOX
            // 
            this.OK_NOK_BOX.AllowDrop = true;
            this.OK_NOK_BOX.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OK_NOK_BOX.BackColor = System.Drawing.Color.Transparent;
            this.OK_NOK_BOX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OK_NOK_BOX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OK_NOK_BOX.CausesValidation = false;
            this.OK_NOK_BOX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OK_NOK_BOX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.OK_NOK_BOX.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.OK_NOK_BOX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OK_NOK_BOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OK_NOK_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OK_NOK_BOX.FormattingEnabled = true;
            this.OK_NOK_BOX.IsDerivedStyle = true;
            this.OK_NOK_BOX.ItemHeight = 20;
            this.OK_NOK_BOX.Items.AddRange(new object[] {
            "TÜM",
            "OK",
            "NOK"});
            this.OK_NOK_BOX.Location = new System.Drawing.Point(595, 43);
            this.OK_NOK_BOX.Name = "OK_NOK_BOX";
            this.OK_NOK_BOX.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OK_NOK_BOX.SelectedItemForeColor = System.Drawing.Color.White;
            this.OK_NOK_BOX.Size = new System.Drawing.Size(134, 26);
            this.OK_NOK_BOX.Style = MetroSet_UI.Enums.Style.Light;
            this.OK_NOK_BOX.StyleManager = this.styleManager1;
            this.OK_NOK_BOX.TabIndex = 81;
            this.OK_NOK_BOX.ThemeAuthor = "Narwin";
            this.OK_NOK_BOX.ThemeName = "MetroLight";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(15, 45);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(144, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = this.styleManager1;
            this.metroSetLabel6.TabIndex = 80;
            this.metroSetLabel6.Text = "KAYIT TARİHİ";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLight";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(415, 23);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // Listele_btn
            // 
            this.Listele_btn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Listele_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Listele_btn.DisabledForeColor = System.Drawing.Color.Gray;
            this.Listele_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Listele_btn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Listele_btn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Listele_btn.HoverTextColor = System.Drawing.Color.White;
            this.Listele_btn.IsDerivedStyle = true;
            this.Listele_btn.Location = new System.Drawing.Point(786, 78);
            this.Listele_btn.Name = "Listele_btn";
            this.Listele_btn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Listele_btn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Listele_btn.NormalTextColor = System.Drawing.Color.White;
            this.Listele_btn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Listele_btn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Listele_btn.PressTextColor = System.Drawing.Color.White;
            this.Listele_btn.Size = new System.Drawing.Size(143, 60);
            this.Listele_btn.Style = MetroSet_UI.Enums.Style.Light;
            this.Listele_btn.StyleManager = this.styleManager1;
            this.Listele_btn.TabIndex = 83;
            this.Listele_btn.Text = "GÖRÜNTÜLE";
            this.Listele_btn.ThemeAuthor = "Narwin";
            this.Listele_btn.ThemeName = "MetroLight";
            this.Listele_btn.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(60, 36);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(144, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = this.styleManager1;
            this.metroSetLabel7.TabIndex = 81;
            this.metroSetLabel7.Text = "Arama Kriteri :";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLight";
            // 
            // Rapor_Secim_box
            // 
            this.Rapor_Secim_box.AllowDrop = true;
            this.Rapor_Secim_box.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Rapor_Secim_box.BackColor = System.Drawing.Color.Transparent;
            this.Rapor_Secim_box.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Rapor_Secim_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Rapor_Secim_box.CausesValidation = false;
            this.Rapor_Secim_box.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Rapor_Secim_box.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Rapor_Secim_box.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Rapor_Secim_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Rapor_Secim_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rapor_Secim_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Rapor_Secim_box.FormattingEnabled = true;
            this.Rapor_Secim_box.IsDerivedStyle = true;
            this.Rapor_Secim_box.ItemHeight = 20;
            this.Rapor_Secim_box.Items.AddRange(new object[] {
            "TÜM",
            "TARİHE GÖRE LİSTELE",
            "İD GETİR"});
            this.Rapor_Secim_box.Location = new System.Drawing.Point(240, 33);
            this.Rapor_Secim_box.Name = "Rapor_Secim_box";
            this.Rapor_Secim_box.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Rapor_Secim_box.SelectedItemForeColor = System.Drawing.Color.White;
            this.Rapor_Secim_box.Size = new System.Drawing.Size(267, 26);
            this.Rapor_Secim_box.Style = MetroSet_UI.Enums.Style.Light;
            this.Rapor_Secim_box.StyleManager = this.styleManager1;
            this.Rapor_Secim_box.TabIndex = 79;
            this.Rapor_Secim_box.ThemeAuthor = "Narwin";
            this.Rapor_Secim_box.ThemeName = "MetroLight";
            this.Rapor_Secim_box.SelectedIndexChanged += new System.EventHandler(this.metroSetComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1900, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // metroSetSetTabPage2
            // 
            this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage2.Font = null;
            this.metroSetSetTabPage2.ImageIndex = 0;
            this.metroSetSetTabPage2.ImageKey = null;
            this.metroSetSetTabPage2.IsDerivedStyle = true;
            this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
            this.metroSetSetTabPage2.Size = new System.Drawing.Size(1900, 799);
            this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage2.StyleManager = this.styleManager1;
            this.metroSetSetTabPage2.TabIndex = 4;
            this.metroSetSetTabPage2.Text = "ALARMLAR";
            this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage2.ThemeName = "MetroLite";
            this.metroSetSetTabPage2.ToolTipText = null;
            // 
            // metroSetSetTabPage4
            // 
            this.metroSetSetTabPage4.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage4.Controls.Add(this.veriyaz_btn);
            this.metroSetSetTabPage4.Font = null;
            this.metroSetSetTabPage4.ImageIndex = 0;
            this.metroSetSetTabPage4.ImageKey = null;
            this.metroSetSetTabPage4.IsDerivedStyle = true;
            this.metroSetSetTabPage4.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage4.Name = "metroSetSetTabPage4";
            this.metroSetSetTabPage4.Size = new System.Drawing.Size(1900, 799);
            this.metroSetSetTabPage4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage4.StyleManager = this.styleManager1;
            this.metroSetSetTabPage4.TabIndex = 5;
            this.metroSetSetTabPage4.Text = "YÖNETİM PANELİ";
            this.metroSetSetTabPage4.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage4.ThemeName = "MetroLite";
            this.metroSetSetTabPage4.ToolTipText = null;
            // 
            // veriyaz_btn
            // 
            this.veriyaz_btn.Location = new System.Drawing.Point(1617, 667);
            this.veriyaz_btn.Name = "veriyaz_btn";
            this.veriyaz_btn.Size = new System.Drawing.Size(123, 67);
            this.veriyaz_btn.TabIndex = 1;
            this.veriyaz_btn.Text = "MANUEL YAZ";
            this.veriyaz_btn.UseVisualStyleBackColor = true;
            // 
            // metroSetControlBox2
            // 
            this.metroSetControlBox2.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox2.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox2.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroSetControlBox2.IsDerivedStyle = true;
            this.metroSetControlBox2.Location = new System.Drawing.Point(1799, 59);
            this.metroSetControlBox2.MaximizeBox = true;
            this.metroSetControlBox2.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox2.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MinimizeBox = true;
            this.metroSetControlBox2.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox2.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.Name = "metroSetControlBox2";
            this.metroSetControlBox2.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox2.StyleManager = this.styleManager1;
            this.metroSetControlBox2.TabIndex = 3;
            this.metroSetControlBox2.Text = "metroSetControlBox2";
            this.metroSetControlBox2.ThemeAuthor = "Narwin";
            this.metroSetControlBox2.ThemeName = "MetroLight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "TEST VE OTOMASYON SİSTEMLERİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1908, 845);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox2);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(9, 59, 9, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StyleManager = this.styleManager1;
            this.Tag = "";
            this.ThemeName = "MetroLight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.metroSetSetTabPage3.ResumeLayout(false);
            this.metroSetSetTabPage3.PerformLayout();
            this.metroSetSetTabPage1.ResumeLayout(false);
            this.Rapor_box.ResumeLayout(false);
            this.tarih_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroSetSetTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer baglanti_kontrol;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroSet_UI.Controls.MetroSetComboBox Rapor_Secim_box;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private System.Windows.Forms.GroupBox Rapor_box;
        private MetroSet_UI.Controls.MetroSetButton Listele_btn;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox tarih_box;
        private MetroSet_UI.Controls.MetroSetTextBox ID_box;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private MetroSet_UI.Controls.MetroSetComboBox OK_NOK_BOX;
        private MetroSet_UI.Controls.MetroSetLabel Id_lbl;
        private System.Windows.Forms.Button veriyaz_btn;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage3;
        private MetroSet_UI.Controls.MetroSetEllipse sonuc_elipse;
        private MetroSet_UI.Controls.MetroSetEllipse Database_durum_Elipse;
        private MetroSet_UI.Controls.MetroSetEllipse Plc_durum_elipse;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel26;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel25;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel23;
        private MetroSet_UI.Controls.MetroSetLabel Database_hata_lbl;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel22;
        private MetroSet_UI.Controls.MetroSetLabel Plc_hata_lbl;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel21;
        private MetroSet_UI.Controls.MetroSetLabel Plc_lbl;
        private MetroSet_UI.Controls.MetroSetLabel olcum_sayac;
        private MetroSet_UI.Controls.MetroSetLabel Tarih_lbl;
        private MetroSet_UI.Controls.MetroSetLabel Sonuc_lbl;
        private MetroSet_UI.Controls.MetroSetLabel Database_lbl;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel19;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel17;
        private MetroSet_UI.Controls.MetroSetLabel Sol_kol_boy_290_1_Y_txt;
        private MetroSet_UI.Controls.MetroSetLabel Sag_kol_boy_290_Y_txt;
        private MetroSet_UI.Controls.MetroSetLabel Sol_305_1_X_txt;
        private MetroSet_UI.Controls.MetroSetLabel Sag_305_X_txt;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.CheckBox databox;
    }
}

