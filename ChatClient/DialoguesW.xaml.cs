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
    /// Логика взаимодействия для DialoguesW.xaml
    /// </summary>
    public partial class DialoguesW : Window
    {
        public DialoguesW()
        {
            InitializeComponent();
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

        private void bt_SearchVacancy_Click(object sender, RoutedEventArgs e)
        {
            ListVacancy listVacancy = new ListVacancy();

            listVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            listVacancy.Show();
            listVacancy.bt_SearchVacancies.IsEnabled = false;

            listVacancy.lb_LoginW.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                listVacancy.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void bt_GoChatWorker_Click(object sender, RoutedEventArgs e)
        {
            ChatW chatw = new ChatW();

            chatw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            chatw.tbUserNameChat.IsEnabled = false;
            chatw.tbUserNameChat.Text = lb_Login.Content.ToString();
            chatw.lb_LoginW.Content = lb_Login.Content;
            chatw.Show();

            Close();
        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_PersonalWorker_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            worker.Show();
            worker.bt_PersonalWorker.IsEnabled = false;

            worker.lb_LoginW.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                worker.lb_ActivityWorker.Content = CurrentUser.ActivityWorker;
                worker.tb_NameWorker.Text = CurrentUser.Name;
                worker.tb_SurnameWorker.Text = CurrentUser.Surname;
                worker.tb_PatronymicWorker.Text = CurrentUser.Patronymic;
                worker.tb_EducationWorker.Text = CurrentUser.EducationWorker;
                worker.tb_DataOfBirthWorker.Text = CurrentUser.DataOfBirthWorker;
                worker.tb_ActivityWorker.Text = CurrentUser.ActivityWorker;
                worker.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }
    }
}
