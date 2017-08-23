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
        private int _index = 0;

        public FormIndex()
        {
            InitializeComponent();
            _client = new WebClient();
            _date = DateTime.Now.Date;
            SetURL(_date);
            GetResponseFromWebClient(_url);
            this.LblSVT1CurrentDay.Text = DateTime.Now.Date.ToString("M");
            this.LbxSVT1Programmes.DisplayMember = "Header";
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

                this.RtbxSVT1Programmes.Clear();
                foreach (var programme in _programmes.JsonTv.Programmes)
                {
                    this.RtbxSVT1Programmes.AppendText(programme.ToString() + "\r\n--------------\r\n");
                }

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
    }
}
