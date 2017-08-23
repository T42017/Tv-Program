using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;
using System.Threading;
using HtmlAgilityPack;
using System.Diagnostics;

namespace TV_program
{
    public partial class Form1 : Form
    {
        List<string> tvAvsnitt = new List<string>();
        List<string> tidStart = new List<string>();
        List<string> tidStop = new List<string>();
      

        int counter = 0;
        int tidCounter = 0;
        public Form1()
        {
          InitializeComponent();
            tvAvsnitt.Clear();
            var reader = new XmlTextReader("viaFilm.gz");
          
            while (reader.Read())
            {
                
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "title")
                    {
                        tvAvsnitt.Add(reader.ReadInnerXml());
                    }
                    else if (reader.Name == "programme")
                    {
                        DateTime start = DateTimeOffset.ParseExact(reader.GetAttribute("start"), "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
                        tidStart.Add(start.TimeOfDay.ToString());
                        DateTime stop = DateTimeOffset.ParseExact(reader.GetAttribute("stop"), "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
                        tidStop.Add(stop.TimeOfDay.ToString());
                    }
                    
                }

            }
        }
        private void selectBtn_Click(object sender, EventArgs e)
        {
            Hours.HtmlRetriever();
            for (int i = 0; i <= Hours.dwnlList.Count; i++)
            {
                Debug.WriteLine(Hours.dwnlList[i]);
                textBox1.Text += Hours.dwnlList[i];
            }
            
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter >= tvAvsnitt.Count)
            {
                counter = 0;
                tidCounter = 0;
                textBox1.Text = tvAvsnitt[counter];
                textBox1.Text += "\r\n" + tidStart[tidCounter];
                textBox1.Text += " - " + tidStop[tidCounter];
            }
            else
            {
                tidCounter += 1;
                textBox1.Text = tvAvsnitt[counter];
                textBox1.Text += "\r\n" + tidStart[tidCounter];
                textBox1.Text += " - " + tidStop[tidCounter];

            }
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = tvAvsnitt.Count -1;
                tidCounter = tvAvsnitt.Count - 1;
                textBox1.Text = tvAvsnitt[counter];
                textBox1.Text += "\r\n" + tidStart[tidCounter];
                textBox1.Text += " - " + tidStop[tidCounter];

            }
            else
            {
            textBox1.Text = tvAvsnitt[counter];
                tidCounter -= 1;
                textBox1.Text += "\r\n" + tidStart[tidCounter];
                textBox1.Text += " - " + tidStop[tidCounter];

            }
        }

    }
}
