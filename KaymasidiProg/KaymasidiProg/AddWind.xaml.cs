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
using System.Windows.Shapes;

namespace KaymasidiProg
{
    /// <summary>
    /// Логика взаимодействия для AddWind.xaml
    /// </summary>
    public partial class AddWind : Window
    {
        public AddWind()
        {
            InitializeComponent();
            

            ComBTipe.ItemsSource = user13Entities.getContext().ProductsTypes.ToList();
            ComBTipe.DisplayMemberPath = "Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Products products = new Products();
            products.Name = tbName.Text;
            products.MinPrice = Convert.ToInt32(tbPrice.Text);
            products.Article = Convert.ToInt32(tbArt.Text);
            products.ProductTypeID = ComBTipe.SelectedIndex;
            user13Entities.getContext().Products.Add(products);
            user13Entities.getContext().SaveChanges();
        }

        private void ComBTipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
