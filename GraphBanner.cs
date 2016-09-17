using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAS_csharp
{
    public partial class GraphBanner : UserControl
    {
        public GraphBanner()
        {
            InitializeComponent();
        }

        #region Properties

        private int tempUpdateRate = 25000;
        
        /// <summary>
        /// Rate of the advertisement update
        /// </summary>
        public int UpdateRate
        {
            get
            {
                return tempUpdateRate;
            }
            set
            {
                tempUpdateRate = value;
                GraphUpdater.Interval = value;
            }
        }

        private static int tempdeveloperid;

        /// <summary>
        /// Ninponix ID of the developer
        /// </summary>
        public static int DeveloperID
        {
            get
            {
                return tempdeveloperid;
            }
            set
            {
                tempdeveloperid = value;
            }
        }

        #endregion

        //private string nas_server_URL = @"C:\Users\Chamuth Chamandana\Desktop\graph_banner_link.nas";
        private string nas_server_URL = "http://www.ninponix.net/nas" + DeveloperID.ToString() + "/graph_banner_link.nas";
        private string temp_nas_storage = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\graph_banner_link.nas";

        private void GraphBanner_Load(object sender, EventArgs e)
        {
            //Download the advertisement if internet connection is available
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.DownloadFileAsync(new Uri(nas_server_URL), temp_nas_storage);
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            }
            catch (Exception)
            {

            }
        }

        string link_content = "";

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Download has been completed
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(temp_nas_storage))
                {
                    link_content = sr.ReadToEnd();
                    sr.Close();
                }
                UpdateAdvertisement();
            }
            catch (Exception)
            {

            }
        }

        int current_advertisement_index = -1;

        private string LinkURL = "";

        public void UpdateAdvertisement()
        {
            try
            {
                //Change the advertisement index
                if (current_advertisement_index == link_content.Split('\n').Length)
                {
                    current_advertisement_index = 0;
                }
                else
                {
                    current_advertisement_index++;
                }

                //Render the advertisement;
                string current_line = link_content.Split('\n')[current_advertisement_index];
                string imageURL = current_line.Split(';')[0];
                string next_URL = current_line.Split(';')[1];

                LinkURL = next_URL;
                graph_view.ImageLocation = imageURL;
            }
            catch (Exception)
            {

            }
        }

        private void GraphUpdater_Tick(object sender, EventArgs e)
        {
            UpdateAdvertisement();
        }

        private void graph_view_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LinkURL);
        }
    }
}
