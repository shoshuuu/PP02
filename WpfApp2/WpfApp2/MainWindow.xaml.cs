using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ClientsContext();
            db.Clients.Load();
            dgClients.ItemsSource = db.Clients.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }

        private void bUpdate_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgClients.SelectedItems.Count > 0)
            {
                for (int i = 0; i < dgClients.SelectedItems.Count; i++)
                {
                    Client c = dgClients.SelectedItems[i] as Client;
                    if (c != null)
                        db.Clients.Remove(c);
                }
            }
            db.SaveChanges();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
    }
}
