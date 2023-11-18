using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace StepifyAppp.Api
{
    public abstract class SpotApi
    {
        static void PlaySong(string url)
        {
            try
            {
                
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
