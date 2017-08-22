using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TvTable
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var programInfos = new List<ProgramInfo>();
            XmlDocument doc1 = new XmlDocument();
            var reader = new XmlTextReader("http://xmltv.xmltv.se/animalplanet.se_2017-09-10.xml.gz");
            var titleList = new List<string>();
            var timeList = new List<string>();
            
           
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
                string time = timeList[i][8].ToString() + timeList[i][9] + ":" + timeList[i][10] + timeList[i][11];

                timeList[i] = year + " - " + monthAndDay + " - " + time;
            }
            

            for (int i = 0; i < titleList.Count; i++)
            {
                programInfos.Add(new ProgramInfo(titleList[i], timeList[i]));
            }

            foreach (ProgramInfo info in programInfos)
            {
                listBox1.Items.Add(info.Info);
            }
            
        }
    }
}
