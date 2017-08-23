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

namespace TV_program
{
    public partial class Form1 : Form
    {
        List<string> tvAvsnitt = new List<string>();
        List<string> tid = new List<string>();
        int counter = 0;
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
                        tid.Add(reader.GetAttribute("start"));
                        tid.Add(reader.GetAttribute("stop"));
                        textBox1.Text += tid[0];
                    }
                    
                }

            }
            //textBox1.Text = tvAvsnitt[counter];


        }
        private void selectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter >= tvAvsnitt.Count)
            {
                counter = 0;
                textBox1.Text = tvAvsnitt[counter];
            }
            else
            {
                textBox1.Text = tvAvsnitt[counter];
            }
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = tvAvsnitt.Count -1;
                textBox1.Text = tvAvsnitt[counter];
            }
            else
            {
            textBox1.Text = tvAvsnitt[counter];
            }
        }
    }
}
