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
        #region Private members
        private readonly WebClient _client;
        private string _url;
        private DateTime _date;
        private Programme[] _programmes;
        private Channel _currentChannel;
        #endregion

        #region Constructors
        public FormIndex()
        {
            InitializeComponent();
            _client = new WebClient();
            _date = DateTime.Now;
            _currentChannel = Channel.Svt1;
            _url = GetUrlFromDateAndChannel(_date, _currentChannel);
            GetResponseFromWebClient(_url);
            this.LblCurrentDay.Text = DateTime.Now.Date.ToString("M");
            this.LbxProgrammes.DrawMode = DrawMode.OwnerDrawFixed;
            foreach (var child in this.Controls)
            {
                if (!(child is Button button))
                    continue;
                button.Click += (sender, e) => ReloadListBox();
            }
            this.BtnPreviousDay.Click += (sender, e) =>
            {
                if (!(sender is Button button))
                    return;
                if (!this.BtnNextDay.Enabled)
                {
                    this.BtnNextDay.Enabled = true;
                }
            };
            this.BtnNextDay.Click += (sender, e) =>
            {
                if (!(sender is Button button))
                    return;
                if (!this.BtnPreviousDay.Enabled)
                {
                    this.BtnPreviousDay.Enabled = true;
                }
            };
        }
        #endregion

        #region Private methods

        private void ReloadListBox()
        {
            this.LbxProgrammes.Items.Clear();
            foreach (var programme in _programmes)
            {
                this.LbxProgrammes.Items.Add(programme);
            }
        }

        private string GetBaseUrlFromEnum(Channel channel)
        {
            string url = string.Empty;
            switch (channel)
            {
                case Channel.Svt1:
                    url = "http://json.xmltv.se/svt1.svt.se_XXXXXXXXXX.js.gz";
                    break;
                case Channel.Svt2:
                    url = "http://json.xmltv.se/svt2.svt.se_XXXXXXXXXX.js.gz";
                    break;
                case Channel.Tv3:
                    url = "http://json.xmltv.se/tv3.se_XXXXXXXXXX.js.gz";
                    break;
                case Channel.Tv4:
                    url = "http://json.xmltv.se/tv4.se_XXXXXXXXXX.js.gz";
                    break;
                case Channel.Kanal5:
                    url = "http://json.xmltv.se/kanal5.se_XXXXXXXXXX.js.gz";
                    break;
                case Channel.Tv6:
                    url = "http://json.xmltv.se/tv6.se_XXXXXXXXXX.js.gz";
                    break;
            }
            return url;
        }

        private string GetUrlFromDateAndChannel(DateTime date, Channel channel)
        {
            string url = GetBaseUrlFromEnum(channel);
            url = url.Replace("XXXXXXXXXX", date.Date.ToString("yyyy-MM-dd"));
            return url;
        }

        private void GetResponseFromWebClient(string url)
        {
            try
            {
                var response = _client.DownloadString(url);
                var rootObject = JsonConvert.DeserializeObject<RootObject>(response);
                _programmes = rootObject.JsonTv.Programmes;

                ReloadListBox();
            }
            catch (Exception ex)
            {
                throw ex; // TODO
            }
        }

        private void ChangeImage()
        {
            string imagePath = @"Resources\Images\";
            switch (_currentChannel)
            {
                case Channel.Svt1:
                    imagePath += "svt1.jpg";
                    break;
                case Channel.Svt2:
                    imagePath += "svt2.png";
                    break;
                case Channel.Tv3:
                    imagePath += "tv3.png";
                    break;
                case Channel.Tv4:
                    imagePath += "tv4.png";
                    break;
                case Channel.Kanal5:
                    imagePath += "kanal5.jpg";
                    break;
                case Channel.Tv6:
                    imagePath += "tv6.png";
                    break;
                default:
                    return;
            }
            this.PbxCurrentChannel.Image = Image.FromFile(imagePath);
        }

        private void AddDaysAndGetResponseFromWebClient(int amountOfDaysToAdd)
        {
            //_date = _date.AddDays(amountOfDaysToAdd);
            //_url = GetUrlFromDateAndChannel(_date, _currentChannel);
            //this.LblCurrentDay.Text = _date.ToString("M");
            //GetResponseFromWebClient(_url);

            try
            {
                _date = _date.AddDays(amountOfDaysToAdd);
                _url = GetUrlFromDateAndChannel(_date, _currentChannel);
                this.LblCurrentDay.Text = _date.ToString("M");
                GetResponseFromWebClient(_url);
            }
            catch (Exception ex)
            {
                throw ex; // TODO
            }

        }
        #endregion

        #region Event handlers
        private void LbxProgrammes_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var fontStyle = FontStyle.Regular;

            if (e.Index < 0 || e.Index >= _programmes.Length)
                return;

            if (!(this.LbxProgrammes.Items[e.Index] is Programme programme) || programme == null)
                return;

            var programmeStart = HelperMethods.ConvertFromUnixTimestampToDateTime(programme.Start);
            var programmeEnd   = HelperMethods.ConvertFromUnixTimestampToDateTime(programme.Stop);

            var dateTimeOfDay = DateTime.Now.TimeOfDay;
            if ((DateTime.Today.Date == programmeStart.Date) && 
                (dateTimeOfDay >= programmeStart.TimeOfDay) && 
                (dateTimeOfDay <= programmeEnd.TimeOfDay))
            {
                fontStyle = FontStyle.Bold;
            }
            e.Graphics.DrawString(programme.Header, new Font("Microsoft Sans Serif", 7, fontStyle), Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void BtnPreviousDay_Click(object sender, EventArgs e)
        {
            //AddDaysAndGetResponseFromWebClient(-1);
            //TbxSelectedProgramme.Clear();

            try
            {
                AddDaysAndGetResponseFromWebClient(-1);
                TbxSelectedProgramme.Clear();
            }
            catch (Exception)
            {
                this.BtnPreviousDay.Enabled = false; // Doesn't work quite right
            }
        }

        private void BtnNextDay_Click(object sender, EventArgs e)
        {
            //AddDaysAndGetResponseFromWebClient(1);
            //TbxSelectedProgramme.Clear();
            try
            {
                AddDaysAndGetResponseFromWebClient(1);
                TbxSelectedProgramme.Clear();
            }
            catch (Exception)
            {
                this.BtnNextDay.Enabled = false; // Doesn't work quite right
            }
        }

        private void LbxProgrammes_DoubleClick(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            if (listbox == null)
                return;

            var selectedItem = listbox.SelectedItem as Programme;
            this.TbxSelectedProgramme.Text = selectedItem?.ToString();
        }

        private void BtnPreviousChannel_Click(object sender, EventArgs e)
        {
            var previousChannel = _currentChannel == Channel.Svt1 ? Channel.Tv6 : (Channel)((int)_currentChannel - 1);
            _currentChannel = previousChannel;
            _url = GetUrlFromDateAndChannel(_date, previousChannel);

            GetResponseFromWebClient(_url);

            ChangeImage();
            TbxSelectedProgramme.Clear();
        }

        private void BtnNextChannel_Click(object sender, EventArgs e)
        {
            var nextChannel = _currentChannel == Channel.Tv6 ? Channel.Svt1 : (Channel)((int)_currentChannel + 1);
            _currentChannel = nextChannel;
            _url = GetUrlFromDateAndChannel(_date, nextChannel);
            
            GetResponseFromWebClient(_url);
            
            ChangeImage();
            TbxSelectedProgramme.Clear();
        }

        private void PbxSwitchChannel_Click(object sender, EventArgs e)
        {
            if (!(sender is PictureBox pictureBox))
                return;

            switch (pictureBox.Name)
            {
                case "PbxSvt1":
                    _currentChannel = Channel.Svt1;
                    break;
                case "PbxSvt2":
                    _currentChannel = Channel.Svt2;
                    break;
                case "PbxTv3":
                    _currentChannel = Channel.Tv3;
                    break;
                case "PbxTv4":
                    _currentChannel = Channel.Tv4;
                    break;
                case "PbxKanal5":
                    _currentChannel = Channel.Kanal5;
                    break;
                case "PbxTv6":
                    _currentChannel = Channel.Tv6;
                    break;
                default:
                    return;
            }
            _url = GetUrlFromDateAndChannel(_date, _currentChannel);
            GetResponseFromWebClient(_url);
            ChangeImage();
            this.TbxSelectedProgramme.Clear();
        }
        #endregion

        #region Private enums
        private enum Channel
        {
            Svt1 = 0,
            Svt2 = 1,
            Tv3 = 2,
            Tv4 = 3,
            Kanal5 = 4,
            Tv6 = 5
        }
        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
