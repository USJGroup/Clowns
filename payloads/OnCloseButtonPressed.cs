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
