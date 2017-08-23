using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace TvTableauForm
{
    public partial class Form1 : Form
    {
        private DateTime _dateSvt1;
        private DateTime _dateSvt2;
        private DateTime _dateTv3;
        private string _stringDate;
        private readonly WebClient _wc;
        private readonly string _error;

        public Form1()
        {
            InitializeComponent();

            _error = "Can't show any more tableaus!";
            _dateSvt1 = DateTime.Now;
            _dateSvt2 = DateTime.Now;
            _dateTv3 = DateTime.Now;
            _wc = new WebClient();
            _stringDate = _dateSvt1.ToString("yyyy-MM-dd");
            string showTvGuideSvt1 = _wc.DownloadString($"http://json.xmltv.se/svt1.svt.se_{_stringDate}.js.gz");
            string showTvGuideSvt2 = _wc.DownloadString($"http://json.xmltv.se/svt2.svt.se_{_stringDate}.js.gz");
            string showTvGuideTv3 = _wc.DownloadString($"http://json.xmltv.se/tv3.se_{_stringDate}.js.gz");
            var showTableauSvt1 = JsonConvert.DeserializeObject<Rootobject>(showTvGuideSvt1);
            var showTableauSvt2 = JsonConvert.DeserializeObject<Rootobject>(showTvGuideSvt2);
            var showTableauTv3 = JsonConvert.DeserializeObject<Rootobject>(showTvGuideTv3);
            tbxShowTvTableauSVT1.Text = showTableauSvt1.ToString();
            tbxShowTvTableauSVT2.Text = showTableauSvt2.ToString();
            tbxShowTvTableauTV3.Text = showTableauTv3.ToString();
            pbxSVT1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSVT2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxTV3.SizeMode = PictureBoxSizeMode.StretchImage;
            lblDateSVT1.Text = DateTime.Today.ToString("D");
            lblDateSVT2.Text = DateTime.Today.ToString("D");
            lblDateTV3.Text = DateTime.Today.ToString("D");

        }
        
        private void btnPreviousSVT1_Click(object sender, EventArgs e)
        {

            try
            {
                _dateSvt1 = _dateSvt1.AddDays(-1);
                _stringDate = _dateSvt1.ToString("yyyy-MM-dd");
                string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/svt1.svt.se_{_stringDate}.js.gz");
                var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
                tbxShowTvTableauSVT1.Text = showTableau.ToString();
                lblDateSVT1.Text = _dateSvt1.ToString("D");
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(+1);
            }
        }

        private void btnTodaySVT1_Click(object sender, EventArgs e)
        {
            _dateSvt1 = DateTime.Now.Date;
            _stringDate = _dateSvt1.ToString("yyyy-MM-dd");
            string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/svt1.svt.se_{_stringDate}.js.gz");
            var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
            tbxShowTvTableauSVT1.Text = showTableau.ToString();
            lblDateSVT1.Text = DateTime.Today.ToString("D");
        }

        private void btnNextSTV1_Click(object sender, EventArgs e)
        {
            try
            {
                _dateSvt1 = _dateSvt1.AddDays(1);
                _stringDate = _dateSvt1.ToString("yyyy-MM-dd");
                string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/svt1.svt.se_{_stringDate}.js.gz");
                var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
                tbxShowTvTableauSVT1.Text = showTableau.ToString();
                lblDateSVT1.Text = _dateSvt1.ToString("D");
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(-1);
            }
        }

        private void btnPreviousDaySVT2_Click(object sender, EventArgs e)
        {
            try
            {
                _dateSvt2 = _dateSvt2.AddDays(-1);
                _stringDate = _dateSvt2.ToString("yyyy-MM-dd");
                string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/svt2.svt.se_{_stringDate}.js.gz");
                var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
                tbxShowTvTableauSVT2.Text = showTableau.ToString();
                lblDateSVT2.Text = _dateSvt2.ToString("D");
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(+1);
            }
        }

        private void btnTodaySVT2_Click(object sender, EventArgs e)
        {
            _dateSvt2 = DateTime.Now.Date;
            _stringDate = _dateSvt2.ToString("yyyy-MM-dd");
            string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/svt2.svt.se_{_stringDate}.js.gz");
            var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
            tbxShowTvTableauSVT2.Text = showTableau.ToString();
            lblDateSVT2.Text = _dateSvt2.ToString("D");
        }

        private void btnNextDaySVT2_Click(object sender, EventArgs e)
        {
            try
            {
                _dateSvt2 = _dateSvt2.AddDays(+1);
                _stringDate = _dateSvt2.ToString("yyyy-MM-dd");
                string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/svt2.svt.se_{_stringDate}.js.gz");
                var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
                tbxShowTvTableauSVT2.Text = showTableau.ToString();
                lblDateSVT2.Text = _dateSvt2.ToString("D");
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(-1);
            }
        }

        private void btnPreviousDayTV3_Click(object sender, EventArgs e)
        {
            try
            {
                _dateTv3 = _dateTv3.AddDays(-1);
                _stringDate = _dateTv3.ToString("yyyy-MM-dd");
                string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/tv3.se_{_stringDate}.js.gz");
                var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
                tbxShowTvTableauTV3.Text = showTableau.ToString();
                lblDateTV3.Text = _dateTv3.ToString("D");
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(+1);
            }
        }

        private void btnTodayTV3_Click(object sender, EventArgs e)
        {
            _dateTv3 = DateTime.Now.Date;
            _stringDate = _dateTv3.ToString("yyyy-MM-dd");
            string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/tv3.se_{_stringDate}.js.gz");
            var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
            tbxShowTvTableauTV3.Text = showTableau.ToString();
            lblDateTV3.Text = _dateTv3.ToString("D");
        }

        private void btnNextDayTV3_Click(object sender, EventArgs e)
        {
            try
            {
                _dateTv3 = _dateTv3.AddDays(+1);
                _stringDate = _dateTv3.ToString("yyyy-MM-dd");
                string showTvGuide = _wc.DownloadString($"http://json.xmltv.se/tv3.se_{_stringDate}.js.gz");
                var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
                tbxShowTvTableauTV3.Text = showTableau.ToString();
                lblDateTV3.Text = _dateTv3.ToString("D");
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(-1);
            }
        }
    }
}
