namespace EfFormAppProject
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpOgrenciBul = new GroupBox();
            btnDeleteClass = new Button();
            btnSınıfEkle = new Button();
            cmbClasses = new ComboBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSinifSecimi = new Label();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            btnDersSecimi = new Button();
            btnDeleteStudent = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbList = new ComboBox();
            grpOgrenciBul.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciBul
            // 
            grpOgrenciBul.Controls.Add(btnDeleteClass);
            grpOgrenciBul.Controls.Add(btnSınıfEkle);
            grpOgrenciBul.Controls.Add(cmbClasses);
            grpOgrenciBul.Controls.Add(txtNumara);
            grpOgrenciBul.Controls.Add(txtSoyad);
            grpOgrenciBul.Controls.Add(txtAd);
            grpOgrenciBul.Controls.Add(lblSinifSecimi);
            grpOgrenciBul.Controls.Add(lblNumara);
            grpOgrenciBul.Controls.Add(lblSoyad);
            grpOgrenciBul.Controls.Add(lblAd);
            grpOgrenciBul.Location = new Point(12, 12);
            grpOgrenciBul.Name = "grpOgrenciBul";
            grpOgrenciBul.Size = new Size(329, 232);
            grpOgrenciBul.TabIndex = 0;
            grpOgrenciBul.TabStop = false;
            grpOgrenciBul.Text = "Öğrenci Ekleme";
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.Location = new Point(176, 176);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(66, 20);
            btnDeleteClass.TabIndex = 4;
            btnDeleteClass.Text = "Sınıf Sil";
            btnDeleteClass.UseVisualStyleBackColor = true;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // btnSınıfEkle
            // 
            btnSınıfEkle.Location = new Point(104, 176);
            btnSınıfEkle.Name = "btnSınıfEkle";
            btnSınıfEkle.Size = new Size(66, 20);
            btnSınıfEkle.TabIndex = 4;
            btnSınıfEkle.Text = "Sınıf Ekle";
            btnSınıfEkle.UseVisualStyleBackColor = true;
            btnSınıfEkle.Click += btnSınıfEkle_Click;
            // 
            // cmbClasses
            // 
            cmbClasses.FormattingEnabled = true;
            cmbClasses.Location = new Point(104, 147);
            cmbClasses.Name = "cmbClasses";
            cmbClasses.Size = new Size(121, 23);
            cmbClasses.TabIndex = 7;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(104, 118);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(121, 23);
            txtNumara.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(104, 85);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(121, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(104, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(121, 23);
            txtAd.TabIndex = 4;
            // 
            // lblSinifSecimi
            // 
            lblSinifSecimi.AutoSize = true;
            lblSinifSecimi.Location = new Point(20, 150);
            lblSinifSecimi.Name = "lblSinifSecimi";
            lblSinifSecimi.Size = new Size(69, 15);
            lblSinifSecimi.TabIndex = 3;
            lblSinifSecimi.Text = "Sınıf Seçiniz";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(19, 118);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(50, 15);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(19, 88);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(19, 51);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(145, 250);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 23);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(12, 250);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 23);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(12, 293);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(116, 23);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(352, 292);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(151, 24);
            btnDersSecimi.TabIndex = 3;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            btnDersSecimi.Click += btnDersSecimi_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(145, 293);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(120, 23);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Text = "Öğrenci Sil";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbList
            // 
            cmbList.FormattingEnabled = true;
            cmbList.Location = new Point(382, 12);
            cmbList.Name = "cmbList";
            cmbList.Size = new Size(121, 23);
            cmbList.TabIndex = 5;
            cmbList.Text = "İşlem Seçiniz";
            cmbList.SelectedIndexChanged += cmbList_SelectedIndexChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 329);
            Controls.Add(cmbList);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(grpOgrenciBul);
            Name = "RegisterForm";
            Text = "Öğrenci Bilgi Sistemi";
            Load += RegisterForm_Load;
            grpOgrenciBul.ResumeLayout(false);
            grpOgrenciBul.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenciBul;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnBul;
        private Button btnDersSecimi;
        private ComboBox cmbClasses;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblSinifSecimi;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
        private Button btnSınıfEkle;
        private Button btnDeleteClass;
        private Button btnDeleteStudent;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbList;
    }
}
