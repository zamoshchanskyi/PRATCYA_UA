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
using ChatClient.DataBase;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для ListVacancy.xaml
    /// </summary>
    public partial class ListVacancy : Window
    {
        public ListVacancy()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = AppData.db.vacancy.ToList();
            dataGridVacancy.ItemsSource = list.Where(x => !string.IsNullOrEmpty(x.Login));
        }

        private void bt_PersonalWorker_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            worker.Show();
            worker.bt_PersonalWorker.IsEnabled = false;

            worker.lb_LoginW.Content = lb_LoginW.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_LoginW.Content.ToString());
            if (CurrentUser != null)
            {
                worker.lb_ActivityWorker.Content = CurrentUser.ActivityWorker;
                worker.tb_NameWorker.Text = CurrentUser.Name;
                worker.tb_SurnameWorker.Text = CurrentUser.Surname;
                worker.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
                worker.tb_PatronymicWorker.Text = CurrentUser.Patronymic;
                worker.tb_EducationWorker.Text = CurrentUser.EducationWorker;
                worker.tb_DataOfBirthWorker.Text = CurrentUser.DataOfBirthWorker;
                worker.tb_ActivityWorker.Text = CurrentUser.ActivityWorker;
            }

            Close();
        }

        private void bt_SearchVacancies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {
            DialoguesW dialoguesw = new DialoguesW();
            dialoguesw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialoguesw.Show();
            dialoguesw.bt_DialoguesWorker.IsEnabled = false;
            dialoguesw.lb_Login.Content = lb_LoginW.Content;
            dialoguesw.tb_UserNameChatWorker.IsEnabled = false;

            var CurrentWorker = AppData.db.vacancy.FirstOrDefault(u => u.Login_Vidgyk == lb_LoginW.Content.ToString());
            if (CurrentWorker != null)
            {
                dialoguesw.tb_UserNameChatWorker.Text = CurrentWorker.Login;
            }

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_LoginW.Content.ToString());
            if (CurrentUser != null)
            {
                dialoguesw.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
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

        private void bt_Podrobici_Click(object sender, RoutedEventArgs e)
        {
            VacancyMore vacancyMore = new VacancyMore();

            personalWorker personalWorker = new personalWorker();

            vacancy CurrentID = ((sender as Button)?.DataContext as vacancy);

            if (CurrentID != null)
            {
                vacancyMore.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                vacancyMore.Show();

                vacancyMore.lb_Login.Content = lb_LoginW.Content;

                var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == CurrentID.Login);
                if (CurrentUser != null)
                {
                    vacancyMore.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
                    vacancyMore.tb_Company.Text = CurrentUser.Company;
                }

                vacancyMore.lb_NameVacancy.Content = CurrentID.position.ToString();
                vacancyMore.tb_City.Text = CurrentID.city;
                vacancyMore.tb_Description.Text = CurrentID.description;
                vacancyMore.tb_Employment.Text = CurrentID.employment;
                vacancyMore.tb_Position.Text = CurrentID.position;
                vacancyMore.tb_Salary.Text = CurrentID.salary;

                Close();
            }
            else
            {
                MessageBox.Show("Помелка!");
            }
        }
    }
}
