using ChatClient.DataBase;
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

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Dialogues.xaml
    /// </summary>
    public partial class Dialogues : Window
    {
        public Dialogues()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void bt_GoChatWorker_Click(object sender, RoutedEventArgs e)
        {
            Chat chat = new Chat();

            chat.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            chat.tbUserNameChat.IsEnabled = false;
            chat.lb_Login.Content = lb_Login.Content;
            chat.tbUserNameChat.Text = lb_Login.Content.ToString();

            chat.Show();

            Close();
        }

        private void bt_PersonalEmployer_Click(object sender, RoutedEventArgs e)
        {
            Employer employer = new Employer();
            employer.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            employer.Show();
            employer.bt_PersonalEmployer.IsEnabled = false;

            employer.lb_Login.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                employer.tb_NameEmployer.Text = CurrentUser.Name;
                employer.tb_SurnameEmployer.Text = CurrentUser.Surname;
                employer.tb_PatronymicEmployer.Text = CurrentUser.Patronymic;
                employer.tb_DataOfBirthEmployer.Text = CurrentUser.DataOfBirthWorker;
                employer.tb_Company.Text = CurrentUser.Company;
                employer.lb_Company.Content = CurrentUser.Company.ToString();
                employer.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_CreateVacancy_Click(object sender, RoutedEventArgs e)
        {

            CreateVacancy createVacancy = new CreateVacancy();
            createVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            createVacancy.Show();
            createVacancy.bt_CreateVacancy.IsEnabled = false;
            createVacancy.lb_Login.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {

                createVacancy.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_MyVacancy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_MainWindow_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();

            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();

            mainWindow.tbLoginMW.Text = "";
            mainWindow.tbPassMW.Password = "";

            Close();
        }
    }
}
