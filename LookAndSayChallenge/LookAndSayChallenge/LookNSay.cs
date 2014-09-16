using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookAndSayChallenge
{
    public partial class LookNSay : Form
    {
        public LookNSay()
        {
            InitializeComponent();
        }

        private LookNSayLogic lookSay;
        string textString;

        private void goButton_Click(object sender, EventArgs e)
        {
            lookSay = new LookNSayLogic(6);
            textString = lookSay.LookNSayMagic();
            lookNSayLabel.Text = textString;
        }
        
        
        
   
    }
}
