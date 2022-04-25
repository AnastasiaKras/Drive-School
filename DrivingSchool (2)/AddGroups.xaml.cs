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
    /// Логика взаимодействия для AddGroups.xaml
    /// </summary>
    public partial class AddGroups : Window
    {
        public AddGroups()
        {
            InitializeComponent();            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((Category.Text.Length > 0) && (Group.Text.Length > 0) && (So.Text.Length > 0) && (FIO.Text.Length > 0))
            {
                SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Groups (Категория, Группа, [Сроки обучения], Преподаватель) Values ('" + Category.Text + "', '" + Group.Text + "','" + So.Text + "','" + Convert.ToString(FIO.Text) + "')", connection);
                cmd.ExecuteNonQuery();
                DataBaseDSEntities context = new DataBaseDSEntities();
                context.SaveChanges();
                connection.Close();
                MessageBox.Show("Группа добавлена!");
                GroupStudents GroupStudents = new GroupStudents();
                GroupStudents.Show();
                this.Close();
            }
            else MessageBox.Show("Проверьте введённые данные");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GroupStudents GroupStudents = new GroupStudents();
            GroupStudents.Show();
            this.Close();
        }
    }
}
