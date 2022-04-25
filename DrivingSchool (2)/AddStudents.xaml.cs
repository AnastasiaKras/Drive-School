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
    /// Логика взаимодействия для AddStudents.xaml
    /// </summary>
    public partial class AddStudents : Window
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GroupStudents GroupStudents = new GroupStudents();
            GroupStudents.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((Category.Text.Length > 0) && (Group.Text.Length > 0) && (Ps.Text.Length > 0) && (FIO.Text.Length > 0) && (Dr.Text.Length > 0) && (Mh.Text.Length > 0) && (Phone.Text.Length > 0) && (Sns.Text.Length > 0) && (Dv.Text.Length > 0) && (Kv.Text.Length > 0))
            {
                SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Students (ФИО, [Паспортные данные], [Дата рождения], [Место жительства], [Серия и номер справки], [Дата выдачи], [Кем выдана], Телефон, Категория, Группа) Values ('" + FIO.Text + "','" + Ps.Text + "','" + Dr.Text + "','" + Mh.Text + "','" + Sns.Text + "','" + Dv.Text + "','" + Kv.Text + "','" + Phone.Text + "','" + Category.Text + "', '" + Group.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ученик зарегистрирован!");
                Students Students = new Students();
                Students.Show();
                this.Close();
            }
            else MessageBox.Show("Проверьте введённые данные");
        }
    }
}
