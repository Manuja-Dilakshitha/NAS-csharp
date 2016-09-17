/*

TEXT BANNER TUTORIAL
====================

TEXT BANNER IS A BANNER ADVERTISEMENT THAT REPRESENTS ONLY 2 TEXT ELEMENTS, THE ADVERTISEMENT TITLE AND THE 
ADVERTISEMENT DESCRIPTION.

1. Drag and Drop TextBanner Control from your project's toolbox. (If it does not appear try building the project).
2. Arrange it where you want and anchor it to the position you need it to be. (Automatic anchoring has been
disabled due to protection levels).
3. In the first form or the form where you start monetising (previwing ads) your application, put this code
in the Form's Load function. 

TextBanner.DeveloperID = 0;

Make sure you replace the 0 with your Ninponix Developer ID (new constitution, according to 2016 Sept).

4. Change the BannerTitle and BannerDescription and the LinkURL to adjust the default content which is shown 
when there is no internet connection available for users.
5. Good luck

*/


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
    public partial class TextBanner : UserControl
    {
        public TextBanner()
        {
            InitializeComponent();
            UpdateBanner();
            BannerChanger.Interval = AdUpdateRate;
        }

        #region Methods
        /// <summary>
        /// Update the banner location, docking and the size using the properties specified by the developer
        /// </summary>
        public void UpdateBanner()
        {
            try
            {
                //Change the size of the advertisement
                switch (BannerSizeFormat)
                {
                    case BannerSize.Normal:
                        Width = 300;
                        Height = 75;
                        break;
                    case BannerSize.Wide:
                        Width = 500;
                        Height = 75;
                        break;
                }

                bannerTitle.Text = BannerTitle;
                bannerDescription.Text = BannerDescription;

                bannerTitle.Font = Font;
                bannerDescription.Font = BannerDescriptionFont;
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Properties

        private string templinkurl = "";

        /// <summary>
        /// Link of the current offline advertisement
        /// </summary>
        public string LinkURL
        {
            get
            {
                return templinkurl;
            }
            set
            {
                templinkurl = value;
            }
        }

        private static int tempDeveloperID = 0;
    
        /// <summary>
        /// Developer ID used to track downloads from a certain user
        /// </summary>
        public static int DeveloperID
        { 
            get
            {
                return tempDeveloperID;
            }
            set
            {
                tempDeveloperID = value;
            }
        }

        private int tempUpdateRate = 25000;

        /// <summary>
        /// The rate of changing the advertisement. Default is 25000 (25 seconds)
        /// </summary>
        public int AdUpdateRate
        {
            get
            {
                return tempUpdateRate;
            }
            set
            {
                tempUpdateRate = value;
                BannerChanger.Interval = value;
            }
        }

        private Font tempBannerdescriptionfont = new Font("Segoe UI Semilight", 12);
        /// <summary>
        /// The font of the description of the banner advertisement.
        /// </summary>
        public Font BannerDescriptionFont
        {
            get
            {
                return tempBannerdescriptionfont;
            }
            set
            {
                tempBannerdescriptionfont = value;
                UpdateBanner();
            }
        }

        private BannerSize tempsize = BannerSize.Normal;
        /// <summary>
        /// Size of the banner. 300x100 is default (normal).
        /// </summary>
        public BannerSize BannerSizeFormat
        {
            get
            {
                return tempsize;
            }
            set
            {
                tempsize = value;
                UpdateBanner();
            }
        }

        private string TempBannerText = "Banner Text";
        /// <summary>
        /// Title of the banner advertisement
        /// </summary>
        public string BannerTitle
        {
            get
            {
                return TempBannerText;
            }
            set
            {
                TempBannerText = value;
                UpdateBanner();
            }
        }

        private string tempBannerDescription = "Banner Description";
        /// <summary>
        /// Description of the banner advertisement.
        /// </summary>
        public string BannerDescription
        {
            get
            {
                return tempBannerDescription;
            }
            set
            {
                tempBannerDescription = value;
                UpdateBanner();
            }
        }

        #endregion

        #region Enumerations
        /// <summary>
        /// Size of the banner. 300x100 is default (normal).
        /// </summary>
        public enum BannerSize
        {
            Normal,
            Wide
        }
        #endregion

        //private string nas_server = @"C:\Users\Chamuth Chamandana\Desktop\Banner.nas";
        private string nas_server = "http://www.ninponix.net/nas" + DeveloperID.ToString() + "/banner.nas";
        private string temp_nas_storage = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\nasbanner.nas";

        private void TextBanner_Load(object sender, EventArgs e)
        {
            UpdateBanner();

            //Update the text from internet
            try {
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.DownloadFileAsync(new Uri(nas_server), temp_nas_storage);
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            }
            catch (Exception)
            {
                Console.WriteLine("There is no internet connection available. Input the details yourself.");
            }
        }

        string ad_content = "";
        bool downloaded = false;

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                downloaded = true;
                //Banner information successfully retrieved
                using (System.IO.StreamReader sr = new System.IO.StreamReader(temp_nas_storage))
                {
                    ad_content = sr.ReadToEnd();
                    sr.Close();
                }

                //Represent the advertisements
                UpdateAdvertisements();
            }
            catch (Exception)
            {

            }
        }

        private int current_advertisement = -1;

        private void UpdateAdvertisements()
        {
            try
            {
                if (downloaded == true)
                {
                    if (current_advertisement == ad_content.Split('\n').Length - 1)
                    {
                        current_advertisement = 0;
                    }
                    else
                    {
                        current_advertisement++;
                    }

                    string _line_content = ad_content.Split('\n')[current_advertisement];

                    string _adTitle = _line_content.Split(';')[0];
                    string _adDescription = _line_content.Split(';')[1];
                    string _adURL = _line_content.Split(';')[2];

                    BannerTitle = _adTitle;
                    BannerDescription = _adDescription;
                    LinkURL = _adURL;
                }
            }
            catch (Exception)
            {

            }
        }

        private void TextBanner_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LinkURL);
        }

        private void bannerTitle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LinkURL);
        }

        private void bannerDescription_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LinkURL);
        }

        private void BannerChanger_Tick(object sender, EventArgs e)
        {
            UpdateAdvertisements();
        }
    }
}
