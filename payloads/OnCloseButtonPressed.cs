/// <summary>
/// This is not the entire code, just the event and assemblies.
/// </summary>

// Assemblies:
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

private async void closeButtonPress(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancels the close event
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
