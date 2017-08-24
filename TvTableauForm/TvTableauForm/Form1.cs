using Newtonsoft.Json;
using System;
using System.Drawing;
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
        private string _showTvGuideSvt1;
        private string _showTvGuideSvt2;
        private string _showTvGuideTv3;
        private Rootobject _showTableauSvt1;
        private Rootobject _showTableauSvt2;
        private Rootobject _showTableauTv3;
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
            _showTvGuideSvt1 = _wc.DownloadString($"http://json.xmltv.se/svt1.svt.se_{_stringDate}.js.gz");
            _showTvGuideSvt2 = _wc.DownloadString($"http://json.xmltv.se/svt2.svt.se_{_stringDate}.js.gz");
            _showTvGuideTv3 = _wc.DownloadString($"http://json.xmltv.se/tv3.se_{_stringDate}.js.gz");
            _showTableauSvt1 = JsonConvert.DeserializeObject<Rootobject>(_showTvGuideSvt1);
            _showTableauSvt2 = JsonConvert.DeserializeObject<Rootobject>(_showTvGuideSvt2);
            _showTableauTv3 = JsonConvert.DeserializeObject<Rootobject>(_showTvGuideTv3);
            rtbxShowTvTableauSvt1.Text = _showTableauSvt1.ToString();
            rtbxShowTvTableauSvt2.Text = _showTableauSvt2.ToString();
            rtbxShowTvTableauTv3.Text = _showTableauTv3.ToString();
            pbxSVT1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSVT2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxTV3.SizeMode = PictureBoxSizeMode.StretchImage;
            lblDateSVT1.Text = DateTime.Today.ToString("D");
            lblDateSVT2.Text = DateTime.Today.ToString("D");
            lblDateTV3.Text = DateTime.Today.ToString("D");
            //ProgramRightNow(Channel.Svt1);
            //ProgramRightNow(Channel.Svt2);
            //ProgramRightNow(Channel.Tv3);
        }
        private enum Channel
        {
            Svt1,
            Svt2,
            Tv3
        }
        //private void ProgramRightNow(Channel channel)
        //{
        //    var today = DateTime.Now;
        //    switch (channel)
        //    {
        //        case Channel.Svt1:
        //            foreach (var programme in _showTableauSvt1.JsonTv.Program)
        //            {
        //                var programmeStarts = Programme.ConvertFromUnixTimestamp(double.Parse(programme.Start));
        //                var programEnds = Programme.ConvertFromUnixTimestamp(double.Parse(programme.Stop));
        //                if (programmeStarts < today && programEnds > today)
        //                    {
        //                        int startIndex = rtbxShowTvTableauSvt1.Text.IndexOf(programme.ToString(), StringComparison.Ordinal);
        //                        int lengthOfIndex = programme.ToString().Length;
        //                        rtbxShowTvTableauSvt1.Select(startIndex, lengthOfIndex);
        //                        rtbxShowTvTableauSvt1.SelectionBackColor = Color.Yellow;
        //                    }
        //            }
        //            break;

        //        case Channel.Svt2:
        //            foreach (var programme in _showTableauSvt2.JsonTv.Program)
        //            {
        //                var programmeStarts = Programme.ConvertFromUnixTimestamp(double.Parse(programme.Start));
        //                var programEnds = Programme.ConvertFromUnixTimestamp(double.Parse(programme.Stop));
        //                if (programmeStarts < today && programEnds > today)
        //                {
        //                    int startIndex = rtbxShowTvTableauSvt2.Text.IndexOf(programme.ToString(), StringComparison.Ordinal);
        //                    int lengthOfIndex = programme.ToString().Length;
        //                    rtbxShowTvTableauSvt2.Select(startIndex, lengthOfIndex);
        //                    rtbxShowTvTableauSvt2.SelectionBackColor = Color.Yellow;
        //                }
        //                else
        //                {
        //                    return;
        //                }
        //            }
        //            break;

        //        case Channel.Tv3:
        //            foreach (var programme in _showTableauTv3.JsonTv.Program)
        //            {
        //                var programmeStarts = Programme.ConvertFromUnixTimestamp(double.Parse(programme.Start));
        //                var programEnds = Programme.ConvertFromUnixTimestamp(double.Parse(programme.Stop));
        //                if (programmeStarts < today && programEnds > today)
        //                {
        //                    int startIndex = rtbxShowTvTableauTv3.Text.IndexOf(programme.ToString(), StringComparison.Ordinal);
        //                    int lengthOfIndex = programme.ToString().Length;
        //                    rtbxShowTvTableauTv3.Select(startIndex, lengthOfIndex);
        //                    rtbxShowTvTableauTv3.SelectionBackColor = Color.Yellow;
        //                }
        //            }
        //            break;
        //    }
        //}


        

        private void SetDayAndGetTableau(Channel channel, int amountOfDaysToAdd)
        {
            switch (channel)
            {
                case Channel.Svt1:
                    _dateSvt1 = _dateSvt1.AddDays(amountOfDaysToAdd);
                    _stringDate = _dateSvt1.ToString("yyyy-MM-dd");
                    _showTvGuideSvt1 = _wc.DownloadString($"http://json.xmltv.se/svt1.svt.se_{_stringDate}.js.gz");
                    _showTableauSvt1 = JsonConvert.DeserializeObject<Rootobject>(_showTvGuideSvt1);
                    rtbxShowTvTableauSvt1.Text = _showTableauSvt1.ToString();
                    lblDateSVT1.Text = _dateSvt1.ToString("D");
                    break;

                case Channel.Svt2:
                    _dateSvt2 = _dateSvt2.AddDays(amountOfDaysToAdd);
                    _stringDate = _dateSvt2.ToString("yyyy-MM-dd");
                    _showTvGuideSvt2 = _wc.DownloadString($"http://json.xmltv.se/svt2.svt.se_{_stringDate}.js.gz");
                    _showTableauSvt2 = JsonConvert.DeserializeObject<Rootobject>(_showTvGuideSvt2);
                    rtbxShowTvTableauSvt2.Text = _showTableauSvt2.ToString();
                    lblDateSVT2.Text = _dateSvt2.ToString("D");
                    break;

                case Channel.Tv3:
                    _dateTv3 = _dateTv3.AddDays(amountOfDaysToAdd);
                    _stringDate = _dateTv3.ToString("yyyy-MM-dd");
                    _showTvGuideTv3 = _wc.DownloadString($"http://json.xmltv.se/tv3.se_{_stringDate}.js.gz");
                    _showTableauTv3 = JsonConvert.DeserializeObject<Rootobject>(_showTvGuideTv3);
                    rtbxShowTvTableauTv3.Text = _showTableauTv3.ToString();
                    lblDateTV3.Text = _dateTv3.ToString("D");
                    break;

                default:
                    return;
            }
            
        }


        private void btnPreviousSVT1_Click(object sender, EventArgs e)
        {
            try
            {
                SetDayAndGetTableau(Channel.Svt1, -1);
                //ProgramRightNow(Channel.Svt1); 
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt1 = _dateSvt1.AddDays(+1);
            }
        }

        private void btnTodaySVT1_Click(object sender, EventArgs e)
        {
            _dateSvt1 = DateTime.Today;
            SetDayAndGetTableau(Channel.Svt1, 0);
            //ProgramRightNow(Channel.Svt1);
            lblDateSVT1.Text = DateTime.Today.ToString("D");
        }

        private void btnNextSTV1_Click(object sender, EventArgs e)
        {
            try
            {
                SetDayAndGetTableau(Channel.Svt1, +1);
                //ProgramRightNow(Channel.Svt1);
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
                SetDayAndGetTableau(Channel.Svt2, -1);
                //ProgramRightNow(Channel.Svt2);
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
            SetDayAndGetTableau(Channel.Svt2, 0);
            //ProgramRightNow(Channel.Svt2);
            lblDateSVT2.Text = _dateSvt2.ToString("D");
        }

        private void btnNextDaySVT2_Click(object sender, EventArgs e)
        {
            try
            {
                SetDayAndGetTableau(Channel.Svt2, +1);
                //ProgramRightNow(Channel.Svt2);
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateSvt2 = _dateSvt2.AddDays(-1);
            }
        }

        private void btnPreviousDayTV3_Click(object sender, EventArgs e)
        {
            try
            {
                SetDayAndGetTableau(Channel.Tv3, -1);
                //ProgramRightNow(Channel.Tv3);
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateTv3 = _dateTv3.AddDays(+1);
            }
        }

        private void btnTodayTV3_Click(object sender, EventArgs e)
        {
            _dateTv3 = DateTime.Now.Date;
            SetDayAndGetTableau(Channel.Tv3, 0);
            //ProgramRightNow(Channel.Tv3);
            lblDateTV3.Text = _dateTv3.ToString("D");
        }

        private void btnNextDayTV3_Click(object sender, EventArgs e)
        {
            try
            {
                SetDayAndGetTableau(Channel.Tv3, +1);
                //ProgramRightNow(Channel.Tv3);
            }
            catch (Exception)
            {

                MessageBox.Show(_error);
                _dateTv3 = _dateTv3.AddDays(-1);
            }
        }

    }
}
