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
using System.Xml;
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
            var proginfo = new List<ProgramInformation>();
            XmlDocument doc1 = new XmlDocument ();
            var reader = new XmlTextReader("http://xmltv.xmltv.se/svt1.svt.se_2017-08-24.xml.gz");
            var timeList = new List<string>();
            var titleList = new List<string>();
            

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "title")
                        {
                            titleList.Add(reader.ReadInnerXml());
                        }
                        if (reader.Name == "programme")
                        {
                            timeList.Add(reader.GetAttribute(0));
                        }
                        break;
                }
            }
            for (int i = 0; i < timeList.Count; i++)
            {
                string year = timeList[i].Remove(4);
                string monthAndDay = timeList[i][4].ToString() + timeList[i][5] + "/" + timeList[i][6] + timeList[i][7];
                string timeOfShow = timeList[i][8].ToString() + timeList[i][9] + ":" + timeList[i][10] + timeList[i][11];

                timeList[i] = year + "  " + monthAndDay + " - " + timeOfShow;
            }

            for (int i = 0; i < titleList.Count; i++)
            {
                proginfo.Add(new ProgramInformation(titleList[i], timeList[i]));
            }
          //  int y = 0;
            foreach (var programInformation in proginfo)
            {
                //groupBox1.Controls.Add(new Label()
                //{
                //    Text = programInformation.Info,
                //    Location = new Point(10, 10 + y)
                //});
                //y += 25;
                lboxTitles.Items.Add(programInformation.Info);
            }
            //textBox1.Text = SelDateTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelDateTime=SelDateTime.AddDays(-1);
            tbxDateTime.Text = SelDateTime.ToString();

            lboxTitles.Items.Clear();
            var proginfo = new List<ProgramInformation>();
            XmlDocument doc1 = new XmlDocument();
            var timeList = new List<string>();
            var titleList = new List<string>();
            var readbwrd = new XmlTextReader("http://xmltv.xmltv.se/svt1.svt.se_2017-08-23.xml.gz");

            while (readbwrd.Read())
            {
                switch (readbwrd.NodeType)
                {
                    case XmlNodeType.Element:
                        if (readbwrd.Name == "title")
                        {
                            titleList.Add(readbwrd.ReadInnerXml());
                        }
                        if (readbwrd.Name == "programme")
                        {
                            timeList.Add(readbwrd.GetAttribute(0));
                        }
                        break;
                }
            }
            for (int i = 0; i < timeList.Count; i++)
            {
                string year = timeList[i].Remove(4);
                string monthAndDay = timeList[i][4].ToString() + timeList[i][5] + "/" + timeList[i][6] + timeList[i][7];
                string timeOfShow = timeList[i][8].ToString() + timeList[i][9] + ":" + timeList[i][10] + timeList[i][11];

                timeList[i] = year + "  " + monthAndDay + " - " + timeOfShow;
            }

            for (int i = 0; i < titleList.Count; i++)
            {
                proginfo.Add(new ProgramInformation(titleList[i], timeList[i]));
            }
            //int y = 0;
            foreach (var programInformation in proginfo)
            {
                //groupBox1.Controls.Add(new Label()
                //{
                //    Text = programInformation.Info,
                //    Location = new Point(10, 10 + y)
                //});
                //y += 25;
                lboxTitles.Items.Add(programInformation.Info);
            }
            //textBox1.Text = SelDateTime.ToString();
        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            SelDateTime = SelDateTime.AddDays(+1);
            tbxDateTime.Text = SelDateTime.ToString();
            lboxTitles.Items.Clear();
            var proginfo = new List<ProgramInformation>();
            XmlDocument doc1 = new XmlDocument();
            var timeList = new List<string>();
            var titleList = new List<string>();
            var readbwrd = new XmlTextReader("http://xmltv.xmltv.se/svt1.svt.se_2017-08-25.xml.gz");

            while (readbwrd.Read())
            {
                switch (readbwrd.NodeType)
                {
                    case XmlNodeType.Element:
                        if (readbwrd.Name == "title")
                        {
                            titleList.Add(readbwrd.ReadInnerXml());
                        }
                        if (readbwrd.Name == "programme")
                        {
                            timeList.Add(readbwrd.GetAttribute(0));
                        }
                        break;
                }
            }
            for (int i = 0; i < timeList.Count; i++)
            {
                string year = timeList[i].Remove(4);
                string monthAndDay = timeList[i][4].ToString() + timeList[i][5] + "/" + timeList[i][6] + timeList[i][7];
                string timeOfShow = timeList[i][8].ToString() + timeList[i][9] + ":" + timeList[i][10] + timeList[i][11];

                timeList[i] = year + "  " + monthAndDay + " - " + timeOfShow;
            }

            for (int i = 0; i < titleList.Count; i++)
            {
                proginfo.Add(new ProgramInformation(titleList[i], timeList[i]));
            }
            //int y = 0;
            foreach (var programInformation in proginfo)
            {
                //groupBox1.Controls.Add(new Label()
                //{
                //    Text = programInformation.Info,
                //    Location = new Point(10, 10 + y)
                //});
                //y += 25;
                lboxTitles.Items.Add(programInformation.Info);
            }
            //textBox1.Text = SelDateTime.ToString();
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            SelDateTime = DateTime.Now;
            tbxDateTime.Text = SelDateTime.ToString();
            lboxTitles.Items.Clear();
            var proginfo = new List<ProgramInformation>();
            XmlDocument doc1 = new XmlDocument();
            var timeList = new List<string>();
            var titleList = new List<string>();
            var readbwrd = new XmlTextReader("http://xmltv.xmltv.se/svt1.svt.se_2017-08-24.xml.gz");

            while (readbwrd.Read())
            {
                switch (readbwrd.NodeType)
                {
                    case XmlNodeType.Element:
                        if (readbwrd.Name == "title")
                        {
                            titleList.Add(readbwrd.ReadInnerXml());
                        }
                        if (readbwrd.Name == "programme")
                        {
                            timeList.Add(readbwrd.GetAttribute(0));
                        }
                        break;
                }
            }
            for (int i = 0; i < timeList.Count; i++)
            {
                string year = timeList[i].Remove(4);
                string monthAndDay = timeList[i][4].ToString() + timeList[i][5] + "/" + timeList[i][6] + timeList[i][7];
                string timeOfShow = timeList[i][8].ToString() + timeList[i][9] + ":" + timeList[i][10] + timeList[i][11];

                timeList[i] = year + "  " + monthAndDay + " - " + timeOfShow;
            }

            for (int i = 0; i < titleList.Count; i++)
            {
                proginfo.Add(new ProgramInformation(titleList[i], timeList[i]));
            }
            //int y = 0;
            foreach (var programInformation in proginfo)
            {
                //groupBox1.Controls.Add(new Label()
                //{
                //    Text = programInformation.Info,
                //    Location = new Point(10, 10 + y)
                //});
                //y += 25;
                lboxTitles.Items.Add(programInformation.Info);
            }
            //textBox1.Text = SelDateTime.ToString();
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
