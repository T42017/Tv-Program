using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;
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
            ChangeDate();
        }

        private void ChangeDate()
        {
            var proginfo = new List<ProgramInformation>();
            XmlDocument doc1 = new XmlDocument();
            var xmlFragment = "http://xmltv.xmltv.se/svt1.svt.se_" + SelDateTime.ToShortDateString() + ".xml.gz";
            var reader = new XmlTextReader(xmlFragment);
            var timeList = new List<string>();
            var titleList = new List<string>();
            tbxDateTime.Text = SelDateTime.ToString();
            lboxTitles.Items.Clear();
            
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
            
            foreach (var programInformation in proginfo)
            {
                lboxTitles.Items.Add(programInformation.Info);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelDateTime=SelDateTime.AddDays(-1);
            ChangeDate();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SelDateTime = SelDateTime.AddDays(+1);
            ChangeDate();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SelDateTime = DateTime.Now;
            ChangeDate();
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
