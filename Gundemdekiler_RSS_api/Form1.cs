using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // xml için kütüphane
using Gundemdekiler_RSS_api.XmlModel;
using System.Net; // webRequest kullanmak için

namespace Gundemdekiler_RSS_api
{
    public partial class Form1 : Form
    {
        List<XmlEtiket> _List_Haber = new List<XmlEtiket>();
        List<string> _listem = new List<string>();
        XmlReader _okuyucu;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xml dosya okuyucu
        /// </summary>
        /// <param name="okuyucu"></param>
        void DegerOku(XmlReader okuyucu)
        {
            if (okuyucu.Read())
            {
                _listem.Add(okuyucu.Value.Trim());
            }
        }

        /// <summary>
        /// Xml web sayfasından haberleri list içerisine basar
        /// </summary>
        /// <param name="webAdres"></param>
        void HaberOkuyucu(string webAdres)
        {            
            this._lstBasliklar.Items.Clear();
            this._List_Haber.Clear();
            this._listem.Clear();
            #region okuma
            try
            {


                using (_okuyucu = XmlReader.Create(webAdres))
                {
                    while (_okuyucu.Read())
                    {
                        if (_okuyucu.IsStartElement())
                        {
                            XmlEtiket _HaberModel = new XmlEtiket();
                            switch (_okuyucu.Name)
                            {
                                case "icon":
                                    DegerOku(_okuyucu);
                                    break;
                                case "link":
                                    DegerOku(_okuyucu);
                                    break;
                                case "title":
                                    DegerOku(_okuyucu);
                                    break;
                                case "description":
                                    DegerOku(_okuyucu);
                                    break;
                                case "pubDate":
                                    DegerOku(_okuyucu);
                                    break;
                                case "image":
                                    DegerOku(_okuyucu);
                                    break;
                                default:
                                    break;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Web sitesi bağlantı hatası.\nİnternet ayarlarınızı kontrol ediniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                throw;
            }
    #endregion
    //rss sayfasındaki ilk 6 elemanı silicez. sadece haber başlıklarını almak için
    string[] _nesne = new string[_listem.Count - 6];
            //bu foreach xml meta bilgilerini siler. sadece haber başlıklarımız görünsün diye
            int i = 0;
            foreach (var item in _listem.Skip(6))
            {
                _nesne[i] = item;
                i++;
            }
            string _Duzenle;
            for (int k = 0; k < _nesne.Length; k += 5)
            {
                XmlEtiket haber = new XmlEtiket();
                haber.link = _nesne[k];
                _Duzenle = _nesne[k + 1];
                _Duzenle = _Duzenle.Replace("&#39;", "'");
                haber.title = _Duzenle;
                _Duzenle = _nesne[k + 2];
                _Duzenle = _Duzenle.Replace("&#39;", "'").Replace("&quot;", "'");
                haber.description = _Duzenle;
                haber.pubDate = Convert.ToDateTime(_nesne[k + 3]);
                haber.image = _nesne[k + 4];
                _List_Haber.Add(haber);
            }
        }
        /// <summary>
        /// Buton içerisindeki list item.title içeriğini _lstBasliklar listBox'a basar
        /// </summary>
        void KonuBasici(string konu)
        {
            _lblKonuBaslik.Text = konu;
            //_lstBasliklar.Items.Clear();// her butona basışında önceki haberleri listeden silmek için
            foreach (var item in _List_Haber)
            {
                _lstBasliklar.Items.Add(item.title);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _lblKonuBaslik.Font = new Font("Times New Roman",18, FontStyle.Regular);
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/all/news");
            KonuBasici("Son Dakika");
            _picIcon.SizeMode = PictureBoxSizeMode.StretchImage; //resim picturebox a göre boyutu ayarlansın
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer2.Interval = 1200;
            timer2.Enabled = true;
        }
        
        private void _lstBasliklar_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Icerik icerik = new Icerik();
            icerik.Show();
            foreach (var item in _List_Haber)
            {
                if (_lstBasliklar.SelectedItem == item.title) //Hangi haberi seçilirse. o haberin detayları geliyor
                {
                    icerik._ricTxt_KonuDetay.Text = (item.description);
                    icerik._pctreHaberResim.ImageLocation = item.image;
                    icerik._pctreHaberResim.SizeMode = PictureBoxSizeMode.StretchImage; //resim picturebox a göre boyutu ayarlansın
                    icerik._rictxtBaslik.Text = item.title.ToUpper();
                    icerik._lblTarih.Text = item.pubDate.ToString();
                    icerik.WebAdres = item.link;
                    break;
                }
            }
            }

        private void _btnSonDakika_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/all/news");
            KonuBasici("Son Dakika");
        }

        private void _btnKulturSanat_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/turkiye/news");
            KonuBasici("Kültür Sanat");
        }

        private void _btnBilim_Click(object sender, EventArgs e)
        {        
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
            KonuBasici("Bilim");
        }

        private void _btnMagazin_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/magazin/news");
            KonuBasici("Magazin");
        }

        private void _btnEkonomi_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/ekonomi/news");
            KonuBasici("Ekonomi");
        }

        private void _btnSpor_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/spor/news");
            KonuBasici("Spor");
        }

        private void _btnSaglik_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/saglik/news");
            KonuBasici("Sağlık");
        }

        private void _btnSeyahat_Click(object sender, EventArgs e)
        {
            HaberOkuyucu("https://www.cnnturk.com/feed/rss/seyahat/news");
            KonuBasici("Seyahat");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            _btnSonDakika.BackColor = Color.Red;
            _btnSonDakika.ForeColor = Color.White;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _btnSonDakika.BackColor = Color.White;
            _btnSonDakika.ForeColor = Color.Black;
        }
        
    }
}
