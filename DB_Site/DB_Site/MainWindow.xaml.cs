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
        int i = 0;
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
                newClient.LAST_NAME = $"{i}";
                newClient.ADRESS = "СПБ";
                newClient.PHONE_NUMBER = "7(987)234-15-13";
                newClient.EMAIL = "ttt@test.com";
                newClient.REGULAR = false;
                newClient.DISCOUNT_ID = 2;
                db.CLIENTS.Add(newClient);
                db.SaveChanges();
            }
            i++;
        }

        private void WriteTwoTables_Click(object sender, RoutedEventArgs e)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {
                tb.Text = null;
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
                foreach (var b in clientsDiscounts)
                    tb.Text += string.Format("({0} {1} {2}) ", b.FirstName, b.LastName, b.Percentvalue);
            }
        }

        private void WriteThreeTables_Click(object sender, RoutedEventArgs e)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {
                tb.Text = null;
                var clientsData = from CLIENT in db.CLIENTS
                                  join SALT in db.SALTs on CLIENT.ID equals SALT.CLIENT_ID
                                  join AUTHORIZATION in db.AUTHORIZATIONs on SALT.ID equals AUTHORIZATION.SALT_ID
                                  select new
                                  {
                                      FirstName = CLIENT.FIRST_NAME,
                                      LastName = CLIENT.LAST_NAME,
                                      Salt = SALT.VALUE,
                                      Login = AUTHORIZATION.LOGIN,
                                      Pass = AUTHORIZATION.PASSWORD
                                  };
                foreach (var c in clientsData)
                    tb.Text += string.Concat($"Имя: {c.FirstName}" +
                        $"\n Фамилия: {c.LastName}" +
                        $"\n Логин: {c.Login}" +
                        $"\n Пароль: {c.Pass}" +
                        $"\n Соль: {c.Salt}" +
                        $"\n");
            }
        }

        private void Alter_Click(object sender, RoutedEventArgs e)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {
                CLIENT p1 = db.CLIENTS.Where((client) => client.FIRST_NAME == "!").FirstOrDefault();
                p1.FIRST_NAME = "ИЗМЕНЕНО";
                db.SaveChanges();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {
                DISCOUNT p1 = db.DISCOUNTS.Where((discount) => discount.SUM_NEEDED > 15000).FirstOrDefault();
                
                if (p1 != null)
                {
                    db.DISCOUNTS.Remove(p1);
                    db.SaveChanges();
                }
                db.SaveChanges();
            }
        }
    }
}
