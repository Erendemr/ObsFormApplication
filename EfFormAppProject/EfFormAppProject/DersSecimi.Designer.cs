namespace EfFormAppProject
{
    partial class DersSecimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dGWDersler = new DataGridView();
            lblOgrenciBilgi = new Label();
            btnogrDersKaydet = new Button();
            btnDersIslemleri = new Button();
            ((System.ComponentModel.ISupportInitialize)dGWDersler).BeginInit();
            SuspendLayout();
            // 
            // dGWDersler
            // 
            dGWDersler.BackgroundColor = SystemColors.GradientActiveCaption;
            dGWDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWDersler.Location = new Point(44, 108);
            dGWDersler.Name = "dGWDersler";
            dGWDersler.Size = new Size(474, 192);
            dGWDersler.TabIndex = 0;
            // 
            // lblOgrenciBilgi
            // 
            lblOgrenciBilgi.AutoSize = true;
            lblOgrenciBilgi.Location = new Point(151, 30);
            lblOgrenciBilgi.Name = "lblOgrenciBilgi";
            lblOgrenciBilgi.Size = new Size(0, 15);
            lblOgrenciBilgi.TabIndex = 1;
            // 
            // btnogrDersKaydet
            // 
            btnogrDersKaydet.Location = new Point(160, 317);
            btnogrDersKaydet.Name = "btnogrDersKaydet";
            btnogrDersKaydet.Size = new Size(260, 23);
            btnogrDersKaydet.TabIndex = 2;
            btnogrDersKaydet.Text = "Öğrencinin Derslerini Kaydet";
            btnogrDersKaydet.UseVisualStyleBackColor = true;
            btnogrDersKaydet.Click += btnogrDersKaydet_Click;
            // 
            // btnDersIslemleri
            // 
            btnDersIslemleri.Location = new Point(455, 12);
            btnDersIslemleri.Name = "btnDersIslemleri";
            btnDersIslemleri.Size = new Size(107, 23);
            btnDersIslemleri.TabIndex = 3;
            btnDersIslemleri.Text = "Ders İşlemleri";
            btnDersIslemleri.UseVisualStyleBackColor = true;
            btnDersIslemleri.Click += btnDersIslemleri_Click;
            // 
            // DersSecimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 371);
            Controls.Add(btnDersIslemleri);
            Controls.Add(btnogrDersKaydet);
            Controls.Add(lblOgrenciBilgi);
            Controls.Add(dGWDersler);
            Name = "DersSecimi";
            Text = "DersSecimi";
            Load += DersSecimi_Load;
            ((System.ComponentModel.ISupportInitialize)dGWDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGWDersler;
        private Label lblOgrenciBilgi;
        private Button btnogrDersKaydet;
        private Button btnDersIslemleri;
    }
}