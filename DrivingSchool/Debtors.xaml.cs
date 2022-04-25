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
    /// Логика взаимодействия для Debtors.xaml
    /// </summary>
    public partial class Debtors : Window
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл

        public Debtors()
        {
            InitializeComponent();

            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 ";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
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
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='A'";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='B'";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='C'";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='D'";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DG.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            if (Category.Text == "A")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='A' AND Группа='1'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();
                
            }
            else if (Category.Text == "B")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='B' AND Группа='1'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();
                               
            }
            else if (Category.Text == "C")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='C' AND Группа='1'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();
                                
            }
            else if (Category.Text == "D")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='D' AND Группа='1'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();
                                
            }


        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            if (Category.Text == "A")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='A' AND Группа='2'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();

            }
            else if (Category.Text == "B")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='B' AND Группа='2'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();

            }
            else if (Category.Text == "C")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='C' AND Группа='2'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();

            }
            else if (Category.Text == "D")
            {
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма задолженности] FROM Students WHERE [Сумма задолженности] > 0 AND Категория='D' AND Группа='2'";
                SqlCommand command = new SqlCommand(cmd, connection);
                connection.Open();
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Students"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DG.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();


            }
        }
                
    }
}
