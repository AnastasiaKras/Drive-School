using System;
using System.IO;
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
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Window
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\курсовой проект\DrivingSchool\DrivingSchool\DataBaseDS.mdf; Integrated Security = True"); //строка подкл

        public Students()
        {
            InitializeComponent();               

            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students ";
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
            GroupStudents GroupStudents = new GroupStudents();
            GroupStudents.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddStudents AddStudents = new AddStudents();
            AddStudents.Show();
            this.Close();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='A'";
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
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='B'";
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
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='C'";
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
            string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='D'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='A' AND Группа='1'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='B' AND Группа='1'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='C' AND Группа='1'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='D' AND Группа='1'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='A' AND Группа='2'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='B' AND Группа='2'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='C' AND Группа='2'";
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
                string cmd = "SELECT ФИО, Телефон, [Дата рождения], [Паспортные данные], [Место жительства], [Сумма оплаты] FROM Students WHERE Категория='D' AND Группа='2'";
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
               
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DG.SelectAllCells();
            DG.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, DG);
            DG.UnselectAllCells();
            var result = (string)Clipboard.GetData(DataFormats.Text);
            dynamic wordApp = null;
            try
            {
                var sw = new StreamWriter("export.doc");
                sw.WriteLine(result);
                sw.Close();
                //var proc = Process.Start("export.doc");
                Type wordType = Type.GetTypeFromProgID("Word.Application");
                wordApp = Activator.CreateInstance(wordType);
                wordApp.Documents.Add(System.AppDomain.CurrentDomain.BaseDirectory + "export.doc");
                dynamic wdTable = wordApp.ActiveDocument.Range.ConvertToTable(1, DG.Items.Count, DG.Columns.Count);
                FormatTable(wdTable);
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                if (wordApp != null)
                {
                    wordApp.Quit();
                }
                // ignored
            }
        }
        private void FormatTable(dynamic table)
        {
            dynamic borders = table.Borders;
            //wdBorderLeft
            borders[-2].LineStyle = 1;//wdLineStyleSingle
            borders[-2].LineWidth = 12;//wdLineWidth150pt
            borders[-2].Color = -16777216;
            //wdBorderRight
            borders[-4].LineStyle = 1;//wdLineStyleSingle
            borders[-4].LineWidth = 12;//wdLineWidth150pt
            borders[-4].Color = -16777216;
            //wdBorderTop
            borders[-1].LineStyle = 1;//wdLineStyleSingle
            borders[-1].LineWidth = 12;//wdLineWidth150pt
            borders[-1].Color = -16777216;
            //wdBorderBottom
            borders[-3].LineStyle = 1;//wdLineStyleSingle
            borders[-3].LineWidth = 12;//wdLineWidth150pt
            borders[-3].Color = -16777216;
            //wdBorderHorizontal
            borders[-5].LineStyle = 1;//wdLineStyleSingle
            borders[-5].LineWidth = 6;//wdLineWidth075pt 
            borders[-5].Color = -16777216;
            //wdBorderVertical
            borders[-6].LineStyle = 1;//wdLineStyleSingle
            borders[-6].LineWidth = 12;//wdLineWidth150pt
            borders[-6].Color = -16777216;
        }
    }
}
