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
    /// Логика взаимодействия для VacancyMore.xaml
    /// </summary>
    public partial class VacancyMore : Window
    {
        public VacancyMore()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

        private void bt_DialoguesEmployer_Click(object sender, RoutedEventArgs e)
        {
            DialoguesW dialoguesw = new DialoguesW();
            dialoguesw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialoguesw.Show();
            dialoguesw.bt_DialoguesWorker.IsEnabled = false;
            dialoguesw.lb_Login.Content = lb_Login.Content;
            dialoguesw.tb_UserNameChatWorker.IsEnabled = false;

            var CurrentWorker = AppData.db.vacancy.FirstOrDefault(u => u.Login_Vidgyk == lb_Login.Content.ToString());
            if (CurrentWorker != null)
            {
                dialoguesw.tb_UserNameChatWorker.Text = CurrentWorker.Login;
            }

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                dialoguesw.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_PersonalEmployer_Click(object sender, RoutedEventArgs e)
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

        private void bt_Vidguk_Click(object sender, RoutedEventArgs e)
        {
            Dialogues dialogues = new Dialogues();
            vacancy vacancy = new vacancy();

            
            var CurrentVacancy = AppData.db.vacancy.FirstOrDefault(r => r.position == tb_Position.Text);
            if (CurrentVacancy != null)
            {
                CurrentVacancy.Login_Vidgyk = lb_Login.Content.ToString();

                AppData.db.SaveChanges();
            }
        }

        private void bt_SearchVacancy_Click(object sender, RoutedEventArgs e)
        {
            ListVacancy listVacancy = new ListVacancy();
            listVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            listVacancy.Show();
            listVacancy.bt_PersonalWorker.IsEnabled = false;

            listVacancy.lb_LoginW.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                listVacancy.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }
    }
}
