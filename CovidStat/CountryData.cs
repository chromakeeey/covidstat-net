using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CovidStat
{
    public class CountryData
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public DateTime Date { get; set; }

        public CountryData()
        {
            Country = "";
            CountryCode = "";
            Slug = "";
            NewConfirmed = 0;
            TotalConfirmed = 0;
            NewDeaths = 0;
            TotalDeaths = 0;
            NewRecovered = 0;
            TotalRecovered = 0;
            Date = DateTime.Now;
        }

        private BitmapImage Bitmap2BitmapImage(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = ms;
                bi.EndInit();

                return bi;
            }
        }

        public BitmapImage sendImage()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\flags\" +
                String.Format("{0}.png", CountryCode.ToLower());

            return Bitmap2BitmapImage(new Bitmap(path));
        }
    }
}
