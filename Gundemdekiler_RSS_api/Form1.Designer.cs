namespace Gundemdekiler_RSS_api
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
            this._btnSonDakika = new System.Windows.Forms.Button();
            this._btnKulturSanat = new System.Windows.Forms.Button();
            this._btnBilim = new System.Windows.Forms.Button();
            this._btnMagazin = new System.Windows.Forms.Button();
            this._btnEkonomi = new System.Windows.Forms.Button();
            this._btnSpor = new System.Windows.Forms.Button();
            this._btnSaglik = new System.Windows.Forms.Button();
            this._btnSeyahat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lstBasliklar = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this._picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this._lblKonuBaslik = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnSonDakika
            // 
            this._btnSonDakika.Location = new System.Drawing.Point(6, 19);
            this._btnSonDakika.Name = "_btnSonDakika";
            this._btnSonDakika.Size = new System.Drawing.Size(114, 44);
            this._btnSonDakika.TabIndex = 0;
            this._btnSonDakika.Text = "Son Dakika !!!";
            this._btnSonDakika.UseVisualStyleBackColor = true;
            this._btnSonDakika.Click += new System.EventHandler(this._btnSonDakika_Click);
            // 
            // _btnKulturSanat
            // 
            this._btnKulturSanat.Location = new System.Drawing.Point(6, 69);
            this._btnKulturSanat.Name = "_btnKulturSanat";
            this._btnKulturSanat.Size = new System.Drawing.Size(114, 44);
            this._btnKulturSanat.TabIndex = 1;
            this._btnKulturSanat.Text = "Kültür Sanat";
            this._btnKulturSanat.UseVisualStyleBackColor = true;
            this._btnKulturSanat.Click += new System.EventHandler(this._btnKulturSanat_Click);
            // 
            // _btnBilim
            // 
            this._btnBilim.Location = new System.Drawing.Point(6, 119);
            this._btnBilim.Name = "_btnBilim";
            this._btnBilim.Size = new System.Drawing.Size(114, 44);
            this._btnBilim.TabIndex = 3;
            this._btnBilim.Text = "Bilim";
            this._btnBilim.UseVisualStyleBackColor = true;
            this._btnBilim.Click += new System.EventHandler(this._btnBilim_Click);
            // 
            // _btnMagazin
            // 
            this._btnMagazin.Location = new System.Drawing.Point(6, 169);
            this._btnMagazin.Name = "_btnMagazin";
            this._btnMagazin.Size = new System.Drawing.Size(114, 44);
            this._btnMagazin.TabIndex = 2;
            this._btnMagazin.Text = "Magazin";
            this._btnMagazin.UseVisualStyleBackColor = true;
            this._btnMagazin.Click += new System.EventHandler(this._btnMagazin_Click);
            // 
            // _btnEkonomi
            // 
            this._btnEkonomi.Location = new System.Drawing.Point(6, 219);
            this._btnEkonomi.Name = "_btnEkonomi";
            this._btnEkonomi.Size = new System.Drawing.Size(114, 44);
            this._btnEkonomi.TabIndex = 7;
            this._btnEkonomi.Text = "Ekonomi";
            this._btnEkonomi.UseVisualStyleBackColor = true;
            this._btnEkonomi.Click += new System.EventHandler(this._btnEkonomi_Click);
            // 
            // _btnSpor
            // 
            this._btnSpor.Location = new System.Drawing.Point(6, 269);
            this._btnSpor.Name = "_btnSpor";
            this._btnSpor.Size = new System.Drawing.Size(114, 44);
            this._btnSpor.TabIndex = 6;
            this._btnSpor.Text = "Spor";
            this._btnSpor.UseVisualStyleBackColor = true;
            this._btnSpor.Click += new System.EventHandler(this._btnSpor_Click);
            // 
            // _btnSaglik
            // 
            this._btnSaglik.Location = new System.Drawing.Point(8, 319);
            this._btnSaglik.Name = "_btnSaglik";
            this._btnSaglik.Size = new System.Drawing.Size(114, 44);
            this._btnSaglik.TabIndex = 5;
            this._btnSaglik.Text = "Sağlık";
            this._btnSaglik.UseVisualStyleBackColor = true;
            this._btnSaglik.Click += new System.EventHandler(this._btnSaglik_Click);
            // 
            // _btnSeyahat
            // 
            this._btnSeyahat.Location = new System.Drawing.Point(6, 369);
            this._btnSeyahat.Name = "_btnSeyahat";
            this._btnSeyahat.Size = new System.Drawing.Size(114, 44);
            this._btnSeyahat.TabIndex = 4;
            this._btnSeyahat.Text = "Seyahat";
            this._btnSeyahat.UseVisualStyleBackColor = true;
            this._btnSeyahat.Click += new System.EventHandler(this._btnSeyahat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnSonDakika);
            this.groupBox1.Controls.Add(this._btnEkonomi);
            this.groupBox1.Controls.Add(this._btnKulturSanat);
            this.groupBox1.Controls.Add(this._btnSpor);
            this.groupBox1.Controls.Add(this._btnMagazin);
            this.groupBox1.Controls.Add(this._btnSaglik);
            this.groupBox1.Controls.Add(this._btnBilim);
            this.groupBox1.Controls.Add(this._btnSeyahat);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 425);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haber Başlıkları";
            // 
            // _lstBasliklar
            // 
            this._lstBasliklar.FormattingEnabled = true;
            this._lstBasliklar.Location = new System.Drawing.Point(168, 98);
            this._lstBasliklar.Name = "_lstBasliklar";
            this._lstBasliklar.Size = new System.Drawing.Size(442, 446);
            this._lstBasliklar.TabIndex = 9;
            this._lstBasliklar.SelectedIndexChanged += new System.EventHandler(this._lstBasliklar_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // _picIcon
            // 
            this._picIcon.Image = global::Gundemdekiler_RSS_api.Properties.Resources.cnn_logo;
            this._picIcon.Location = new System.Drawing.Point(20, 20);
            this._picIcon.Name = "_picIcon";
            this._picIcon.Size = new System.Drawing.Size(112, 67);
            this._picIcon.TabIndex = 10;
            this._picIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(299, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "CNN TURK";
            // 
            // _lblKonuBaslik
            // 
            this._lblKonuBaslik.AutoSize = true;
            this._lblKonuBaslik.Location = new System.Drawing.Point(165, 70);
            this._lblKonuBaslik.Name = "_lblKonuBaslik";
            this._lblKonuBaslik.Size = new System.Drawing.Size(64, 13);
            this._lblKonuBaslik.TabIndex = 13;
            this._lblKonuBaslik.Text = "Konu başlığı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(622, 554);
            this.Controls.Add(this._lblKonuBaslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._picIcon);
            this.Controls.Add(this._lstBasliklar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gündemdekiler v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSonDakika;
        private System.Windows.Forms.Button _btnKulturSanat;
        private System.Windows.Forms.Button _btnBilim;
        private System.Windows.Forms.Button _btnMagazin;
        private System.Windows.Forms.Button _btnEkonomi;
        private System.Windows.Forms.Button _btnSpor;
        private System.Windows.Forms.Button _btnSaglik;
        private System.Windows.Forms.Button _btnSeyahat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox _lstBasliklar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox _picIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblKonuBaslik;
    }
}

