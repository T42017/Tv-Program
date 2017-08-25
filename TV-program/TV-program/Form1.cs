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
        string currentSelected = "";
        bool inChannel = false;
        bool isPress = false;
        int counter = 0;
        int tidCounter = 0;

        public Form1()
        {
            InitializeComponent();
            tvAvsnitt.Clear();

            Channels.standardScreen(textBox1);

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
 
            var reader = new XmlTextReader(currentSelected);
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

                isPress = true;
                try
                {
                    Hours.HtmlRetriever(textBox1.SelectedItem.ToString(), textBox1);
                }
                catch
                {
                    Channels.standardScreen(textBox1);
                }

                if (isPress)
                {
                    textBox1.Items.Clear();

                    for (int i = 0; i < Hours.dwnlList.Count; i++)
                    {
                        Debug.WriteLine(Hours.dwnlList[i]);
                        textBox1.Items.Add(Hours.dwnlList[i] + "\r\n");
                    }
                    isPress = false;
                    inChannel = true;
                }
                Hours.dwnlList.Clear();

            }
        }
            private void nextBtn_Click(object sender, EventArgs e)
            {
                counter++;

                if (counter >= tvAvsnitt.Count)
                {
                    counter = 0;
                    tidCounter = 0;
                    textBox2.Text = tvAvsnitt[counter];
                    textBox2.Text += "\r\n" + tidStart[tidCounter];
                    textBox2.Text += " - " + tidStop[tidCounter];
                }
                else
                {
                    tidCounter += 1;
                    textBox2.Text = tvAvsnitt[counter];
                    textBox2.Text += "\r\n" + tidStart[tidCounter];
                    textBox2.Text += " - " + tidStop[tidCounter];

                }
            }
            private void prevBtn_Click(object sender, EventArgs e)
            {
                counter--;
                if (counter < 0)
                {
                    counter = tvAvsnitt.Count - 1;
                    tidCounter = tvAvsnitt.Count - 1;
                    textBox2.Text = tvAvsnitt[counter];
                    textBox2.Text += "\r\n" + tidStart[tidCounter];
                    textBox2.Text += " - " + tidStop[tidCounter];

                }
                else
                {
                    textBox2.Text = tvAvsnitt[counter];
                    tidCounter -= 1;
                    textBox2.Text += "\r\n" + tidStart[tidCounter];
                    textBox2.Text += " - " + tidStop[tidCounter];

                }
            }

            private void backBtn_Click(object sender, EventArgs e)
            {
                Channels.standardScreen(textBox1);
                inChannel = false;
            }

            private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            currentSelected = textBox1.SelectedItem.ToString();
            }
        }
    }

