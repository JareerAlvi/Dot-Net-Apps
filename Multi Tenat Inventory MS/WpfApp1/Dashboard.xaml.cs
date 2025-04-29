using System;
using System.Windows;
using System.Linq;
using WpfApp1;

namespace IMS
{
    public partial class Dashboard : Window
    {
        private User _loggedInUser;
        private IMSEntities _context;

        public Dashboard(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            _context = new IMSEntities();

            LoadData();
        }

        private void LoadData()
        {
            int tenantId = _loggedInUser.TenantID;
            var products = _context.Products.Where(p => p.TenantID == tenantId).ToList();
            dgProducts.ItemsSource = products;


            txtTotalProducts.Text = products.Count.ToString();
            txtOutOfStock.Text = products.Count(p => p.Quantity == 0).ToString();
            txtLowStock.Text = products.Count(p => p.Quantity < 10 && p.Quantity > 0).ToString();
            int totalQuantity = products.Sum(p => p.Quantity);
            double averageQuantity = products.Count > 0 ? products.Average(p => p.Quantity) : 0;
            int inStockCount = products.Count(p => p.Quantity > 0);

            txtTotalQuantity.Text = totalQuantity.ToString();
            txtAverageQuantity.Text = averageQuantity.ToString("F2");
            txtInStock.Text = inStockCount.ToString();

            var orders = _context.Orders.Where(o => o.TenantID == tenantId).ToList();
            dgOrders.ItemsSource = orders;

 
            var users = _context.Users.Where(u => u.TenantID == tenantId).ToList();
            dgUsers.ItemsSource = users;

            tabUsers.Visibility = Visibility.Collapsed;
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {

            var selectedProduct = dgProducts.SelectedItem as Product;

            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }


            int quantity = 1; 


            if (selectedProduct.Quantity < quantity)
            {
                MessageBox.Show("Not enough stock for this order.");
                return;
            }


            var order = new Order
            {
                ProductID = selectedProduct.ProductID,
                Quantity = quantity,
                TenantID = _loggedInUser.TenantID, 
                OrderDate = DateTime.Now
            };


            _context.Orders.Add(order);

            selectedProduct.Quantity -= quantity;


            _context.SaveChanges();


            MessageBox.Show("Order created successfully!");


            LoadData();
        }

    }
}
