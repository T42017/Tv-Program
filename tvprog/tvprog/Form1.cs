using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace tvprog
{
    public partial class Form1 : Form
    {
        public DateTime SelDateTime=DateTime.Now;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // string contents = "";
          //  using (var wc = new System.Net.WebClient())
            //    contents = wc.DownloadString("http://xmltv.xmltv.se/svt1.svt.se_2017-08-22.xml.gz");

           // var t = StringXmlSerializer.Deserialize<tv>(contents);

            XDocument url = XDocument.Load("http://xmltv.xmltv.se/svt1.svt.se_2017-08-22.xml.gz");
            Debug.WriteLine(url);


            Debug.WriteLine("laddar svt1822.xml ....");
         //   var tmp = ObjectXMLSerializer<tv>.Load("svt1822.xml");
            var tmp = url;
            foreach (var program in url)
            {
                textBox2.AppendText("mm \r\n");
                Debug.WriteLine("nytt program:");
                Debug.WriteLine(program.title);
                Debug.WriteLine(program.start);
                Debug.WriteLine(program.stop);
                Debug.WriteLine(program.GetStartDateTime());
            }
            textBox1.Text = SelDateTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelDateTime=SelDateTime.AddDays(-1);
            textBox1.Text = SelDateTime.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelDateTime = SelDateTime.AddDays(+1);
            textBox1.Text = SelDateTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelDateTime = DateTime.Now;
            textBox1.Text = SelDateTime.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class tv
    {
        [XmlElement("programme")]
        public List<programme> programs = new List<programme>();
    }
    public class programme
    {
        [XmlAttribute]
        public string start;
        [XmlAttribute]
        public string stop;
        public string title;

        public DateTime GetStartDateTime()
        {
            return DateTimeOffset.ParseExact(start, "yyyyMMddHHmmss zzz", CultureInfo.InvariantCulture).DateTime;
        }
    }
}
