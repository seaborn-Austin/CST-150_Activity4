using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class secConvertFrm : Form
    {
        public secConvertFrm()
        {
            InitializeComponent();
        }

        private void secConversionBtn_Click(object sender, EventArgs e)
        {
            double seconds = double.Parse(secTxt.Text);
            double minutes = 0;
            double hours = 0;
            double day = 0;
            double result;
            if (seconds >= 86400)
            {
                
                minutes = 0;
                hours = 0;
                day = seconds / 86400;
                result = day;
                daysTxt.Text = result.ToString();
            } 
            else if (seconds >= 3600)
                {
                minutes = 0;
                hours = seconds / 3600;
                day = 0;
                result = hours;
                hourTxt.Text = result.ToString();
            }
            else if (seconds >= 60)
            {
                hours = 0;
                day = 0;
                minutes = seconds / 60;
                result = minutes;
                minTxt.Text = result.ToString();
            }
            else
            {
                result = seconds;
                secConvTxt.Text = result.ToString();
            }
            

        }
    }
}
