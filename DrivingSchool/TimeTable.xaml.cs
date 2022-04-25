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
using System.Reflection;

namespace DrivingSchool
{
    /// <summary>
    /// Логика взаимодействия для TimeTable.xaml
    /// </summary>
    public partial class TimeTable : Window
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл

        public TimeTable()
        {
            InitializeComponent();
            string cmd = "SELECT №, Время, Понедельник, Вторник, Среда, Четверг, Пятница, Суббота FROM Timetable ";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Timetable"); // В скобках указываем название таблицы
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

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
