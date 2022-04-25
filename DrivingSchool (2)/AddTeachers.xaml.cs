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
using System.Data.SqlClient;

namespace DrivingSchool
{
    /// <summary>
    /// Логика взаимодействия для AddTeachers.xaml
    /// </summary>
    public partial class AddTeachers : Window
    {
        public AddTeachers()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((Category.Text.Length > 0) && (CategoryPr.Text.Length > 0) && (Ps.Text.Length > 0) && (FIO.Text.Length > 0) && (Dr.Text.Length > 0) && (Mh.Text.Length > 0) && (Phone.Text.Length > 0))
            {
                SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Teacher (ФИО, [Паспортные данные], [Дата рождения], [Место жительства], Телефон,[Категория преподавания], Категория) Values ('" + FIO.Text + "','" + Ps.Text + "','" + Dr.Text + "','" + Mh.Text + "','" + Phone.Text + "','" + Category.Text + "', '" + CategoryPr.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Преподаватель добавлен!");
                GroupsTeachers GroupsTeachers = new GroupsTeachers();
                GroupsTeachers.Show();
                this.Close();
            }
            else MessageBox.Show("Проверьте введённые данные");        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GroupsTeachers GroupsTeachers = new GroupsTeachers();
            GroupsTeachers.Show();
            this.Close();
        }
    }
}
