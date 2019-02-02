using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gundemdekiler_RSS_api
{
    public partial class Icerik : Form
    {
        public Icerik()
        {
            InitializeComponent();
        }

        private void Icerik_Load(object sender, EventArgs e)
        {
            _rictxtBaslik.ForeColor = Color.Red;
            _rictxtBaslik.Font = new Font("Georgia", 15, FontStyle.Bold);
            _ricTxt_KonuDetay.Font = new Font("Thomas", 12, FontStyle.Regular);
        }
        public string WebAdres;
        private void _btnDetayLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(WebAdres);
        }

        private void _pctreHaberResim_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(WebAdres);
        }

        float arttir = 1.1f;
        float azalt = 0.0f;
        private void _btnYaziBuyut_Click(object sender, EventArgs e)
        {            
            _ricTxt_KonuDetay.ZoomFactor = arttir-azalt;
            arttir += 0.1f;
        }
        
        private void _btnYaziKucult_Click(object sender, EventArgs e)
        {
            if (_ricTxt_KonuDetay.ZoomFactor > 0.2f) //10 kere küçültmeden sonra hata vermesin diye 
            {
                _ricTxt_KonuDetay.ZoomFactor = arttir - 0.2f - azalt;
                azalt += 0.1f;
            }
            
        }
    }
}
