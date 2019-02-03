namespace Gundemdekiler_RSS_api
{
    partial class Icerik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Icerik));
            this._pctreHaberResim = new System.Windows.Forms.PictureBox();
            this._ricTxt_KonuDetay = new System.Windows.Forms.RichTextBox();
            this._lblTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnDetayLink = new System.Windows.Forms.Button();
            this._rictxtBaslik = new System.Windows.Forms.RichTextBox();
            this._btnYaziBuyut = new System.Windows.Forms.Button();
            this._btnYaziKucult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pctreHaberResim)).BeginInit();
            this.SuspendLayout();
            // 
            // _pctreHaberResim
            // 
            this._pctreHaberResim.Location = new System.Drawing.Point(12, 87);
            this._pctreHaberResim.Name = "_pctreHaberResim";
            this._pctreHaberResim.Size = new System.Drawing.Size(489, 336);
            this._pctreHaberResim.TabIndex = 13;
            this._pctreHaberResim.TabStop = false;
            this._pctreHaberResim.Click += new System.EventHandler(this._pctreHaberResim_Click);
            // 
            // _ricTxt_KonuDetay
            // 
            this._ricTxt_KonuDetay.Location = new System.Drawing.Point(15, 465);
            this._ricTxt_KonuDetay.Name = "_ricTxt_KonuDetay";
            this._ricTxt_KonuDetay.ReadOnly = true;
            this._ricTxt_KonuDetay.Size = new System.Drawing.Size(412, 163);
            this._ricTxt_KonuDetay.TabIndex = 12;
            this._ricTxt_KonuDetay.Text = "";
            // 
            // _lblTarih
            // 
            this._lblTarih.AutoSize = true;
            this._lblTarih.Location = new System.Drawing.Point(396, 426);
            this._lblTarih.Name = "_lblTarih";
            this._lblTarih.Size = new System.Drawing.Size(31, 13);
            this._lblTarih.TabIndex = 15;
            this._lblTarih.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Haber yayın tarihi:";
            // 
            // _btnDetayLink
            // 
            this._btnDetayLink.Location = new System.Drawing.Point(433, 605);
            this._btnDetayLink.Name = "_btnDetayLink";
            this._btnDetayLink.Size = new System.Drawing.Size(102, 23);
            this._btnDetayLink.TabIndex = 16;
            this._btnDetayLink.Text = "Haberin detayı";
            this._btnDetayLink.UseVisualStyleBackColor = true;
            this._btnDetayLink.Click += new System.EventHandler(this._btnDetayLink_Click);
            // 
            // _rictxtBaslik
            // 
            this._rictxtBaslik.Location = new System.Drawing.Point(12, 12);
            this._rictxtBaslik.Name = "_rictxtBaslik";
            this._rictxtBaslik.ReadOnly = true;
            this._rictxtBaslik.Size = new System.Drawing.Size(489, 69);
            this._rictxtBaslik.TabIndex = 17;
            this._rictxtBaslik.Text = "";
            // 
            // _btnYaziBuyut
            // 
            this._btnYaziBuyut.Location = new System.Drawing.Point(433, 465);
            this._btnYaziBuyut.Name = "_btnYaziBuyut";
            this._btnYaziBuyut.Size = new System.Drawing.Size(35, 23);
            this._btnYaziBuyut.TabIndex = 18;
            this._btnYaziBuyut.Text = "A+";
            this._btnYaziBuyut.UseVisualStyleBackColor = true;
            this._btnYaziBuyut.Click += new System.EventHandler(this._btnYaziBuyut_Click);
            // 
            // _btnYaziKucult
            // 
            this._btnYaziKucult.Location = new System.Drawing.Point(433, 494);
            this._btnYaziKucult.Name = "_btnYaziKucult";
            this._btnYaziKucult.Size = new System.Drawing.Size(35, 23);
            this._btnYaziKucult.TabIndex = 18;
            this._btnYaziKucult.Text = "A-";
            this._btnYaziKucult.UseVisualStyleBackColor = true;
            this._btnYaziKucult.Click += new System.EventHandler(this._btnYaziKucult_Click);
            // 
            // Icerik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(550, 658);
            this.Controls.Add(this._btnYaziKucult);
            this.Controls.Add(this._btnYaziBuyut);
            this.Controls.Add(this._rictxtBaslik);
            this.Controls.Add(this._btnDetayLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblTarih);
            this.Controls.Add(this._pctreHaberResim);
            this.Controls.Add(this._ricTxt_KonuDetay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Icerik";
            this.Text = "Icerik";
            this.Load += new System.EventHandler(this.Icerik_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pctreHaberResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox _pctreHaberResim;
        public System.Windows.Forms.RichTextBox _ricTxt_KonuDetay;
        public System.Windows.Forms.Label _lblTarih;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnDetayLink;
        public System.Windows.Forms.RichTextBox _rictxtBaslik;
        private System.Windows.Forms.Button _btnYaziBuyut;
        private System.Windows.Forms.Button _btnYaziKucult;
    }
}