/*CB.ItemsSource = ProductsDBEntities.getContext().TypesOfProducts.ToList();
CB.DisplayMemberPath = "Name";*/

/*List<string> sort = new List<string>();
sort.Add("1");
        sort.Add("2");

        CB.ItemsSource = sort;
        **
        <ListBox x:Name="LB" ItemsSource="{Binding Path=VW_pohyi}" Width="auto">
        **
        public partial class ProductsDBEntities
{
    private static ProductsDBEntities _context;
    public static ProductsDBEntities getContext()
    {
        if (_context == null)
        {
            _context = new ProductsDBEntities();
        }
        return _context;
    }
}
**
private void Save_Click(object sender, RoutedEventArgs e)
{
    Products products = new Products();
    products.Name = TexB.Text;
    ProductsDBEntities.getContext().Products.Add(products);
    ProductsDBEntities.getContext().SaveChanges();*/