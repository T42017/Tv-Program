using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_program
{
    class Channels
    {
        
        public static void standardScreen(ListBox box)
        {
            box.Items.Clear();
            box.Items.Add("Viasat motor");
            box.Items.Add("Viasat Film action");
            box.Items.Add("TV6");
        }
    }
}
