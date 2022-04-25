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
using System.Data;
using System.Data.SqlClient;

namespace DrivingSchool
{
    /// <summary>
    /// Логика взаимодействия для Graduates.xaml
    /// </summary>
    public partial class Graduates : Window
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл
        public Graduates()
        {
            InitializeComponent();

            string cmd = "SELECT * FROM Graduates ";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Graduates"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Close();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT * FROM Graduates WHERE [Год выпуска]='2020'";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Graduates"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT * FROM Graduates WHERE [Год выпуска]='2019'";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Graduates"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        
    }
}
