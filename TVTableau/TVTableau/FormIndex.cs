using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TVTableau
{
    public partial class FormIndex : Form
    {
        private string _url;
        private DateTime _date;
        private RootObject _programmes;
        private WebClient _client;
        private Channels _currentChannel;
        private int _index = 0;

        public FormIndex()
        {
            InitializeComponent();
            _client = new WebClient();
            _date = DateTime.Now.Date;
            _currentChannel = Channels.SVT1;
            SetURL(_date);
            GetResponseFromWebClient(_url);
            this.LblSVT1CurrentDay.Text = DateTime.Now.Date.ToString("M");
            this.LbxSVT1Programmes.DisplayMember = "Header";

            string urlPath = GetUrlFromDate(_date, Channels.SVT2);
            MessageBox.Show(urlPath);
        }
        
        private void SetURL(DateTime date)
        {
            var dateString = date.ToString("yyyy-MM-dd");
            _url = $"http://json.xmltv.se/svt1.svt.se_{dateString}.js.gz";
        }

        private void GetResponseFromWebClient(string url)
        {
            try
            {
                var response = _client.DownloadString(url);
                _programmes = JsonConvert.DeserializeObject<RootObject>(response);
                
                this.LbxSVT1Programmes.Items.Clear();
                foreach (var programme in _programmes.JsonTv.Programmes)
                {
                    this.LbxSVT1Programmes.Items.Add(programme);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void BtnShowNext_Click(object sender, EventArgs e)
        {
            if (_index == _programmes.JsonTv.Programmes.Length) _index = 0;
            var programme = _programmes.JsonTv.Programmes[_index++];
            MessageBox.Show(programme.ToString(), programme.Title.ToString());
        }

        private void BtnSVT1PreviousDay_Click(object sender, EventArgs e)
        {
            _date = _date.AddDays(-1);
            SetURL(_date);
            this.LblSVT1CurrentDay.Text = _date.ToString("M");
            GetResponseFromWebClient(_url);
        }

        private void BtnSVT1NextDay_Click(object sender, EventArgs e)
        {
            _date = _date.AddDays(1);
            SetURL(_date);
            this.LblSVT1CurrentDay.Text = _date.ToString("M");
            GetResponseFromWebClient(_url);
        }

        private void LbxSVT1Programmes_DoubleClick(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            var selectedItem = listbox.SelectedItem as Programme;
            this.TbxSVT1SelectedProgramme.Text = selectedItem.ToString();
        }

        private void BtnPreviousChannel_Click(object sender, EventArgs e)
        {
            var previousChannel = _currentChannel == Channels.SVT1 ? Channels.TV6 : (Channels) ((int) _currentChannel - 1);
            _currentChannel = previousChannel;
            _url = GetUrlFromDate(_date, previousChannel);
            GetResponseFromWebClient(_url);
            ChangeImage();
        }

        private void BtnNextChannel_Click(object sender, EventArgs e)
        {
            var nextChannel = _currentChannel == Channels.TV6 ? Channels.SVT1 : (Channels)((int)_currentChannel + 1);
            _currentChannel = nextChannel;
            _url = GetUrlFromDate(_date, nextChannel);
            GetResponseFromWebClient(_url);
            ChangeImage();
        }

        private void ChangeImage()
        {
            string imagePath = @"Resources\Images\";
            switch (_currentChannel)
            {
                case Channels.SVT1:
                    imagePath += "svt1.jpg";
                    break;
                case Channels.SVT2:
                    imagePath += "svt2.png";
                    break;
                case Channels.TV3:
                    imagePath += "tv3.png";
                    break;
                case Channels.TV4:
                    imagePath += "tv4.png";
                    break;
                case Channels.Kanal5:
                    imagePath += "kanal5.jpg";
                    break;
                case Channels.TV6:
                    imagePath += "tv6.png";
                    break;
                default:
                    return;
            }
            this.PbxSVT1.Image = Image.FromFile(imagePath);
        }

        private string GetBaseUrlFromEnum(Channels channel)
        {
            string url = string.Empty;
            // TODO: check HD channels
            switch (channel)
            {
                case Channels.SVT1:
                    url = "http://json.xmltv.se/svt1.svt.se_XXXXXXXXXX.js.gz";
                    break;
                case Channels.SVT2:
                    url = "http://json.xmltv.se/svt2.svt.se_XXXXXXXXXX.js.gz";
                    break;
                case Channels.TV3:
                    url = "http://json.xmltv.se/hd.tv3.se_XXXXXXXXXX.js.gz";
                    break;
                case Channels.TV4:
                    url = "http://json.xmltv.se/hd.tv4.se_XXXXXXXXXX.js.gz";
                    break;
                case Channels.Kanal5:
                    url = "http://json.xmltv.se/hd.kanal5.se_XXXXXXXXXX.js.gz";
                    break;
                case Channels.TV6:
                    url = "http://json.xmltv.se/hd.tv6.se_XXXXXXXXXX.js.gz";
                    break;
                default:
                    break;
            }
            return url;
        }

        private string GetUrlFromDate(DateTime date, Channels channel)
        {
            string baseString = GetBaseUrlFromEnum(channel);
            baseString = baseString.Replace("XXXXXXXXXX", date.Date.ToString("yyyy-MM-dd"));
            return baseString;
        }
    }

    public enum Channels
    {
        SVT1 = 0,
        SVT2 = 1,
        TV3 = 2,
        TV4 = 3,
        Kanal5 = 4,
        TV6 = 5
    }
}
