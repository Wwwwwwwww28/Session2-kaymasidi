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

namespace KaymasidiProg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> sort = new List<string>();
            sort.Add("Наименование↑");
            sort.Add("Наименование↓");
            sort.Add("Номер производственного цеха↑");
            sort.Add("Номер производственного цеха↓");
            sort.Add("Мин.стоимость↑");
            sort.Add("Мин.стоимость↓");
            ComBox_Sort.ItemsSource = sort;


            ComBox_Filt.ItemsSource = user13Entities.getContext().ProductsTypes.ToList();
            ComBox_Filt.DisplayMemberPath = "Name";
        }

        private void ButDelete_Click(object sender, RoutedEventArgs e)
        {
            AddWind addWind = new AddWind();
            addWind.Show();
            this.Close();
        }

        private void ComBox_Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Text_box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
