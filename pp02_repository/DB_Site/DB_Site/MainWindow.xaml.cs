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

namespace DB_Site
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {
                CLIENT newClient = new CLIENT();
                newClient.FIRST_NAME = "Алиса";
                newClient.LAST_NAME = "Тест";
                newClient.ADRESS = "СПБ";
                newClient.PHONE_NUMBER = "7(987)234-15-13";
                newClient.EMAIL = "ttt@test.com";
                newClient.REGULAR = false;
                db.CLIENTS.Add(newClient);
                db.SaveChanges();
            }
        }

        private void WriteTwoTables_Click(object sender, RoutedEventArgs e)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {

                var clientsDiscounts = db.CLIENTS.Join(db.DISCOUNTS,
                    CLIENT => CLIENT.DISCOUNT_ID,
                    DISCOUNT => DISCOUNT.ID,
                    (CLIENT, DISCOUNT) => new
                    {
                        Percentvalue = DISCOUNT.PERCENT_VALUE,
                        SumNeeded = DISCOUNT.SUM_NEEDED,
                        FirstName = CLIENT.FIRST_NAME,
                        LastName = CLIENT.LAST_NAME
                    });
                ;
            }
        }
    }
}
