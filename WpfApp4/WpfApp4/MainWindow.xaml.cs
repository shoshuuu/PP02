using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp4
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                SqlParameter login = new SqlParameter();
                login.ParameterName = "@login";
                login.SqlDbType = System.Data.SqlDbType.NVarChar;
                login.Value = tbLogin.Text;
                login.Size = 50;
                login.Direction = System.Data.ParameterDirection.Input;

                SqlParameter password = new SqlParameter();
                password.ParameterName = "@password";
                password.SqlDbType = System.Data.SqlDbType.NVarChar;
                password.Value = tbPassword.Text;
                password.Size = 50;
                password.Direction = System.Data.ParameterDirection.Input;

                SqlParameter result = new SqlParameter();
                result.ParameterName = "@result";
                result.SqlDbType = System.Data.SqlDbType.NVarChar;
                result.Direction = System.Data.ParameterDirection.Output;
                result.Size = 250;

                db.Database.ExecuteSqlCommand("exec AddAccount @login, @password, @result OUTPUT",
                  login, password, result);
                tblResult.Text = (string)result.Value;
            }
        }

        private void btnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                SqlParameter login = new SqlParameter();
                login.ParameterName = "@login";
                login.SqlDbType = System.Data.SqlDbType.NVarChar;
                login.Value = tbLogin.Text;
                login.Size = 50;
                login.Direction = System.Data.ParameterDirection.Input;

                SqlParameter password = new SqlParameter();
                password.ParameterName = "@password";
                password.SqlDbType = System.Data.SqlDbType.NVarChar;
                password.Value = tbPassword.Text;
                password.Size = 50;
                password.Direction = System.Data.ParameterDirection.Input;

                SqlParameter result = new SqlParameter();
                result.ParameterName = "@result";
                result.SqlDbType = System.Data.SqlDbType.NVarChar;
                result.Direction = System.Data.ParameterDirection.Output;
                result.Size = 250;

                db.Database.ExecuteSqlCommand("exec UserLogin @login, @password, @result OUTPUT",
                  login, password, result);
                tblResult.Text = (string)result.Value;
            }
        }
    }
}
