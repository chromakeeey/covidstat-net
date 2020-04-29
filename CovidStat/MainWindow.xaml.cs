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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CovidData covidData;
        private List<GridCustomRow> rowGrid;

        public MainWindow()
        {
            InitializeComponent();

            rowGrid = new List<GridCustomRow>();
            rowGrid.Clear();

            covidData = new CovidData();
            covidData = JsonOperation.sendItemData();

            var item = from u in covidData.Countries
                       orderby u.TotalConfirmed descending
                       select u;

            updateGrid(item.ToList());
            updateHeader(covidData.Global);
        }

        private void clearGrid()
        {
            foreach (var item in rowGrid)
            {
                item.Visibility = Visibility.Hidden;
            }

            GridStackPanel.Children.Clear();
            rowGrid.Clear();
        }

        private void updateGrid(List<CountryData> item)
        {
            clearGrid();

            foreach (var obj in item)
            {
                rowGrid.Add(new GridCustomRow());
                int Index = rowGrid.Count - 1;

                rowGrid[Index].Height = 40;
                rowGrid[Index].Margin = new Thickness(50, 1, 50, 1);
                rowGrid[Index].setCountry(obj);

                GridStackPanel.Children.Add(rowGrid[Index]);
                
            }
        }

        private void updateHeader(GlobalData item)
        {
            totalConfirmed.Text = String.Format("{0:n0}", item.TotalConfirmed);
            totalRecovered.Text = String.Format("{0:n0}", item.TotalRecovered); 
            totalDeaths.Text = String.Format("{0:n0}", item.TotalDeaths);
        }

        private void countryClicked(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(field_Country.Text))
            {
                string filter = field_Country.Text;

                var item = from u in covidData.Countries
                           where u.Country.StartsWith(filter) 
                           select u;

                updateGrid(item.ToList());
            }
            else
                MessageBox.Show("Поле не заполнено.");
        }

        private void minusClicked(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(field_Minus.Text))
            {
                int value;

                if (int.TryParse(field_Minus.Text, out value))
                {
                    var item = from u in covidData.Countries
                               where u.TotalConfirmed <= value
                               select u;

                    item = from u in item
                           orderby u.TotalConfirmed descending
                           select u;

                    updateGrid(item.ToList());
                }
                else
                    MessageBox.Show("Число указано неверно");

            }
            else
                MessageBox.Show("Поле не заполнено.");
        }

        private void plusClicked(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(field_Plus.Text))
            {
                int value;

                if (int.TryParse(field_Plus.Text, out value))
                {
                    var item = from u in covidData.Countries
                               where u.TotalConfirmed >= value
                               select u;

                    item = from u in item
                           orderby u.TotalConfirmed descending
                           select u;

                    updateGrid(item.ToList());
                }
                else
                    MessageBox.Show("Число указано неверно");
            }
            else
                MessageBox.Show("Поле не заполнено.");
        }
    }
}
