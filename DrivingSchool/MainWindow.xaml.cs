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
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace DrivingSchool
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length > 0)
            {
                if (Password.Password.Length > 0)
                {
                    using (var DB = new DataBaseDSEntities())
                    {
                        var user = DB.User.FirstOrDefault(u => u.Email == Login.Text && u.Пароль == Password.Password);
                        if (user == null)
                        {
                            MessageBox.Show("Пользователь не найден");
                        }
                        else
                        {                            
                                //SmtpClient Client = new SmtpClient();
                                //Client.Credentials = new NetworkCredential("asyanikova@bk.ru", "Nikova563");
                                //Client.Host = "smpt.mail.ru";
                                //Client.Port = 587;
                                //Client.EnableSsl = true;

                                ////Формирование письма
                                //MailMessage Mail = new MailMessage();
                                //Mail.From = new MailAddress("asyanikova@bk.ru");
                                //Mail.To.Add(new MailAddress("asyanikova@bk.ru"));
                                //Mail.Subject = "Вход в систему";
                                //Mail.IsBodyHtml = true;
                                //Mail.Body = "Авторизировался пользователь. "+"<br>"+"Логин: " + Login.Text + "<br> " ;

                                //Client.Send(Mail);//отправка
                            
                            Menu Menu = new Menu();
                            Menu.Show();                            
                            this.Close();
                           
                        }
                    }
                }
                else MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста, проверьте ещё раз введенные данные");
            }
            else MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста, проверьте ещё раз введенные данные");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login.Text = null;
            Password.Password = null;            
            
        }

        
    }
}

