using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CovidStat
{
    /// <summary>
    /// Interaction logic for GridCustomRow.xaml
    /// </summary>
    public partial class GridCustomRow : UserControl
    {
        private CountryData country;

        public GridCustomRow()
        {
            InitializeComponent();
        }

        public void setCountry(CountryData item)
        {
            country = item;

            //String.Format("{0:n0}", item.TotalConfirmed);

            //FlagImage.Width = 20;
            //FlagImage.Source = item.sendImage();
            CountryName.Text = item.Country;

            TotalText.Text = String.Format("{0:n0}", item.TotalConfirmed);
            NewText.Text = String.Format("+{0:n0}", item.NewConfirmed);

            DeathsText.Text = String.Format("{0:n0}", item.TotalDeaths);
            NewDeathsText.Text = String.Format("+{0:n0}", item.NewDeaths);

            RecoveredText.Text = String.Format("{0:n0}", item.TotalRecovered);
            NewRecoveredText.Text = String.Format("+{0:n0}", item.NewRecovered);
        }
    }
}
