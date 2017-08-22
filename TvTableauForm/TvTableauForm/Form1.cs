using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;

namespace TvTableauForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient wc = new WebClient();
            string showTvGuide = wc.DownloadString("http://json.xmltv.se/svt1.svt.se_2017-08-22.js.gz");
            var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
            tbxShowTvTableau.Text = (showTableau.ToString());
        } 


    }
}
