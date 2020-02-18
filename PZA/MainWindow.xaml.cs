using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace PZA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Obnova_Click(object sender, RoutedEventArgs e)
        {
            

        using (IDbConnection conection = new SqlConnection())
        {

        }
            using (TestDbContext db = new TestDbContext())
            {
                //    var customers = db.Customers;
                //    foreach (Customer pl in customers)
                //    {
                //        Label22.Content = pl.CustomerName; }
                var products = db.Product;
                foreach (Product pl in products)
                {
                    this.ComboBox22.Items.Add(pl.ProductName);
                   //ComboBox22.
                }


            }

        }

        //private void Con_Click(object sender, RoutedEventArgs e)
        //{
        //    using (IDbConnection conection = new SqlConnection())
        //    {

        //    }
        //    using (TestDbContext db = new TestDbContext())
        //    {
        //        //    var customers = db.Customers;
        //        //    foreach (Customer pl in customers)
        //        //    {
        //        //        Label22.Content = pl.CustomerName; }
        //        var customers = db.Customers.Where(p => p.CustomerId == 3);
        //        customers.FirstOrDefault().CustomerName = "Нузо";

        //        db.SaveChanges();


        //    }
    }

    }
        //public static List<Customer> GetCustomersEf()
        //{
        //    //var context = new TestDbContext();
        //    //IQueryable<Customer> query = context.Customers;
        //    //List<Customer> customers = query.ToList();

        //    //return customers;



        //    var context = new TestDbContext();
        //    var query = from c in context.Customers
        //                where c.CustomerId == 1
        //                select c;
        //    List<Customer> customers = query.ToList();
        //    return customers;
        //}


